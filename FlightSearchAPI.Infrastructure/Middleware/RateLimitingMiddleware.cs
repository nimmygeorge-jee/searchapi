using FlightSearchAPI.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearchAPI.Infrastructure.Middlewares
{
    public class RateLimitingMiddleware
    {
        private readonly RequestDelegate _next;
        private static readonly ConcurrentDictionary<string, RequestCounter> RequestCounts = new ConcurrentDictionary<string, RequestCounter>();
        private readonly int _maxRequests;
        private readonly TimeSpan _timeWindow;

        public RateLimitingMiddleware(RequestDelegate next, int maxRequests = 2, int timeWindowInSeconds = 60)
        {
            _next = next;
            _maxRequests = maxRequests;
            _timeWindow = TimeSpan.FromSeconds(timeWindowInSeconds);
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress?.ToString();
            if (string.IsNullOrEmpty(ipAddress))
                return;

            var requestUrl = context.Request.Path + context.Request.QueryString; 

            var requestKey = $"{ipAddress}:{requestUrl}";

            var requestCounter = RequestCounts.GetOrAdd(requestKey, new RequestCounter());

            if (requestCounter.RequestCount >= _maxRequests && requestCounter.WindowStart <= DateTime.UtcNow)
            {
                var logMessage = $"Rate limit exceeded for IP: {ipAddress}, URL: {requestUrl}. Request count: {requestCounter.RequestCount}.";
                Logger.Instance.Warn(logMessage);

                context.Response.StatusCode = 429;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    success = false,
                    message = "Rate limit exceeded. Try again later.",
                    details = "You have exceeded the allowed number of requests for this URL. Please try again after the rate limit resets.",
                    requestedUrl = requestUrl
                };

                var jsonResponse = JsonConvert.SerializeObject(response);
                await context.Response.WriteAsync(jsonResponse);

                return;
            }

            requestCounter.RequestCount++;
            if (requestCounter.WindowStart <= DateTime.UtcNow)
            {
                requestCounter.WindowStart = DateTime.UtcNow.Add(_timeWindow);
                requestCounter.RequestCount = 1;
            }

            await _next(context);
        }
    }

    public class RequestCounter
    {
        public int RequestCount { get; set; } = 1;
        public DateTime WindowStart { get; set; } = DateTime.UtcNow;
    }
}

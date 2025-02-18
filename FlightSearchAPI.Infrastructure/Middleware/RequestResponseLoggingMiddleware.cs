using FlightSearchAPI.Core.Models;
using FlightSearchAPI.Logging;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearchAPI.Infrastructure.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var log = new RequestResponseLogModel
            {
                RequestDateTimeUtc = DateTime.UtcNow,
                LogId = Guid.NewGuid().ToString(),
                TraceId = httpContext.TraceIdentifier,
                ClientIp = httpContext.Connection.RemoteIpAddress?.ToString(),
                RequestMethod = httpContext.Request.Method,
                RequestPath = httpContext.Request.Path,
                RequestQuery = httpContext.Request.QueryString.ToString(),
                RequestQueries = FormatQueries(httpContext.Request.QueryString.ToString()),
                RequestHeaders = FormatHeaders(httpContext.Request.Headers),
                RequestBody = await ReadBodyFromRequest(httpContext.Request),
                RequestScheme = httpContext.Request.Scheme,
                RequestHost = httpContext.Request.Host.ToString(),
                RequestContentType = httpContext.Request.ContentType
            };

            var originalResponseBody = httpContext.Response.Body;
            using var newResponseBody = new MemoryStream();
            httpContext.Response.Body = newResponseBody;

            try
            {
                // Log Request
                LogRequest(log);

                // Call the next middleware
                await _next(httpContext);
            }
            catch (Exception exception)
            {
                LogError(log, exception);
            }

            newResponseBody.Seek(0, SeekOrigin.Begin);
            var responseBodyText = await new StreamReader(httpContext.Response.Body).ReadToEndAsync();

            newResponseBody.Seek(0, SeekOrigin.Begin);
            await newResponseBody.CopyToAsync(originalResponseBody);

            // Log Response
            log.ResponseContentType = httpContext.Response.ContentType;
            log.ResponseStatus = httpContext.Response.StatusCode.ToString();
            log.ResponseHeaders = FormatHeaders(httpContext.Response.Headers);
            log.ResponseBody = responseBodyText;
            log.ResponseDateTimeUtc = DateTime.UtcNow;

            var contextFeature = httpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (contextFeature?.Error != null)
            {
                LogError(log, contextFeature.Error);
            }

            // Convert log object to JSON string and pass to Logger
            string logJson = JsonConvert.SerializeObject(log);
            Logger.Instance.Info(logJson);
        }

        private void LogRequest(RequestResponseLogModel log)
        {
            string requestLog = JsonConvert.SerializeObject(log); 
            Logger.Instance.Info($"Request Log: {requestLog}");
        }

        private void LogResponse(RequestResponseLogModel log)
        {
            string responseLog = JsonConvert.SerializeObject(log); 
            Logger.Instance.Info($"Response Log: {responseLog}");
        }

        private void LogError(RequestResponseLogModel log, Exception exception)
        {
            log.ExceptionMessage = exception.Message;
            log.ExceptionStackTrace = exception.StackTrace;
        }

        private Dictionary<string, string> FormatHeaders(IHeaderDictionary headers)
        {
            return headers.ToDictionary(header => header.Key, header => string.Join(", ", header.Value));
        }

        private List<KeyValuePair<string, string>> FormatQueries(string queryString)
        {
            return queryString.TrimStart('?')
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .Select(query => query.Split("=", 2))
                .Where(items => items.Length == 2)
                .Select(items => new KeyValuePair<string, string>(items[0], items[1]))
                .ToList();
        }

        private async Task<string> ReadBodyFromRequest(HttpRequest request)
        {
            request.EnableBuffering();
            using var streamReader = new StreamReader(request.Body, leaveOpen: true);
            var requestBody = await streamReader.ReadToEndAsync();
            request.Body.Position = 0; // Reset the stream position for next middleware
            return requestBody;
        }
    }
}

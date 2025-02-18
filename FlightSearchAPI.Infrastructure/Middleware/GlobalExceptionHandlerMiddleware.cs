using FlightSearchAPI.Application.Interfaces;
using FlightSearchAPI.Logging;
using Microsoft.AspNetCore.Http;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightSearchAPI.Infrastructure.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext); 
            }
            catch (SqlException sqlEx)
            {
                Logger.Instance.Error("SQL Exception:", sqlEx);
                await HandleExceptionAsync(httpContext, sqlEx, "A database error occurred.");
            }
            catch (Exception ex)
            {
                Logger.Instance.Error("Exception:", ex);
                await HandleExceptionAsync(httpContext, ex, "An unexpected error occurred.");
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex, string message)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new
            {
                success = false,
                message = message,
                details = ex.Message
            };
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}

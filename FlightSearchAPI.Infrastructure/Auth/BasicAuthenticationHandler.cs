using Azure.Core;
using Azure;
using FlightSearchAPI.Infrastructure.Util;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using System.Text.Json;

namespace FlightSearchAPI.Infrastructure.Auth
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger  _logger;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IConfiguration configuration)
            : base(options, logger, encoder, clock)
        {
            _configuration = configuration;
            _logger = logger.CreateLogger<BasicAuthenticationHandler>();  
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            _logger.LogDebug("Attempting Basic Authentication.");

            var authHeader = Request.Headers["Authorization"].FirstOrDefault();  

            if (string.IsNullOrEmpty(authHeader))
            {
                _logger.LogWarning("Authorization header is missing.");
                return Task.FromResult(AuthenticateResult.Fail("Missing Authorization Header"));
            }

            if (!authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogWarning("Invalid Authorization header format. Expected 'Basic' scheme.");
                return Task.FromResult(AuthenticateResult.Fail("Invalid Authorization Header Format"));
            }

            try
            {
                var encodedCredentials = authHeader.Substring("Basic ".Length).Trim();
                var decodedCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials));
                var parts = decodedCredentials.Split(':');

                if (parts.Length != 2)
                {
                    _logger.LogWarning("Invalid Basic Authentication format, must contain username and password.");
                    return Task.FromResult(AuthenticateResult.Fail("Invalid Basic Authentication Format"));
                }

                var username = parts[0];
                var password = parts[1];

                var encryptedUsername = _configuration["BasicAuth:Username"];
                var encryptedPassword = _configuration["BasicAuth:Password"];

                string keyString = _configuration["EncryptionSettings:Key"];
                string ivString = _configuration["EncryptionSettings:IV"];
                byte[] key = Convert.FromBase64String(keyString);
                byte[] iv = Convert.FromBase64String(ivString);

                var validUsername = EncryptionHelper.Decrypt(encryptedUsername, key, iv);
                var validPassword = EncryptionHelper.Decrypt(encryptedPassword, key, iv);

                _logger.LogDebug("Attempting to authenticate user: {Username}", username);

                if (username == validUsername && password == validPassword)
                {
                    _logger.LogInformation("Authentication successful for user: {Username}", username);

                    var claims = new[] { new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Name, username) };

                    var identity = new System.Security.Claims.ClaimsIdentity(claims, "Basic");
                    var principal = new System.Security.Claims.ClaimsPrincipal(identity);

                    var ticket = new AuthenticationTicket(principal, "Basic");

                    return Task.FromResult(AuthenticateResult.Success(ticket));
                }
                else
                {
                    _logger.LogWarning("Authentication failed for user: {Username}. Invalid credentials.", username);
                    return Task.FromResult(AuthenticateResult.Fail("Invalid Username or Password"));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing Basic Authentication.");
                return Task.FromResult(AuthenticateResult.Fail("Error processing Basic Authentication"));
            }
        }

        protected override Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            _logger.LogWarning("Authentication challenge triggered. Sending 401 Unauthorized response.");

            Response.StatusCode = StatusCodes.Status401Unauthorized;

            var errorResponse = new
            {
                success = false,
                data = (object)null,
                message = "Authentication is required.",
                error = "Invalid or missing credentials"
            };

            Response.ContentType = "application/json";
            return Response.WriteAsync(JsonSerializer.Serialize(errorResponse));


        }
    }

}

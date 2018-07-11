using Microsoft.AspNetCore.Builder;
using Api.Demo.Tests.POCO;
using Api.Demo.Tests.Middleware;
using System;

namespace Api.Demo.Tests.Middleware.Extensions
{
    public static class GreetingMiddlewareExtension
    {
        public static IApplicationBuilder UseGreeting(this IApplicationBuilder app,GreetingOptions options){
            
            return app.UseMiddleware<GreetingMiddleware>(options);
        }

        public static IApplicationBuilder UseGreeting(this IApplicationBuilder app,Action<GreetingOptions> configOptions){
            var option = new GreetingOptions();
            configOptions(option);
            return app.UseMiddleware<GreetingMiddleware>(option);
        }
    }
}
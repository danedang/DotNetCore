using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Api.Demo.Tests.Middleware.Extensions
{
    public static class UseMiddlewareExtension {

        /*
        *
        */
        public static IApplicationBuilder UseHelloWorld(this IApplicationBuilder app){
            return app.Use(async (context, next)=>{
                await context.Response.WriteAsync("hello world (by Use)\n");
                await next();
            });
        }
        /*
        *通过中间件组件类
        */
        public static IApplicationBuilder UseHelloWorldInClass(this IApplicationBuilder app){
            return app.UseMiddleware<HelloDevelopersMiddleware>();
        }

        /*
        *UseMiddleware
         */
        public static IApplicationBuilder UseHelloWorldMiddleware(this IApplicationBuilder app){
            return app.UseMiddleware<HelloWorldMiddleware>();
        }

    }
}
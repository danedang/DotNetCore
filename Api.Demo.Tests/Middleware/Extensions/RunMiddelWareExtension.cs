
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Api.Demo.Tests.Middleware.Extensions
{
    
    public static class  RunMiddelwareExtension
    {

        public static void  RunHelloWorld(this IApplicationBuilder app){
            app.Run(async (context)=>{
                await context.Response.WriteAsync("hello world (By Run)\n");
            });
        }
    }
}
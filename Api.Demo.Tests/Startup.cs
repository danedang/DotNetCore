using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Api.Demo.Tests.Middleware.Extensions;
using Api.Demo.Tests.POCO;

namespace Api.Demo.Tests
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // app.Run(async (context)=>{
            //     await context.Response.WriteAsync("Hello world");
            // });
            app.UseGreeting(new GreetingOptions{
                GreetAt ="GreetAt",
                GreetTo ="GreetTo"
            });
            app.UseGreeting(option=>{
                option.GreetAt = "GreetAt 1";
                option.GreetTo ="GreetTo 1";
            });
            app.UseHelloWorld();
            app.UseHelloWorldInClass();
            app.RunHelloWorld();
            
        }
    }
}

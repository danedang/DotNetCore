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
using Api.Demo.Tests.Service;
using Api.Demo.Tests.Service.Impl;

namespace Api.Demo.Tests
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
             
            // services.AddScoped<IGreetingService,FlexibleGreetingServiceImpl>();
            //此处必须添加类型
            // services.AddScoped<IGreetingService>(factory=>{
            //     return new FlexibleGreetingServiceImpl("moon");
            // });
            //此处必须添加类型
            services.AddSingleton<IGreetingService>(new FlexibleGreetingServiceImpl("Mars"));
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

            //下面两个方法输出相同，都UseMiddleware<HelloWorldMiddleware>
            app.UseHelloWorldMiddleware();
            app.UseHelloWorldInClass();

            app.UseHelloWorld();            
            app.RunHelloWorld();
        }
    }
}
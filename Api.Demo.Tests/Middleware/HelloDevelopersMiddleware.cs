using System.Threading.Tasks;
using Api.Demo.Tests.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Demo.Tests.Middleware
{
    public class HelloDevelopersMiddleware
    {
        private readonly RequestDelegate next;
        public HelloDevelopersMiddleware(RequestDelegate next){
            this.next = next;
        }

        public async Task Invoke(HttpContext context){
            var greetingService = context.RequestServices.GetService<IGreetingService>();
            var message = greetingService.Greet("Develop to");
            await context.Response.WriteAsync(message);
            await this.next(context);
        }

    }
}
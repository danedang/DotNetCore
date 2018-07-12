using System.Threading.Tasks;
using Api.Demo.Tests.Service;
using Microsoft.AspNetCore.Http;

namespace Api.Demo.Tests.Middleware
{
    public class HelloDevelopersMiddleware
    {
        private readonly RequestDelegate next;
        public HelloDevelopersMiddleware(RequestDelegate next){
            this.next = next;
        }

        public async Task Invoke(HttpContext context){
            var greetingService = (IGreetingService)context.RequestServices.GetService(typeof( IGreetingService));

            var message = greetingService.Greet("Develop to");
            await context.Response.WriteAsync(message);
            await this.next(context);
        }

    }
}
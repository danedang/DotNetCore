using System.Threading.Tasks;
using Api.Demo.Tests.Service;
using Microsoft.AspNetCore.Http;

namespace Api.Demo.Tests.Middleware
{
    public class HelloWorldMiddleware{
        private readonly RequestDelegate next;
        public HelloWorldMiddleware(RequestDelegate next){
            this.next = next;
        }

        public async Task Invoke(HttpContext context,IGreetingService service){
            var message = service.Greet(" user IGreetingService");
            await context.Response.WriteAsync(message);
            await this.next(context);
        }
    }
}
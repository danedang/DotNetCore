using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Api.Demo.Tests.Middleware
{
    public class HelloWorldMiddleware{
        private readonly RequestDelegate next;
        public HelloWorldMiddleware(RequestDelegate next){
            this.next = next;
        }

        public async Task Invoke(HttpContext context){
            await context.Response.WriteAsync("Hello world (by middleware)\n");
            await this.next(context);
        }
    }
}
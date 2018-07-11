using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Api.Demo.Tests.POCO;
namespace Api.Demo.Tests.Middleware
{
    public class GreetingMiddleware{
        private readonly RequestDelegate next;
        private readonly GreetingOptions options;
        public GreetingMiddleware(RequestDelegate next,GreetingOptions options){
            this.next = next;
            this.options = options;
        }

        public async Task Invoke(HttpContext context){
            var message = $"GreetingMiddleware.Invoke {options.GreetAt} {options.GreetTo}\n" ;
            await context.Response.WriteAsync(message);
            await this.next(context);
        } 
    }
}
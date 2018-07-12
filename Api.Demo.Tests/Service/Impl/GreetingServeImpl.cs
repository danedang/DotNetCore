namespace Api.Demo.Tests.Service.Impl
{
    public class GreetingServiceImpl : IGreetingService
    {
        public string Greet(string to)
        {
            return $"Hello {to}\n";
        }
    }
}
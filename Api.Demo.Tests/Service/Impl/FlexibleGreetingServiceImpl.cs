namespace Api.Demo.Tests.Service.Impl
{
    public class FlexibleGreetingServiceImpl : IGreetingService
    {
        private readonly string from ;
        public FlexibleGreetingServiceImpl(string from ){
            this.from = from;
        }
        public string Greet(string to)
        {
            return $"FlexibleGreetingService from:{from}  to:{to}\n";
        }
    }
}
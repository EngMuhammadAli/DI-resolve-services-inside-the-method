namespace DI_resolve_services_inside_the_method.Service
{
    public class MyService : IMyService
    {
        public string GetMessage()
        {
            return "Hello from MyService!";
        }
    }

}

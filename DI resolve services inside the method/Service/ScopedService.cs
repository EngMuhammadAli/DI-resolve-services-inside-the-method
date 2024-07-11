namespace DI_resolve_services_inside_the_method.Service
{
    public class ScopedService : IScopedService
    {
        public string GetScopedMessage()
        {
            return "Hello from ScopedService!";
        }
    }
}

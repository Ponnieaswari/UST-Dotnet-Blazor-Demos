namespace ServicesandStateManagementDemo.Services
{
    public class GreetingService
    {
        public string GetWelcomeMessage(string user)
        {
            return $"Hi {user}, Welcome to Services and State Management in Blazor!";
        }
    }
}

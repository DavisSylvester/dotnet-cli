namespace Titans.ProjectStarter.Services
{
    public abstract class BaseService
    {
        protected readonly HttpClient _httpClient;
        public BaseService(HttpClient client) {
        
            _httpClient = client;
        }
    }
}

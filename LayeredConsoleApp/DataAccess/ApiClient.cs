namespace LayeredConsoleApp.DataAccess
{
    internal static class ApiEndpoints
    {
        public const string Users = "https://fake-json-api.mock.beeceptor.com/users";
    }

    internal class ApiClient
    {
        // readonly: can only be assigned via declaration or within the constructor
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        // Task<what it returns when awaited>
        // HTTP requests should be async, waits for external process
        public async Task<string> GetUsersAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(ApiEndpoints.Users);
            response.EnsureSuccessStatusCode();
            return awiat;
        }
    }
}

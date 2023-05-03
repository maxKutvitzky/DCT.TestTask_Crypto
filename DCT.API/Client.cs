namespace DCT.API
{
    /// <summary>
    /// Singleton HttpClient wrapper
    /// </summary>
    internal sealed class Client
    {
        private Client() 
        {
            _httpClient = new HttpClient();
        }

        private readonly HttpClient _httpClient;
        private static Client _instance;
        
        /// <summary>
        /// Get instance of HttpClient wrapper
        /// </summary>
        public static Client Instance()
        {
            if (_instance == null)
            {
                _instance = new Client();
            }
            
            return _instance;
        }

        /// <summary>
        /// Send GET HTTP request 
        /// </summary>
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }
    }
}

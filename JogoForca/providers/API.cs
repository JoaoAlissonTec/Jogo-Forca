using JogoForca.interfaces;
using Newtonsoft.Json;

namespace JogoForca.providers
{
    public class API : IApiService
    {
        private HttpClient _client;

        public API()
        {
            _client = new HttpClient();
        }

        public T Get<T>(string? url) where T : class
        {
            HttpResponseMessage response = _client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode) {
                return null;
            }

            T json = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result)!;
            
            return json;
        }
    }
}

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PokemonApi.Infrastructure.Services
{
    public abstract class ApiService
    {
        private readonly HttpClient httpClient;

        protected ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<TResponse> Get<TResponse>(string endpoint, AuthenticationHeaderValue authentication = null)
        {
            httpClient.DefaultRequestHeaders.Authorization = authentication;

            using HttpResponseMessage responseMessage = await httpClient.GetAsync(endpoint);

            responseMessage.EnsureSuccessStatusCode();

            var response = await responseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TResponse>(response);
        }
    }
}

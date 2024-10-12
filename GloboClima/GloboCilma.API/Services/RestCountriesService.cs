using GloboCilma.API.Infrastructure;
using GloboCilma.API.Models;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GloboCilma.API.Services
{
    public class RestCountriesService : IRestCountriesService
    {
        private readonly IHttpClientFactory _httpFactory;

        public RestCountriesService(IHttpClientFactory httpClientFactory)
        {
            _httpFactory = httpClientFactory;
        }

        public async Task<List<CountryResponse>> GetCountryByFullNameAsync(string fullName)
        {
            var country = new Country();

            var client = _httpFactory.CreateClient("RestCountriesClient");
            var uri = "https://restcountries.com/v3.1/name/" + fullName;
            var response = await client.GetAsync(uri);
            
            if (response.IsSuccessStatusCode)
            {                
                string countryResp = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                                               
                return System.Text.Json.JsonSerializer.Deserialize<List<CountryResponse>>(countryResp, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                throw new RestCountriesException(response.StatusCode, "Error response from Rest Countries Api: " + response.ReasonPhrase);
            }
        }
    
    }
}

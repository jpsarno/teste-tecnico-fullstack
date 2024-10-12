using GloboCilma.API.Config;
using GloboCilma.API.Infrastructure;
using GloboCilma.API.Models;
using GloboCilma.API.Models.Enums;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GloboCilma.API.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly OpenWeather _openWeatherConfig;
        private readonly IHttpClientFactory _httpFactory;

        public OpenWeatherService(IOptions<OpenWeather> options, IHttpClientFactory httpFactory) 
        {
            _openWeatherConfig = options.Value;
            _httpFactory = httpFactory;
        }

        public async Task<List<WeatherForecast>> GetFiveDaysForecastAsync(string location, Unit unit = Unit.Metric)
        {
            string url = BuildOpenWeatherUrl("forecast", location, unit);
            var forecasts = new List<WeatherForecast>();

            var client = _httpFactory.CreateClient("OpenWeatherClient");
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {                
                var jsonOpts = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNameCaseInsensitive = true };
                var contentStream = await response.Content.ReadAsStreamAsync();
                var openWeatherResponse = await JsonSerializer.DeserializeAsync<OpenWeatherResponse>(contentStream, jsonOpts);
                foreach (var forecast in openWeatherResponse.Forecasts)
                {
                    forecasts.Add(new WeatherForecast
                    {
                        Date = new DateTime(forecast.Dt),
                        Temp = forecast.Temps.Temp,
                        FeelsLike = forecast.Temps.FeelsLike,
                        TempMin = forecast.Temps.TempMin,
                        TempMax = forecast.Temps.TempMax,
                    });
                }

                return forecasts;
            }
            else
            {
                throw new OpenWeatherException(response.StatusCode, "Error response from OpenWeatherApi: " + response.ReasonPhrase);
            }
        }

        private string BuildOpenWeatherUrl(string resource, string location, Unit unit)
        {
            return $"https://api.openweathermap.org/data/2.5/{resource}" +
                   $"?appid={_openWeatherConfig.ApiKey}" +
                   $"&q={location}" +
                   $"&units={unit}";
        }
    }
}

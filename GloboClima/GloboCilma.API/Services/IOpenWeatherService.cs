using GloboCilma.API.Models;
using GloboCilma.API.Models.Enums;

namespace GloboCilma.API.Services
{
    public interface IOpenWeatherService
    {
        Task<List<WeatherForecast>> GetFiveDaysForecastAsync(string location, Unit unit = Unit.Metric);
    }
}

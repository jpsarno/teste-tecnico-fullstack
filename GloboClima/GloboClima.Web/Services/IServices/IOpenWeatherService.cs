using GloboClima.Web.Models;

namespace GloboClima.Web.Services.IServices
{
    public interface IOpenWeatherService
    {
        Task<IEnumerable<OpenWeatherModel>> GetAll();
    }
}

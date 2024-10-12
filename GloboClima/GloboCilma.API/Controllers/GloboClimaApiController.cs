using GloboCilma.API.Infrastructure;
using GloboCilma.API.Models.Enums;
using GloboCilma.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GloboCilma.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GloboClimaApiController : ControllerBase
    {               
        private readonly IOpenWeatherService _weatherService;
        private readonly IRestCountriesService _countriesService;

        public GloboClimaApiController(IOpenWeatherService weatherService, IRestCountriesService countriesService)
        {            
            _weatherService = weatherService;
            _countriesService = countriesService;
        }

        /// <summary>
        /// Consultar informações do clima por nome da cidade
        /// </summary>
        /// <param name="location">Nome da Cidade</param>
        /// <returns>Json com informações dos últimos 5 dias</returns>
        [HttpGet("weather")]
        public async Task<IActionResult> GetWeatherInfo(string location, Unit unit = Unit.Metric)
        {
            if (string.IsNullOrEmpty(location))
                return BadRequest("location parameter is missing");
            try
            {
                var forecast = await _weatherService.GetFiveDaysForecastAsync(location, unit);
                return Ok(forecast);
            }
            catch (OpenWeatherException e)
            {
                if (e.StatusCode == HttpStatusCode.NotFound)
                    return BadRequest($"Location: \"{location}\" not found.");
                else
                    return StatusCode(500, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        /// <summary>
        /// Consultar informações de um país
        /// </summary>
        /// <param name="fullName">Nome completo do país</param>
        /// <returns>Json com as informações do país consultado</returns>
        [HttpGet("country")]
        public async Task<IActionResult> GetCountryInfo(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                return BadRequest("name parameter is missing");
            try 
            {
                var country = await _countriesService.GetCountryByFullNameAsync(fullName);
                return Ok(country);
            }
            catch (RestCountriesException e) 
            {
                if (e.StatusCode == HttpStatusCode.NotFound)
                    return BadRequest($"Country: \"{fullName}\" not found.");
                else
                    return StatusCode(500, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

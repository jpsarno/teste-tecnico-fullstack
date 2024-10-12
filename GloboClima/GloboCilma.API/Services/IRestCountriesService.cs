using GloboCilma.API.Models;

namespace GloboCilma.API.Services
{
    public interface IRestCountriesService
    {
        Task<List<CountryResponse>> GetCountryByFullNameAsync(string fullName);
    }
}

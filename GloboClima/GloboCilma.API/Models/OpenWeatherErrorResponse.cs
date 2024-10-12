using System.Text.Json.Serialization;

namespace GloboCilma.API.Models
{
    public class OpenWeatherErrorResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; }
    }
}

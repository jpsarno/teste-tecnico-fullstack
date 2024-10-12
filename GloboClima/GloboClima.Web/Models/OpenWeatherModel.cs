namespace GloboClima.Web.Models
{
    public class OpenWeatherModel
    {
        public List<Forecast> Forecasts { get; set; }
    }

    public class Forecast
    {
        public int Dt { get; set; }
        public Temps Temps { get; set; }
    }

    public class Temps 
    {
        public decimal Temp { get; set; }
        public decimal FeelsLike { get; set; }
        public decimal TempMin { get; set; }

        public decimal TempMax { get; set; }
    }
}

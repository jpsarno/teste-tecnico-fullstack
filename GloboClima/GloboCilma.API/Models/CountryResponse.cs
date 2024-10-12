using System.Text.Json.Serialization;

namespace GloboCilma.API.Models
{
    public class CountryResponse
    {

        public class Rootobject
        {
            public List<Class1> Property1 { get; set; }
        }

        public class Class1
        {
            [JsonPropertyName("name")]
            public Name name { get; set; }
            
            [JsonPropertyName("tkd")]
            public string[] tld { get; set; }

            [JsonPropertyName("cca2")]
            public string cca2 { get; set; }

            [JsonPropertyName("ccn3")]
            public string ccn3 { get; set; }

            [JsonPropertyName("cca3")]
            public string cca3 { get; set; }

            [JsonPropertyName("cioc")]
            public string cioc { get; set; }

            [JsonPropertyName("independent")]
            public bool independent { get; set; }

            [JsonPropertyName("status")]
            public string status { get; set; }

            [JsonPropertyName("unMember")]
            public bool unMember { get; set; }

            [JsonPropertyName("currencies")]
            public Dictionary<string, Currencies>? Currencies { get; set; }

            [JsonPropertyName("idd")]
            public Idd idd { get; set; }

            [JsonPropertyName("capital")]
            public string[] capital { get; set; }

            [JsonPropertyName("altSpellings")]
            public string[] altSpellings { get; set; }

            [JsonPropertyName("region")]
            public string region { get; set; }

            [JsonPropertyName("subregion")]
            public string subregion { get; set; }

            [JsonPropertyName("languages")]
            public Dictionary<string, string>? Languages { get; set; }

            [JsonPropertyName("translations")]
            public Dictionary<string, Translation> Translations { get; set; }

            [JsonPropertyName("latlng")]
            public float[] latlng { get; set; }

            [JsonPropertyName("landlocked")]
            public bool landlocked { get; set; }

            [JsonPropertyName("borders")]
            public string[] borders { get; set; }

            [JsonPropertyName("area")]
            public float area { get; set; }

            [JsonPropertyName("demonyms")]
            public Demonyms demonyms { get; set; }

            [JsonPropertyName("flag")]
            public string flag { get; set; }

            [JsonPropertyName("maps")]
            public Maps maps { get; set; }

            [JsonPropertyName("population")]
            public int population { get; set; }

            [JsonPropertyName("gini")]
            public Gini gini { get; set; }

            [JsonPropertyName("fifa")]
            public string fifa { get; set; }

            [JsonPropertyName("car")]
            public Car car { get; set; }

            [JsonPropertyName("timezones")]
            public string[] timezones { get; set; }

            [JsonPropertyName("continents")]
            public string[] continents { get; set; }

            [JsonPropertyName("flags")]
            public Flags flags { get; set; }

            [JsonPropertyName("coatOfArms")]
            public Coatofarms coatOfArms { get; set; }

            [JsonPropertyName("startOfWeek")]
            public string startOfWeek { get; set; }

            [JsonPropertyName("capitalInfo")]
            public Capitalinfo capitalInfo { get; set; }

            [JsonPropertyName("postalCode")]
            public Postalcode postalCode { get; set; }
        }

        public class Name
        {
            [JsonPropertyName("common")]
            public string common { get; set; }

            [JsonPropertyName("official")]
            public string official { get; set; }

            [JsonPropertyName("nativeName")]
            public Nativename nativeName { get; set; }
        }

        public class Nativename
        {
            [JsonPropertyName("por")]
            public Por por { get; set; }
        }

        public class Por
        {
            [JsonPropertyName("official")]
            public string official { get; set; }

            [JsonPropertyName("common")]
            public string common { get; set; }
        }

        public class Currencies
        {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("symbol")]
            public string symbol { get; set; }
        }        

        public class Idd
        {
            [JsonPropertyName("root")]
            public string root { get; set; }

            [JsonPropertyName("suffixes")]
            public string[] suffixes { get; set; }
        }

        public class Translation
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }
        public class TranslationLanguage
        {
            public Ara ara { get; set; }
            public Bre bre { get; set; }
            public Ces ces { get; set; }
            public Cym cym { get; set; }
            public Deu deu { get; set; }
            public Est est { get; set; }
            public Fin fin { get; set; }
            public Fra fra { get; set; }
            public Hrv hrv { get; set; }
            public Hun hun { get; set; }
            public Ita ita { get; set; }
            public Jpn jpn { get; set; }
            public Kor kor { get; set; }
            public Nld nld { get; set; }
            public Per per { get; set; }
            public Pol pol { get; set; }
            public Por1 por { get; set; }
            public Rus rus { get; set; }
            public Slk slk { get; set; }
            public Spa spa { get; set; }
            public Srp srp { get; set; }
            public Swe swe { get; set; }
            public Tur tur { get; set; }
            public Urd urd { get; set; }
            public Zho zho { get; set; }


            public class Ara
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Bre
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Ces
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Cym
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Deu
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Est
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Fin
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Fra
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Hrv
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Hun
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Ita
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Jpn
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Kor
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Nld
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Per
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Pol
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Por1
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Rus
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Slk
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Spa
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Srp
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Swe
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Tur
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Urd
            {
                public string official { get; set; }
                public string common { get; set; }
            }

            public class Zho
            {
                public string official { get; set; }
                public string common { get; set; }
            }
        }
        public class Demonyms
        {
            [JsonPropertyName("eng")]
            public Eng eng { get; set; }

            [JsonPropertyName("fra")]
            public Fra1 fra { get; set; }
        }

        public class Eng
        {
            [JsonPropertyName("f")]
            public string f { get; set; }

            [JsonPropertyName("m")]
            public string m { get; set; }
        }

        public class Fra1
        {
            [JsonPropertyName("f")]
            public string f { get; set; }

            [JsonPropertyName("m")]
            public string m { get; set; }
        }

        public class Maps
        {
            [JsonPropertyName("googleMaps")]
            public string googleMaps { get; set; }

            [JsonPropertyName("openStreetMaps")]
            public string openStreetMaps { get; set; }
        }

        public class Gini
        {
            [JsonPropertyName("gini")]
            public float _2019 { get; set; }
        }

        public class Car
        {
            [JsonPropertyName("signs")]
            public string[] signs { get; set; }

            [JsonPropertyName("side")]
            public string side { get; set; }
        }

        public class Flags
        {
            [JsonPropertyName("png")]
            public string png { get; set; }

            [JsonPropertyName("svg")]
            public string svg { get; set; }

            [JsonPropertyName("alt")]
            public string alt { get; set; }
        }

        public class Coatofarms
        {
            [JsonPropertyName("png")]
            public string png { get; set; }

            [JsonPropertyName("svg")]
            public string svg { get; set; }
        }

        public class Capitalinfo
        {
            [JsonPropertyName("latlng")]
            public float[] latlng { get; set; }
        }

        public class Postalcode
        {
            [JsonPropertyName("format")]
            public string format { get; set; }

            [JsonPropertyName("regex")]
            public string regex { get; set; }
        }

    }
}

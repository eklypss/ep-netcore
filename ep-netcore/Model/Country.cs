using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Country
    {
        [JsonProperty("iso3166_2")]
        public string Iso_____ { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iso3166_3")]
        public string OtherIso_____ { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
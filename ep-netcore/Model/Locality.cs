using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Locality
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("localityType")]
        public string LocalityType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class AwardType
    {
        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
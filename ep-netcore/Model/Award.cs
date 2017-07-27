using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Award
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("awardType")]
        public AwardType AwardType { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
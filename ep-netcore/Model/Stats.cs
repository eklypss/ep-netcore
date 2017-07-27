using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Stats
    {
        [JsonProperty("jerseyNumber")]
        public double JerseyNumber { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("sort")]
        public double Sort { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("visibleInRoster")]
        public string VisibleInRoster { get; set; }
    }
}
using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Data
    {
        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("PIM")]
        public double? PIM { get; set; }

        [JsonProperty("G")]
        public double? G { get; set; }

        [JsonProperty("A")]
        public double? A { get; set; }

        [JsonProperty("GP")]
        public double? GP { get; set; }

        [JsonProperty("PPG")]
        public double? PPG { get; set; }

        [JsonProperty("PM")]
        public double? PM { get; set; }

        [JsonProperty("TP")]
        public double? TP { get; set; }

        [JsonProperty("GAA")]
        public double? GAA { get; set; }

        [JsonProperty("SVP")]
        public double? SVP { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("jerseyNumber")]
        public double? JerseyNumber { get; set; }

        [JsonProperty("playerPosition")]
        public string PlayerPosition { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("playerRole")]
        public string PlayerRole { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("sort")]
        public double Sort { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("visibleInRoster")]
        public string VisibleInRoster { get; set; }
    }
}
using Newtonsoft.Json;

namespace epnetcore.Model.Teams
{
    public class TeamStats
    {
        [JsonProperty("TP")]
        public double? TP { get; set; }

        [JsonProperty("L")]
        public double? L { get; set; }

        [JsonProperty("GF")]
        public double? GF { get; set; }

        [JsonProperty("GA")]
        public double? GA { get; set; }

        [JsonProperty("GP")]
        public double? GP { get; set; }

        [JsonProperty("OTW")]
        public double? OTW { get; set; }

        [JsonProperty("OTL")]
        public double? OTL { get; set; }

        [JsonProperty("T")]
        public double? T { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("autoCreated")]
        public string AutoCreated { get; set; }

        [JsonProperty("W")]
        public double? W { get; set; }

        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("position")]
        public double? Position { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("postseason")]
        public string Postseason { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
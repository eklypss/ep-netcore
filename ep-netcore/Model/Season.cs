using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Season
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("endYear")]
        public double EndYear { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("seasonTypeStart")]
        public string SeasonTypeStart { get; set; }

        [JsonProperty("seasonTypeEnd")]
        public string SeasonTypeEnd { get; set; }

        [JsonProperty("startYear")]
        public double StartYear { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
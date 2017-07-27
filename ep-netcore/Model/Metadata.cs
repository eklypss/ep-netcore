using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Metadata
    {
        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("maxScore")]
        public double MaxScore { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("maxRelevance")]
        public double MaxRelevance { get; set; }

        [JsonProperty("offset")]
        public double Offset { get; set; }

        [JsonProperty("totalCount")]
        public double TotalCount { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace epnetcore.Model.PlayerStats
{
    public class StatsResponse
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace epnetcore.Model.Leagues
{
    internal class LeagueSearchResponse
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("data")]
        public List<LeagueData> Data { get; set; }
    }
}

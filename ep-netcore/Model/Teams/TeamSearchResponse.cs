using System.Collections.Generic;
using Newtonsoft.Json;

namespace epnetcore.Model.Teams
{
    public class TeamSearchResponse
    {
        [JsonProperty("data")]
        public List<TeamData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
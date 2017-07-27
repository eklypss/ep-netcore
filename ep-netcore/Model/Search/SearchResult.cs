using System.Collections.Generic;
using Newtonsoft.Json;

namespace epnetcore.Model.Search
{
    public class SearchResult
    {
        [JsonProperty("data")]
        public List<Data> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
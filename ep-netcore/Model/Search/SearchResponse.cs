using Newtonsoft.Json;

namespace epnetcore.Model.Search
{
    public class SearchResponse
    {
        [JsonProperty("players")]
        public SearchResult Players { get; set; }
    }
}
using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class ClubOfOrigin
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
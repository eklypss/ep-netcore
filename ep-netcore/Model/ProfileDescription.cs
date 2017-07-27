using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class ProfileDescription
    {
        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
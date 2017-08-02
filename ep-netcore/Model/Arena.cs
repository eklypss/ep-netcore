using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Arena
    {
        [JsonProperty("information")]
        public string Information { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("capacity")]
        public double? Capacity { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locality")]
        public Locality Locality { get; set; }

        [JsonProperty("yearOfConstruction")]
        public double? YearOfConstruction { get; set; }
    }
}
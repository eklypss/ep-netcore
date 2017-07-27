using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class League
    {
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("hideParentLeagueName")]
        public string HideParentLeagueName { get; set; }

        [JsonProperty("hasChildLeagues")]
        public string HasChildLeagues { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty("playerLevel")]
        public string PlayerLevel { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("searchable")]
        public string Searchable { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        [JsonProperty("virtual")]
        public string Virtual { get; set; }
    }
}
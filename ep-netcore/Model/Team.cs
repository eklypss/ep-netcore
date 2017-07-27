using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Team
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("searchable")]
        public string Searchable { get; set; }

        [JsonProperty("editorialNotes")]
        public string EditorialNotes { get; set; }

        [JsonProperty("colors")]
        public string Colors { get; set; }

        [JsonProperty("foundedYear")]
        public double FoundedYear { get; set; }

        [JsonProperty("inactive")]
        public string Inactive { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        [JsonProperty("teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
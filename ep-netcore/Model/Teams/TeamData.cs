using Newtonsoft.Json;

namespace epnetcore.Model.Teams
{
    public class TeamData
    {
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("editorialNotes")]
        public string EditorialNotes { get; set; }

        [JsonProperty("colors")]
        public string Colors { get; set; }

        [JsonProperty("arena")]
        public Arena Arena { get; set; }

        [JsonProperty("secondaryArena")]
        public Arena SecondaryArena { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("foundedYear")]
        public double? FoundedYear { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("latestTeamStats")]
        public TeamStats LatestTeamStats { get; set; }

        [JsonProperty("inactive")]
        public string Inactive { get; set; }

        [JsonProperty("locality")]
        public Locality Locality { get; set; }

        [JsonProperty("teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty("searchable")]
        public string Searchable { get; set; }

        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}
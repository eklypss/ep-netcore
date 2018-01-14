using System;
using Newtonsoft.Json;

namespace epnetcore.Model.Leagues
{
    internal class LeagueData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("playerLevel")]
        public string PlayerLevel { get; set; }

        [JsonProperty("parentLeague")]
        public League ParentLeague { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("hideParentLeagueName")]
        public string HideParentLeagueName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasChildLeagues")]
        public string HasChildLeagues { get; set; }

        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        [JsonProperty("teamClass")]
        public string TeamClass { get; set; }

        [JsonProperty("searchable")]
        public string Searchable { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }
}

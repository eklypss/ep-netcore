using Newtonsoft.Json;

namespace epnetcore.Model
{
    public class Player
    {
        [JsonProperty("imageByline")]
        public string ImageByline { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("playerPosition")]
        public string PlayerPosition { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("playerGameStatus")]
        public string PlayerGameStatus { get; set; }

        [JsonProperty("shoots")]
        public string Shoots { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("playerStatus")]
        public string PlayerStatus { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("yearOfBirth")]
        public double YearOfBirth { get; set; }
    }
}
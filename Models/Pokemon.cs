using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BlazorPokeApi.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonPropertyName("height")]
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonPropertyName("weight")]
        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("sprites")]
        [JsonProperty("sprites")]
        public Sprites? Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("other")]
        [JsonProperty("other")]
        public OtherSprites? Other { get; set; }
    }

    public class OtherSprites
    {
        [JsonPropertyName("official-artwork")]
        [JsonProperty("official-artwork")]
        public OfficialArtwork? OfficialArtwork { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonPropertyName("front_default")]
        [JsonProperty("front_default")]
        public string? FrontDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        [JsonProperty("front_shiny")]
        public string? FrontShiny { get; set; }
    }
}

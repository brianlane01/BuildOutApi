using System.Text.Json.Serialization;
using Newtonsoft.Json;
    public class Planet
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("rotation_period")]
        [JsonPropertyName("rotation_period")]
        public string RotationPeriod { get; set; }

        [JsonProperty("orbital_period")]
        [JsonPropertyName("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("diameter")]
        [JsonPropertyName("diameter")]
        public string Diameter { get; set; }

        [JsonProperty("climate")]
        [JsonPropertyName("climate")]
        public string Climate { get; set; }

        [JsonProperty("gravity")]
        [JsonPropertyName("gravity")]
        public string Gravity { get; set; }

        [JsonProperty("terrain")]
        [JsonPropertyName("terrain")]
        public string Terrain { get; set; }

        [JsonProperty("surface_water")]
        [JsonPropertyName("surface_water")]
        public string SurfaceWater { get; set; }

        [JsonProperty("population")]
        [JsonPropertyName("population")]
        public string Population { get; set; }

        [JsonProperty("residents")]
        [JsonPropertyName("residents")]
        public List<object> Residents { get; set; }

        [JsonProperty("films")]
        [JsonPropertyName("films")]
        public List<string> Films { get; set; }

        [JsonProperty("created")]
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonProperty("edited")]
        [JsonPropertyName("edited")]
        public DateTime Edited { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

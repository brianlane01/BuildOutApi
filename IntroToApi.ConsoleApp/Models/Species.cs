using System.Text.Json.Serialization;
using Newtonsoft.Json;
    public class Species
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonProperty("designation")]
        [JsonPropertyName("designation")]
        public string Designation { get; set; }

        [JsonProperty("average_height")]
        [JsonPropertyName("average_height")]
        public string AverageHeight { get; set; }

        [JsonProperty("skin_colors")]
        [JsonPropertyName("skin_colors")]
        public string SkinColors { get; set; }

        [JsonProperty("hair_colors")]
        [JsonPropertyName("hair_colors")]
        public string HairColors { get; set; }

        [JsonProperty("eye_colors")]
        [JsonPropertyName("eye_colors")]
        public string EyeColors { get; set; }

        [JsonProperty("average_lifespan")]
        [JsonPropertyName("average_lifespan")]
        public string AverageLifespan { get; set; }

        [JsonProperty("homeworld")]
        [JsonPropertyName("homeworld")]
        public string Homeworld { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonProperty("people")]
        [JsonPropertyName("people")]
        public List<string> People { get; set; }

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

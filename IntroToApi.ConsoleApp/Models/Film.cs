using System.Text.Json.Serialization;
using Newtonsoft.Json;
    public class Film
    {
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("episode_id")]
        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }

        [JsonProperty("opening_crawl")]
        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonProperty("director")]
        [JsonPropertyName("director")]
        public string Director { get; set; }

        [JsonProperty("producer")]
        [JsonPropertyName("producer")]
        public string Producer { get; set; }

        [JsonProperty("release_date")]
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("characters")]
        [JsonPropertyName("characters")]
        public List<string> Characters { get; set; }

        [JsonProperty("planets")]
        [JsonPropertyName("planets")]
        public List<string> Planets { get; set; }

        [JsonProperty("starships")]
        [JsonPropertyName("starships")]
        public List<string> Starships { get; set; }

        [JsonProperty("vehicles")]
        [JsonPropertyName("vehicles")]
        public List<string> Vehicles { get; set; }

        [JsonProperty("species")]
        [JsonPropertyName("species")]
        public List<string> Species { get; set; }

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

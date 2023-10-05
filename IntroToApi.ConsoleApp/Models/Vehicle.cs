using System.Text.Json.Serialization;
using Newtonsoft.Json;

    public class Vehicle
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("model")]
        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonProperty("manufacturer")]
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("cost_in_credits")]
        [JsonPropertyName("cost_in_credits")]
        public string CostInCredits { get; set; }

        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public string Length { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        [JsonPropertyName("max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }

        [JsonProperty("crew")]
        [JsonPropertyName("crew")]
        public string Crew { get; set; }

        [JsonProperty("passengers")]
        [JsonPropertyName("passengers")]
        public string Passengers { get; set; }

        [JsonProperty("cargo_capacity")]
        [JsonPropertyName("cargo_capacity")]
        public string CargoCapacity { get; set; }

        [JsonProperty("consumables")]
        [JsonPropertyName("consumables")]
        public string Consumables { get; set; }

        [JsonProperty("vehicle_class")]
        [JsonPropertyName("vehicle_class")]
        public string VehicleClass { get; set; }

        [JsonProperty("pilots")]
        [JsonPropertyName("pilots")]
        public List<object> Pilots { get; set; }

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
using System.Text.Json.Serialization;
using Newtonsoft.Json;
public class Person
{
    //JSon property needs an additional package to work
    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonProperty("height")]
    [JsonPropertyName("height")]
    public string Height { get; set; }

    [JsonProperty("mass")]
    [JsonPropertyName("mass")]
    public string Mass { get; set; }

    [JsonProperty("hair_color")]
    [JsonPropertyName("hair_color")]
    public string HairColor { get; set; }

    [JsonProperty("skin_color")]
    [JsonPropertyName("skin_color")]
    public string SkinColor { get; set; }

    [JsonProperty("eye_color")]
    [JsonPropertyName("eye_color")]
    public string EyeColor { get; set; }

    [JsonProperty("birth_year")]
    [JsonPropertyName("birth_year")]
    public string BirthYear { get; set; }

    [JsonProperty("gender")]
    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonProperty("homeworld")]
    [JsonPropertyName("homeworld")]
    public string Planet { get; set; }

    [JsonProperty("films")]
    [JsonPropertyName("films")]
    public List<string> Films { get; set; }

    [JsonProperty("species")]
    [JsonPropertyName("species")]
    public List<object> Species { get; set; }

    [JsonProperty("vehicles")]
    [JsonPropertyName("vehicles")]
    public List<string> Vehicles { get; set; }

    [JsonProperty("starships")]
    [JsonPropertyName("starships")]
    public List<string> Starships { get; set; }

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

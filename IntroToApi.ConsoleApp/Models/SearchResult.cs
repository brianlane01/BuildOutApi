using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class SearchResult<T>
{
    [JsonProperty("count")]
    public int Count { get; set; }

    [JsonProperty("results")]
    public List<T> Results { get; set; }

}

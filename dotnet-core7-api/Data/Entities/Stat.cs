using Newtonsoft.Json;

namespace DotnetCore7Api.Data;

public class Stat
{
    public int Id { get; set; }
    [JsonProperty("level")]
    public float Level { get; set; }
    [JsonProperty("population")]
    public float Population { get; set; }
}
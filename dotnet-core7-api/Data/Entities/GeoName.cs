using Newtonsoft.Json;

namespace DotnetCore7Api.Data;

public class GeoName
{
    public int Id { get; set; }
    [JsonProperty("cl")]
    public string? Cl { get; set; }
    [JsonProperty("code")]
    public string? Code { get; set; }
    [JsonProperty("parent")]
    public float Parent { get; set; }
}
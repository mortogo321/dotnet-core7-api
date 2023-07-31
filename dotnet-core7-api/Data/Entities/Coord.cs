using Newtonsoft.Json;

namespace DotnetCore7Api.Data;

public class Coord
{
    public int Id { get; set; }
    [JsonProperty("lon")]
    public string? Lon { get; set; }
    [JsonProperty("lat")]
    public string? Lat { get; set; }
}
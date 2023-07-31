using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DotnetCore7Api.Data;

public class Station
{
    [Key]
    public int StationId { get; set; }
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("dist")]
    public int Dist { get; set; }
    [JsonProperty("kf")]
    public int Kf { get; set; }
}
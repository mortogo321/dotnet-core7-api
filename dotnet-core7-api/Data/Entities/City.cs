using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DotnetCore7Api.Data;

public class City
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid CityId { get; set; }
    [JsonProperty("id")]
    public long Id { get; set; }
    [JsonProperty("coord")]
    public Coord? Coord { get; set; }
    [JsonProperty("country")]
    public string? Country { get; set; }
    [JsonProperty("geoname")]
    public GeoName? GeoName { get; set; }
    [JsonProperty("langs")]
    public List<Dictionary<string, string>> Langs { get; set; } = new();
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("stat")]
    public Stat? Stat { get; set; }
    [JsonProperty("stations")]
    public List<Station> Stations { get; set; } = null!;
    [JsonProperty("zoom")]
    public float Zoom { get; set; }
}
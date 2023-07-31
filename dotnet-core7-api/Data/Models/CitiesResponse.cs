namespace DotnetCore7Api.Data.Models;

public class CitiesResponse
{
    public int TotalRecords { get; set; }
    public int Take { get; set; }
    public int Skip { get; set; }
    public dynamic? Results { get; set; }
}
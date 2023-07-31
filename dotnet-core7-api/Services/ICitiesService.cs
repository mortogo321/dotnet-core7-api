using DotnetCore7Api.Data;
using DotnetCore7Api.Data.Models;

namespace DotnetCore7Api.Services;

public interface ICitiesService
{
    Task<CitiesResponse> GetCities(string? keyword, int take, int skip);
}
using DotnetCore7Api.Data;
using DotnetCore7Api.Data.Contexts;
using DotnetCore7Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore7Api.Services;

public class CitiesService : ICitiesService
{
    private readonly CitiesContext _citiesContext;

    public CitiesService(CitiesContext citiesContext)
    {
        _citiesContext = citiesContext;
    }

    public async Task<CitiesResponse> GetCities(string? keyword, int take, int skip)
    {
        var cities = from s in _citiesContext.Cities!
                .Include(c => c.Stat)
            select s;

        if (!string.IsNullOrEmpty(keyword))
        {
            cities = cities.Where(c => !string.IsNullOrEmpty(c.Name) && c.Name.Contains(keyword));
        }

        var count = await cities.CountAsync();
        var results = await cities.OrderBy(c => c.Name)
            .Skip(skip)
            .Take(take)
            .ToListAsync();
        var response = new CitiesResponse()
        {
            TotalRecords = count,
            Take = take,
            Skip = skip,
            Results = results,
        };

        return response;
    }
}
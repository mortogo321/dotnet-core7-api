using DotnetCore7Api.Data;
using DotnetCore7Api.Data.Contexts;
using DotnetCore7Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DotnetCore7Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : ControllerBase
{
    private readonly ICitiesService _citiesService;

    public CitiesController(ICitiesService citiesService)
    {
        _citiesService = citiesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<City>>> Get(string? keyword, int take = 10, int skip = 0)
    {
        var result = await _citiesService.GetCities(keyword, take, skip);

        return Ok(result);
    }
}
using DotnetCore7Api.Data.Contexts;
using Newtonsoft.Json;

namespace DotnetCore7Api.Data.Seeder;

public static class Seeder
{
    public static void Seed(this CitiesContext citiesContext)
    {
        if (citiesContext.Cities == null || citiesContext.Cities.Any()) return;

        try
        {
            var fileData = File.ReadAllText(@"./Data/Seeder/current.city.list.json");
            var cities = JsonConvert.DeserializeObject<List<City>>(fileData);

            if (cities == null) return;
            
            citiesContext.AddRange(cities);
            citiesContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
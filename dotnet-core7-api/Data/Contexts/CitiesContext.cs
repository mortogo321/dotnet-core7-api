using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DotnetCore7Api.Data.Contexts;

public class CitiesContext : DbContext
{
    public CitiesContext(DbContextOptions<CitiesContext> options) : base(options)
    {
    }

    public DbSet<City>? Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var options = new JsonSerializerOptions(JsonSerializerDefaults.General);
        modelBuilder
            .Entity<City>()
            .Property(x => x.Langs)
            .HasColumnName("Langs")
            .HasConversion(
                v => JsonSerializer.Serialize(v, options),
                s => JsonSerializer.Deserialize<List<Dictionary<string, string>>>(s, options)!,
                ValueComparer.CreateDefault(typeof(List<Dictionary<string, string>>), true)
            );
    }
}
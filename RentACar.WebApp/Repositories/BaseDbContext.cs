using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions<BaseDbContext> opt) : base(opt)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    
    
    public DbSet<Car> Cars { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    
}
using Microsoft.EntityFrameworkCore;
using RentACar.WebApp.Repositories;
using RentACar.WebApp.Repositories.Abstract;
using RentACar.WebApp.Repositories.Concrete;

namespace RentACar.WebApp.Extensions;

public static class DataAccessDependencies
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("SqlConnection"));
        });
        services.AddScoped<ICarRepository,CarRepository>();
        
        services.AddScoped<ITransmissionRepository, TransmissionRepository>();
        
        services.AddScoped<IColorRepository, ColorRepository>();
        
        services.AddScoped<IFuelRepository, FuelRepository>();
        
        return services;
        
    }
    
}
using RentACar.WebApp.Services.Abstract;
using RentACar.WebApp.Services.Concrete;

namespace RentACar.WebApp.Services;

public static class BusinessExtensions
{

    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {

        services.AddScoped<ICarService, CarService>();
        return services;
    }
}
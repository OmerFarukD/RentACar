using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Fuels;

public sealed record FuelAddRequestDto(string Name)
{
    public static Fuel ConvertToEntity(FuelAddRequestDto dto)
    {
        return new Fuel()
        {
            Name = dto.Name
        };
    }
}
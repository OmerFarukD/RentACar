using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Fuels;

public sealed record FuelUpdateRequestDto(int Id, string Name)
{
    public static Fuel ConvertToEntity(FuelUpdateRequestDto dto)
    {
        return new Fuel()
        {
            Id = dto.Id,
            Name =dto.Name
        };
    }
}
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Responses;

public sealed record FuelResponseDto(int Id, string Name)
{
    public static implicit operator FuelResponseDto(Fuel fuel)
    {
        return new FuelResponseDto(fuel.Id, fuel.Name);
    }
}
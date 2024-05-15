using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Colors;

public sealed record ColorAddRequestDto(string Name)
{
    public static Color ConvertToEntity(ColorAddRequestDto dto)
    {
        return new Color()
        {
            Name = dto.Name
        };
    }
}
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Colors;

public record ColorUpdateRequestDto(int Id, string Name)
{
    public static Color ConvertToEntity(ColorUpdateRequestDto dto)
    {
        return new Color()
        {
            Id = dto.Id,
            Name = dto.Name
        };
    }
}
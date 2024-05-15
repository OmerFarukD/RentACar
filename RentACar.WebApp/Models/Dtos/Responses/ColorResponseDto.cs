using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Responses;

public sealed record ColorResponseDto(int Id, string Name)
{
    public static implicit operator ColorResponseDto(Color color)
    {
        return new ColorResponseDto(color.Id, color.Name);
    }
    
}
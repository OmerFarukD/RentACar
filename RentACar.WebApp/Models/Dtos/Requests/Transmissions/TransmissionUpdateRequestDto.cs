using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Transmissions;

public sealed record TransmissionUpdateRequestDto(int Id, string Name)
{
    public static Transmission ConvertToEntity(TransmissionUpdateRequestDto dto)
    {
        return new Transmission()
        {
            Id = dto.Id,
            Name = dto.Name
        };
    }
}
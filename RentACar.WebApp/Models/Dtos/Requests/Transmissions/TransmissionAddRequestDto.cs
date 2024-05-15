using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Requests.Transmissions;

public sealed record TransmissionAddRequestDto(string Name)
{
    public static Transmission ConvertToEntity(TransmissionAddRequestDto dto) =>
        new Transmission()
        {
            Name = dto.Name
        };
}
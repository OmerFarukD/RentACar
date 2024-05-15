using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Models.Dtos.Responses;

public sealed record TransmissionResponseDto(int Id, string Name)
{
    public static implicit operator TransmissionResponseDto(Transmission transmission)
    {
        return new TransmissionResponseDto(
            transmission.Id, transmission.Name);
    }
}
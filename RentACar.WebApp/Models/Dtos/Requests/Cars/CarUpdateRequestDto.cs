using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Models.Entities.Enums;
namespace RentACar.WebApp.Models.Dtos.Requests.Cars;

public sealed record CarUpdateRequestDto(
    Guid Id,
    int ColorId,
    int FuelId,
    int TransmissionId,
    CarState CarState,
    int KiloMeter,
    short ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    decimal DailyPrice,
    string ImageUrl
)
{
    public static Car ConvertToEntity(CarUpdateRequestDto dto)
    {
        return new Car()
        {
            Id = dto.Id,
            ColorId = dto.ColorId,
            FuelId = dto.FuelId,
            TransmissionId = dto.TransmissionId,
            CarState = dto.CarState,
            KiloMeter = dto.KiloMeter,
            ModelYear = dto.ModelYear,
            Plate = dto.Plate,
            BrandName = dto.BrandName,
            DailyPrice = dto.DailyPrice,
            ModelName = dto.ModelName,
            ImageUrl = dto.ImageUrl
        };
    }
}
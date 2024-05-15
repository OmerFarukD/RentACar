using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Models.Entities.Enums;

namespace RentACar.WebApp.Models.Dtos.Responses;

public sealed record CarResponseDto(
    Guid Id,
    string ColorName,
    string FuelName,
    string TransmissionName,
    CarState CarState,
    int? Kilometer,
    short? ModelYear,
    string Plate,
    string BrandName,
    string ModelName,
    decimal? DailyPrice,
    string ImageUrl
)
{
    public static implicit operator CarResponseDto(Car car)
    {
        return new CarResponseDto(
            Id:car.Id,
            ColorName: car.Color.Name,
            FuelName: car.Fuel.Name,
            TransmissionName: car.Transmission.Name,
            CarState: car.CarState,
            Kilometer: car.KiloMeter,
            ModelYear: car.ModelYear,
            Plate: car.Plate,
            BrandName: car.BrandName,
            ModelName: car.ModelName,
            DailyPrice: car.DailyPrice,
            ImageUrl: car.ImageUrl
        );
    }
}
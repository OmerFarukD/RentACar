using RentACar.WebApp.Models.Entities.Enums;

namespace RentACar.WebApp.Models.ViewModels.Cars;

public sealed record CarAddViewModel(
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
    IFormFile Image
    
);
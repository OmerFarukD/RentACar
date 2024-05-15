using RentACar.WebApp.Models.Dtos.Requests.Cars;
using RentACar.WebApp.Models.Dtos.Responses;
using RentACar.WebApp.Models.Entities.Enums;

namespace RentACar.WebApp.Services.Abstract;

public interface ICarService
{
    List<CarResponseDto> GetAll();
    List<CarResponseDto> GetAllByCategoryId(int categoryId);
    List<CarResponseDto> GetAllByFuelId(int fuelId);
    List<CarResponseDto> GetAllByCarState(CarState carState);
    List<CarResponseDto> GetAllByKilometerRange(int min, int max);
    List<CarResponseDto> GetAllModelYear(short min ,short max);
    List<CarResponseDto> GetAllDailyPrice(decimal min , decimal max);
    CarResponseDto GetById(Guid id);
    CarResponseDto Add(CarAddRequestDto dto);
    CarResponseDto Update(CarUpdateRequestDto dto);
    CarResponseDto Delete(Guid id);
    


}
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using RentACar.WebApp.Models.Dtos.Requests.Cars;
using RentACar.WebApp.Models.Dtos.Responses;
using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Models.Entities.Enums;
using RentACar.WebApp.Repositories.Abstract;
using RentACar.WebApp.Services.Abstract;

namespace RentACar.WebApp.Services.Concrete;

public sealed class CarService : ICarService
{
    private readonly ICarRepository _repository;
    private readonly IMapper _mapper;

    public CarService(ICarRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public List<CarResponseDto> GetAll()
    {
        List<CarResponseDto> cars = _repository.GetAll(include: c =>
            c.Include(m => m.Color)
                .Include(b=>b.Fuel)
                .Include(m=>m.Transmission)
        ).Select(x=> (CarResponseDto)x).ToList();

        return cars;

    }

    public List<CarResponseDto> GetAllByCategoryId(int categoryId)
    {
        /*List<CarResponseDto> cars = _repository.GetAll(predicate:x=>x.== ,include: c =>
            c.Include(m => m.Color)
                .Include(b=>b.Fuel)
                .Include(m=>m.Transmission)
        ).Select(x=> (CarResponseDto)x).ToList();*/

        throw new NotImplementedException();
    }

    public List<CarResponseDto> GetAllByFuelId(int fuelId)
    {
        List<Car> cars = _repository.GetAll(
            predicate: x => x.FuelId.Equals(fuelId),
            include: c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
        );

        List<CarResponseDto> response = cars.Select(x => (CarResponseDto)x).ToList();
        return response;

    }

    public List<CarResponseDto> GetAllByCarState(CarState carState)
    {
        List<Car> cars = _repository.GetAll(
            predicate: x => x.CarState.Equals(carState),
            include: c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
        );
        List<CarResponseDto> response = cars.Select(x => (CarResponseDto)x).ToList();
        return response;
        
    }

    public List<CarResponseDto> GetAllByKilometerRange(int min, int max)
    {
        List<Car> cars = _repository.GetAll(
            predicate: x => x.KiloMeter>=min && x.KiloMeter<=max,
            include: c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
        );
        List<CarResponseDto> response = cars.Select(x => (CarResponseDto)x).ToList();
        return response;
    }

    public List<CarResponseDto> GetAllModelYear(short min, short max)
    {
        List<Car> cars = _repository.GetAll(
            predicate: x => x.ModelYear>=min && x.ModelYear<=max,
            include: c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
        );
        List<CarResponseDto> response = cars.Select(x => (CarResponseDto)x).ToList();
        return response;
    }

    public List<CarResponseDto> GetAllDailyPrice(decimal min, decimal max)
    {
        List<Car> cars = _repository.GetAll(
            predicate: x => x.DailyPrice>=min && x.DailyPrice<=max,
            include: c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
        );
        List<CarResponseDto> response = cars.Select(x => (CarResponseDto)x).ToList();
        return response;
    }

    public CarResponseDto GetById(Guid id)
    {
        var response = _repository.Get(
            predicate: x => x.Id == id,
            include:  c =>
                c.Include(m => m.Color)
                    .Include(b => b.Fuel)
                    .Include(m => m.Transmission)
            );
        
        CarResponseDto dto = response;
        return dto;
    }

    public CarResponseDto Add(CarAddRequestDto dto)
    {
        Car car = _mapper.Map<Car>(dto);
        car.Id = new Guid();
        
       Car addedCar = _repository.Add(car);

       return addedCar;

    }

    public CarResponseDto Update(CarUpdateRequestDto dto)
    {
        Car car = CarUpdateRequestDto.ConvertToEntity(dto);

        Car updatedCar = _repository.Update(car);

        return updatedCar;
    }

    public CarResponseDto Delete(Guid id)
    {
        var car = _repository.Get(x => x.Id == id);
        Car deletedCar = _repository.Delete(car);
        return deletedCar;
    }
}
using AutoMapper;
using RentACar.WebApp.Models.Dtos.Requests.Cars;
using RentACar.WebApp.Models.Dtos.Responses;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Services.Profiles;

public class AutoMapperProfiles : Profile
{

    public AutoMapperProfiles()
    {
        CreateMap<CarAddRequestDto, Car>().ReverseMap();
        CreateMap<Car, CarResponseDto>().ReverseMap();
        CreateMap<CarUpdateRequestDto, Car>().ReverseMap();

    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using RentACar.WebApp.Models.Dtos.Requests.Cars;
using RentACar.WebApp.Models.Dtos.Responses;
using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Models.ViewModels.Cars;
using RentACar.WebApp.Services.Abstract;

namespace RentACar.WebApp.Controllers;

public class CarsController : Controller
{
    private readonly ICarService _carService;
    private readonly IFileProvider _fileProvider;

    public CarsController(ICarService carService, IFileProvider fileProvider)
    {
        _carService = carService;
        _fileProvider = fileProvider;
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public  IActionResult Add(CarAddViewModel viewModel)
    {
        var root = _fileProvider.GetDirectoryContents("wwwroot");
        var images = root.First(x => x.Name == "images");

        var path = Path.Combine(images.PhysicalPath,viewModel.Image.FileName);

        using var stream = new FileStream(path, FileMode.Create);
         
        viewModel.Image.CopyTo(stream);

        CarAddRequestDto dto = new(
            Plate: viewModel.Plate,
            BrandName: viewModel.BrandName,
            DailyPrice: viewModel.DailyPrice,
            ModelName: viewModel.ModelName,
            ImageUrl: viewModel.Image.FileName,
            CarState: viewModel.CarState,
            KiloMeter: viewModel.KiloMeter,
            ModelYear: viewModel.ModelYear,
            ColorId: viewModel.ColorId,
            TransmissionId: viewModel.TransmissionId,
            FuelId: viewModel.FuelId
            );
           _carService.Add(dto);

        return RedirectToAction("Index", "Cars");
    }

    // GET
    [HttpGet]
    public IActionResult Index()
    {
        //CategoryResponseDto categoryResponseDto = new CategoryResponseDto(1, "deneme");
        var data = _carService.GetAll();
        return View(data);
    }


    [HttpGet]
    public IActionResult Update(Guid id)
    {
        var data = _carService.GetById(id);
        return View();


    }

    [HttpGet]
    public IActionResult Detail(Guid id)
    {
        var data = _carService.GetById(id);
        return View(data);
    }


    [HttpPost]
    public IActionResult Update(CarUpdateViewModel viewModel)
    {
        var root = _fileProvider.GetDirectoryContents("wwwroot");
        var images = root.First(x => x.Name == "images");

        var path = Path.Combine(images.PhysicalPath,viewModel.Image.FileName);

        using var stream = new FileStream(path, FileMode.Create);
         
        viewModel.Image.CopyTo(stream);
        CarUpdateRequestDto update = new CarUpdateRequestDto(
            Plate: viewModel.Plate,
            BrandName: viewModel.BrandName,
            DailyPrice: viewModel.DailyPrice,
            ModelName: viewModel.ModelName,
            ImageUrl: viewModel.Image.FileName,
            CarState: viewModel.CarState,
            KiloMeter: viewModel.KiloMeter,
            ModelYear: viewModel.ModelYear,
            ColorId: viewModel.ColorId,
            TransmissionId: viewModel.TransmissionId,
            FuelId: viewModel.FuelId,
            Id: viewModel.Id
        );

        return RedirectToAction("Index", "Cars");
    }
    
    
}
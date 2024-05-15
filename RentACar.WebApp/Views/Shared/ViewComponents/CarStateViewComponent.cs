using Microsoft.AspNetCore.Mvc;
using RentACar.WebApp.Helpers;
using RentACar.WebApp.Models.Entities.Enums;
using RentACar.WebApp.Models.ViewModels.Cars;

namespace RentACar.WebApp.Views.Shared.ViewComponents;

public class CarStateViewComponent : ViewComponent
{
    
    public IViewComponentResult Invoke(int selectedCarState)
    {
        var model = new CarStateViewModel
        {
            CarStateSelectList = EnumHelpers.GetEnumSelectList<CarState>(),
            CarState = (CarState)selectedCarState
        };
        return View(model);
    }
}
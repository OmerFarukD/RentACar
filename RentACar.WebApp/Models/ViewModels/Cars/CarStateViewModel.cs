using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.WebApp.Models.Entities.Enums;

namespace RentACar.WebApp.Models.ViewModels.Cars;

public class CarStateViewModel
{
    public CarState CarState { get; set; }
    public SelectList CarStateSelectList { get; set; }
}
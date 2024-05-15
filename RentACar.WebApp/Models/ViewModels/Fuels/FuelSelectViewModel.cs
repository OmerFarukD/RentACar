using Microsoft.AspNetCore.Mvc.Rendering;

namespace RentACar.WebApp.Models.ViewModels.Fuels;

public class FuelSelectViewModel
{
    public int FuelId { get; set; } 
    public IEnumerable<SelectListItem> Fuels { get; set; } 
}
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RentACar.WebApp.Models.ViewModels.Colors;

public class ColorSelectViewModel
{
    public int ColorId { get; set; } 
    public IEnumerable<SelectListItem> Colors { get; set; } 
}
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RentACar.WebApp.Models.ViewModels.Transmissions;

public class TransmissionSelectViewModel
{
    public int TransmissionId { get; set; }
    public IEnumerable<SelectListItem> Transmissions { get; set; } 
}


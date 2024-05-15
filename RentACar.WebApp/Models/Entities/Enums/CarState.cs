using System.ComponentModel.DataAnnotations;

namespace RentACar.WebApp.Models.Entities.Enums;

public enum CarState
{
    [Display(Name = "Alınabilir")]
    Available = 1,

    [Display(Name = "Kiralandı")]
    Rented = 2,

    [Display(Name = "Bakımda")]
    Maintenance = 3
}
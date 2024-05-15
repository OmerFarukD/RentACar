using RentACar.WebApp.Models.Entities.Enums;

namespace RentACar.WebApp.Models.Entities;

public class Car : Entity<Guid>
{
    public int ColorId  { get; set; }

    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    
    public CarState CarState { get; set; }
    
    public int? KiloMeter { get; set; }
    
    public short? ModelYear { get; set; }
    
    public string? Plate { get; set; }

    public string? BrandName { get; set; }

    public string? ModelName { get; set; }

    public decimal? DailyPrice { get; set; }

    public string? ImageUrl { get; set; }


    public virtual Transmission Transmission { get; set; }
    public virtual Fuel Fuel { get; set; }
    public virtual Color Color { get; set; }


    public Car()
    {
        Fuel = new Fuel();
        Color = new Color();
        Transmission = new Transmission();
    }
    
}
namespace RentACar.WebApp.Models.Entities;

public class Fuel : Entity<int>
{
    public string? Name { get; set; }

    public ICollection<Car> Cars { get; set; }

    public Fuel()
    {
        Cars = new HashSet<Car>();
    }
    
    
}
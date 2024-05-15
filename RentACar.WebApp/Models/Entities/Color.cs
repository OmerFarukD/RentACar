namespace RentACar.WebApp.Models.Entities;

public class Color : Entity<int>
{
    public string? Name { get; set; }

    public ICollection<Car> Cars { get; set; }

    public Color()
    {
        Cars = new HashSet<Car>();
    }
}
namespace RentACar.WebApp.Models.Entities;

public class Transmission : Entity<int>
{
    public string? Name { get; set; }

    public ICollection<Car> Cars { get; set; }

    public Transmission()
    {
        Cars = new HashSet<Car>();
    }
}
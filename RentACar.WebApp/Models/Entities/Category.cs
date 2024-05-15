namespace RentACar.WebApp.Models.Entities;

public class Category : Entity<int>
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }

    public Category()
    {
        Name = string.Empty;
        Products = new List<Product>();
    }

    public Category(int id,string name, List<Product> products)
    {
        Id = id;
        Name = name;
        Products = products;
    }
}
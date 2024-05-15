namespace RentACar.WebApp.Models.Entities;

public class Product : Entity<Guid>
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int  CategoryId { get; set; }
    public Category Category { get; set; }


    public Product(Guid id,string name, double price, int categoryId, Category category) 
    {
        Id = id;
        Name = name;
        Price = price;
        CategoryId = categoryId;
        Category = category;
    }


    public Product()
    {
        Name = string.Empty;
        Category = new Category();
    }
    
    
}
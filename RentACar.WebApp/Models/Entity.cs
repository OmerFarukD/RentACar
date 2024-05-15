namespace RentACar.WebApp.Models;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
}
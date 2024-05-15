using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories.Abstract;

public interface ICarRepository : IEntityRepository<Car,Guid>
{
    
}
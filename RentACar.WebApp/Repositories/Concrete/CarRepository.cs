using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Repositories.Concrete;

public class CarRepository: EfRepositoryBase<Car,Guid,BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context)
    {
    }
}
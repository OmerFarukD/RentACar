using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Repositories.Concrete;

public class FuelRepository : EfRepositoryBase<Fuel,int,BaseDbContext>, IFuelRepository
{
    public FuelRepository(BaseDbContext context) : base(context)
    { }
    
}
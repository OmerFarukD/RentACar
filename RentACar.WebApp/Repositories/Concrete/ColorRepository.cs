using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Repositories.Concrete;

public class ColorRepository : EfRepositoryBase<Color,int,BaseDbContext>, IColorRepository
{
    public ColorRepository(BaseDbContext context) : base(context)
    {
    }
}
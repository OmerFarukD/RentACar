using RentACar.WebApp.Models.Entities;
using RentACar.WebApp.Repositories.Abstract;

namespace RentACar.WebApp.Repositories.Concrete;

public class TransmissionRepository : EfRepositoryBase<Transmission,int,BaseDbContext>, ITransmissionRepository
{
    public TransmissionRepository(BaseDbContext context) : base(context)
    {
    }
}
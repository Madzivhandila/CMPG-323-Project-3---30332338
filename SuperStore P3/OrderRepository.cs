using Data;
using Models;

namespace EcoPower_Logistics
{
    public class ServiceRepository : GenericRepository<Order>, IOrderRepository
    {
        public ServiceRepository(SuperStoreContext context) : base(context)
        {
        }

        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }

    public class Service
    {
    }

    internal interface IOrderRepository
    {
    }
}

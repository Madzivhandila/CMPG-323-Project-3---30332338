using EcoPower_Logistics.Repository.Models;

namespace EcoPower_Logistics
{
    public interface IOrdreRepositoryI : IGenericRepository<OrderDetails>
    {
        OrderDetails GetMostRecentService();
    }
}

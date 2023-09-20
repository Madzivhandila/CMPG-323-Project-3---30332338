using EcoPower_Logistics.Repository.Models;

namespace EcoPower_Logistics
{
    public interface IOrderDetsilsRepository : IGenericRepository<OrderDetails>
    {
        OrderDetails GetMostRecentService();
    }
}

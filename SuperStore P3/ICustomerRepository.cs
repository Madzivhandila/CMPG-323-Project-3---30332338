using EcoPower_Logistics.Repository.Models;

    namespace EcoPower_Logistics
    {
        public interface ICustomerRepository : IGenericRepository<OrderDetails>
        {
            Customer GetMostRecentService();
        }
    }



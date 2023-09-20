using EcoPower_Logistics.Repository.Models;

namespace EcoPower_Logistics
{
    public interface IProductRepositoryI : IGenericRepository<Product>
    {
        Product GetMostRecentService();
    }
}

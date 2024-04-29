using RMS.Models;

namespace RMS.DataAccess.Repository.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}

using RMS.DataAccess.Repository.IRepository;
using RMS.Models;

namespace RMS.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        IEnumerable<Product> products = new List<Product>()
            {
                new Product()
                {
                    ProductNumber = "M001",
                    ProductDescription = "Sample Material 1",
                    ProductGroup = "Group1",
                    UnitOfMeasurement = "Unit1",
                    ProductType = "TypeA"
                },
                new Product()
                {
                    ProductNumber = "M002",
                    ProductDescription = "Sample Material 2",
                    ProductGroup = "Group2",
                    UnitOfMeasurement = "Unit2",
                    ProductType = "TypeB"
                },
                new Product()
                {
                    ProductNumber = "M003",
                    ProductDescription = "Sample Material 3",
                    ProductGroup = "Group3",
                    UnitOfMeasurement = "Unit3",
                    ProductType = "TypeC"
                }
            };
        public IEnumerable<Product> GetAllProducts()
        {
            return products.ToList();

        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}

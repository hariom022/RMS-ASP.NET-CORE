using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Repository.IRepository;

namespace RMSWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {

            return View(_productRepository.GetAllProducts());
        }
    }
}

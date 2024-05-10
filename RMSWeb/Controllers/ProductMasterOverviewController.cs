using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class ProductMasterOverviewController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public ProductMasterOverviewController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            var materialData = applicationDb.ProductMasterOverviews.ToList();
            return View(materialData);
        }
        public IActionResult Details(int id)
        {
            var materialDetail = applicationDb.ProductMasterOverviews.FirstOrDefault(x=>x.ProductId==id);
            return View(materialDetail);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class MaterialMasterOverviewController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public MaterialMasterOverviewController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            var materialData = applicationDb.MaterialMasterOverviews.ToList();
            return View(materialData);
        }
        public IActionResult Details(int id)
        {
            var materialDetail = applicationDb.MaterialMasterOverviews.FirstOrDefault(x=>x.MaterialId==id);
            return View(materialDetail);
        }

    }
}

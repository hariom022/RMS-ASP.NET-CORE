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
    }
}

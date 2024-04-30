using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class InventoryUpdateOverviewController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public InventoryUpdateOverviewController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {



            var inventoryUpdateData = applicationDb.InventoryUpdateOverviews.ToList();
            return View(inventoryUpdateData);
        }
        public IActionResult TemplateDownload()
        {
            return View();
        }
        public IActionResult TemplateUpload()
        {
            return View();
        }
    }
}

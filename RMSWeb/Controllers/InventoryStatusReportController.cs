using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class InventoryStatusReportController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public InventoryStatusReportController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {

            var inventoryStatusData = applicationDb.InventoryStatusReports.ToList();
            return View(inventoryStatusData);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class GoodsReceiptOverviewController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public GoodsReceiptOverviewController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
           
            var goodReceiptOverviewData = applicationDb.GoodsReceiptOverview.ToList();
            return View(goodReceiptOverviewData); 
        }
    }
}

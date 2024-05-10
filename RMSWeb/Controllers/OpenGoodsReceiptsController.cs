using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class OpenGoodsReceiptsController : Controller

    {
        private readonly ApplicationDbContext applicationDb;

        public OpenGoodsReceiptsController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
           
            var openGoodReceiptsData = applicationDb.GoodsReceiptOverviews.ToList();
            return View(openGoodReceiptsData);
        }
    }
}

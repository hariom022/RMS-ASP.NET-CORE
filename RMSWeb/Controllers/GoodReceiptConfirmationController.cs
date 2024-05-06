using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
   
    public class GoodReceiptConfirmationController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public GoodReceiptConfirmationController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {



            var goodReceipt = applicationDb.GoodsReceiptConfirmations.ToList();
            int TotalReceivedQuantity = goodReceipt.Sum(x => x.Quantity);
            ViewBag.Quantity = TotalReceivedQuantity;
            decimal TotalReceiptAmount = goodReceipt.Sum(x => x.Total); // Calculate the total
            ViewBag.Total = TotalReceiptAmount;
            return View(goodReceipt);
        }
    }
}

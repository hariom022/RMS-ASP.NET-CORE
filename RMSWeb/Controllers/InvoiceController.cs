using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public InvoiceController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            var invoiceData = applicationDb.Invoices.ToList();

            double totalSum = invoiceData.Sum(x=>x.Total);
            ViewBag.Total = totalSum;

            double tax = totalSum * 0.1;
            ViewBag.Tax = tax;

            double totalAmount = totalSum - tax;
            ViewBag.Amount = totalAmount;

            return View(invoiceData);
        }
    }
}

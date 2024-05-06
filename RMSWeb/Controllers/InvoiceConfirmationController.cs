using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class InvoiceConfirmationController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public InvoiceConfirmationController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            var invoiceConfirmationData = applicationDb.InvoicesConfirmations.ToList();

            double total = invoiceConfirmationData.Sum(x=>x.Total);
            ViewBag.Total=total;
            return View(invoiceConfirmationData);
        }
    }
}

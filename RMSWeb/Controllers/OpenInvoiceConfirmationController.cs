using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class OpenInvoiceConfirmationController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public OpenInvoiceConfirmationController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            
            var openInvoiceConfirmationData = applicationDb.OpenInvoiceConfirmations.ToList();
            return View(openInvoiceConfirmationData);
        }
    }
}

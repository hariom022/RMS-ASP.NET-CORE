using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class InvoiceConfirmController : Controller
    {
        public IActionResult Index()
        {
            var invoiceConfirmation = new InvoiceModelViewConfirmation
            {
                InvoiceNo = 123456,
                Date = DateTime.Now,
                Name = "Lifecare Hospital",
                Email = "lifecare@gmail.com",

                InvoiceConf= new List<InvoiceConfirmation>
                {
                    new InvoiceConfirmation {MaterialCode="ABC123",Material="Material A" , Quantity=5,Price=10.00, Total=50.00},
                    new InvoiceConfirmation {MaterialCode="DEF456",Material="Material B" , Quantity=10,Price=10.00, Total=100.00},
                },
                TotalAmount=150.00
                

            };
            return View(invoiceConfirmation);
        }
    }
}

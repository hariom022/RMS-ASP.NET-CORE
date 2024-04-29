using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class InvoiceOverviewController : Controller
    {
        public IActionResult Index()
        {
            var invoiceOverview = new InvoiceModelOverview
            {
                Invoice = new List<InvoiceOverview>
                {
                    new InvoiceOverview {Item=" ABC123" , MaterialCode="Product A" , Quantity=20, Description="Atorvastatin" , Rate= 14, Total=280},
                    new InvoiceOverview {Item=" DEF456" , MaterialCode="Product B" , Quantity=30, Description="Betamethasone" , Rate= 20, Total=600},
                    new InvoiceOverview {Item=" GHI789" , MaterialCode="Product C" , Quantity=15, Description="Carboplatin" , Rate= 30, Total=300}


                },
                SubTotal=1500,
                Tax = 150,
                TotalAmount=1350
            };
            return View(invoiceOverview);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class GoodReceiptConfirmationController : Controller
    {
        public IActionResult Index()
        {
            var model = new GoodReceiptViewModel
            {
                RequestNo = "REQ-001",
                QuotationNo = "QUO-001",
                SalesNo = "SN-123456",
                OBDNo = "OBD-78901",
                GRDate = DateTime.Today,
                TotalSKUQuantity = 85,
                goodReceiptConfirmation = new List<GoodReceiptConfirmation>
                {
                    new GoodReceiptConfirmation { MaterialCode = "ABC123", MaterialType = "Product A", Quantity = 50, UOM = "es", Rate = 14, Total = 700 },
                    new GoodReceiptConfirmation { MaterialCode = "DEF456", MaterialType = "Product B", Quantity = 15, UOM = "kg", Rate = 20, Total = 300 },
                    new GoodReceiptConfirmation { MaterialCode = "GHI678", MaterialType = "Product C", Quantity = 20, UOM = "es", Rate = 25, Total = 500 }
                },
                TotalReceivedQuantity = 85,
                TotalReceiptAmount = 1500.50m
            };

            return View(model);
        }
    }
}

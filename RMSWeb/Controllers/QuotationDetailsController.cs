using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class QuotationDetailsController : Controller
    {
        public IActionResult Index()
        {
            var quotation = new QuotationDetailsViewModel
            {
                RequestNo = 123,
                QuotationId = "QTN-001",
                Date = DateTime.Now,


                QuotationsData = new List<QuotationDetails>
                {

                    new QuotationDetails { MaterialCode = "ABC123", MaterialType = "Product A", Uom = "EA", Quantity = 20, Rate = 14, Total = 280 },
                    new QuotationDetails { MaterialCode = "DEF456", MaterialType = "Product B", Uom = "EA", Quantity = 30, Rate = 14, Total = 420 },
                    new QuotationDetails { MaterialCode = "GHI789", MaterialType = "Product C", Uom = "EA", Quantity = 10, Rate = 14, Total = 140 },
                    new QuotationDetails { MaterialCode = "JKL123", MaterialType = "Product D", Uom = "EA", Quantity = 40, Rate = 14, Total = 560 },
                    new QuotationDetails { MaterialCode = "MNO123", MaterialType = "Product E", Uom = "EA", Quantity = 20, Rate = 14, Total = 280 },
                    new QuotationDetails { MaterialCode = "PQR223", MaterialType = "Product F", Uom = "EA", Quantity = 10, Rate = 10, Total = 100 },
                    new QuotationDetails { MaterialCode = "STU333", MaterialType = "Product G", Uom = "EA", Quantity = 20, Rate = 20, Total = 400 },
                    new QuotationDetails { MaterialCode = "VWX234", MaterialType = "Product H", Uom = "EA", Quantity = 30, Rate = 14, Total = 420 },
                    new QuotationDetails { MaterialCode = "YZA100", MaterialType = "Product I", Uom = "EA", Quantity = 20, Rate = 15, Total = 330 },
                }
            };
            
            return View(quotation);
        }
       
    }
}

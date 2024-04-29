using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class OpenRequestReportController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public OpenRequestReportController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            //var openRequest = new List<OpenRequestReport>
            //{
            //    new OpenRequestReport { Id = 1, ProductName="Product A" , Quantity=25, Price=20, TotalValue=500},
            //    new OpenRequestReport { Id = 2, ProductName="Product B" , Quantity=30, Price=20, TotalValue=600},
            //    new OpenRequestReport { Id = 3, ProductName="Product C" , Quantity=40, Price=20, TotalValue=800},
            //    new OpenRequestReport { Id = 4, ProductName="Product D" , Quantity=50, Price=20, TotalValue=1000},
            //    new OpenRequestReport { Id = 5, ProductName="Product E ", Quantity=10, Price=20, TotalValue=300},
            //    new OpenRequestReport { Id = 6, ProductName="Product F" , Quantity=20, Price=20, TotalValue=400}
            //};
            //return View(openRequest);
            var openRequestReportData= applicationDb.OpenRequestReports.ToList();
            return View(openRequestReportData);
        }
    }
}

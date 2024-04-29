using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;
using System.Collections.Generic;

namespace RMSWeb.Controllers
{
    public class SalesOrderDetailsController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public SalesOrderDetailsController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
           

            var salesOrderDetailsData = applicationDb.SalesOrderDetailsReports.ToList();
            return View(salesOrderDetailsData);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class LastConsumptionReportController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public LastConsumptionReportController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
          
            //var lastConsumptionReportData = applicationDb.LastConsumptionReports.ToList();
            return View();
        }
    }
}

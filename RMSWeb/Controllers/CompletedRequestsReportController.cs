using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class CompletedRequestsReportController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public CompletedRequestsReportController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
         

            var completedRequestReportData = applicationDb.CompletedRequestsReports.ToList();
            return View(completedRequestReportData);
        }
    }
}

using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class QuotationDetailsController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public QuotationDetailsController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {   
            return View();
        }
        public IActionResult Details(int id)
        {
            var quotationDetails = applicationDb.QuotationApprovals.FirstOrDefault(x => x.Id == id);
            return View(quotationDetails);
        }




    }
}

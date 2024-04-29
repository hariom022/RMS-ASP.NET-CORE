using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
   // [Route("/QuotationApproval")]
    public class QuotationApprovalController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public QuotationApprovalController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {

            var quotationApprovalData= applicationDb.QuotationApprovals.ToList();
            return View(quotationApprovalData);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class OrderSummaryController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public OrderSummaryController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            IEnumerable<NewPage> model = applicationDb.NewPages;
            return View(model);
        }
    }
}

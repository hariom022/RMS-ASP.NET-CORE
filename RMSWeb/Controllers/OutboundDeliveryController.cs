using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class OutboundDeliveryController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public OutboundDeliveryController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {

            var outboundData = applicationDb.OutboundDelivery.ToList();
            return View(outboundData);
        }
    }
}

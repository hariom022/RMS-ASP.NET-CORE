using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;

namespace RMSWeb.Controllers
{
    public class ProofOfDeliveryController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public ProofOfDeliveryController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            var ProofOfDeliveryData = applicationDb.ProofOfDelivery.ToList();
            return View(ProofOfDeliveryData);
        }
    }
}

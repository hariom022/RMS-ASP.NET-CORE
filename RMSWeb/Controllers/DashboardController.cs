using Microsoft.AspNetCore.Mvc;

namespace RMSWeb.Controllers
{
    public class DashboardController : Controller
    {
        //[Route("Dashboard")]
        public IActionResult Overview()
        {
            return View();
        }
    }
}

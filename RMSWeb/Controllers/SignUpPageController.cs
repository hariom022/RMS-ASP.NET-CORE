using Microsoft.AspNetCore.Mvc;

namespace RMSWeb.Controllers
{
    public class SignUpPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

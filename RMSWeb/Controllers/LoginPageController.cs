using Microsoft.AspNetCore.Mvc;

namespace RMSWeb.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace RMSWeb.Controllers
{
    public class ForgotPasswordPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OtpVerification()
        {
            return View();
        }
        public IActionResult PasswordResetSuccess()
        {
            return View();
        }
        public IActionResult AccountLockedPage()
        {
            return View();
        }
    }
}

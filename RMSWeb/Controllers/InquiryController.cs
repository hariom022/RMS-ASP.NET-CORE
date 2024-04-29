using Microsoft.AspNetCore.Mvc;

namespace RMSWeb.Controllers
{
    public class InquiryController : Controller
    {
        public IActionResult SubmitInquiry()
        {
            return View();
        }
    }
}

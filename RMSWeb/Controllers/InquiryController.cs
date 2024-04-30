using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class InquiryController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public InquiryController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult SubmitInquiry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitInquiry(Inquiry inquiry)
        {
            if (ModelState.IsValid)
            {

                inquiry.RequestNo = GenerateRequestNumber();

                applicationDb.NewInquiry.Add(inquiry);
                applicationDb.SaveChanges();

                return RedirectToAction("SubmitInquiry"); // Redirect to a different action after successful submission
            }
            return View(inquiry);
            
        }
        private int GenerateRequestNumber()
        {
            // Your implementation to generate a unique request number
            return new Random().Next(10000, 99999);
        }
    }
}

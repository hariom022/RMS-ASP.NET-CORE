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

            ViewBag.Materials = applicationDb.MaterialMasterOverviews.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitInquiry(Inquiry inquiry)
        {
            if (ModelState.IsValid)
            {

                applicationDb.Inquiries.Add(inquiry);
                applicationDb.SaveChanges();

                return RedirectToAction(nameof(SubmitInquiry));
            }
            return View(inquiry);
            
        }

    }
}

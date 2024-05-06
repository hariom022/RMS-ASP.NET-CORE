using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class SalesInquiryRequestDTOController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public SalesInquiryRequestDTOController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var modelData = new SalesInquiryRequestDTO();
            modelData.salesInquiryItemsDTO.Add(new SalesInquiryItemsDTO());
            return View(modelData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SalesInquiryRequestDTO salesInquiryRequest)
        {
            if (ModelState.IsValid)
            {
                applicationDb.salesInquiryRequestDTOs.Add(salesInquiryRequest);
                applicationDb.SaveChanges();
                return RedirectToAction("Create");
            }
            return View(salesInquiryRequest);
        }
    }
}

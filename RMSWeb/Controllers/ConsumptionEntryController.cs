using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    [Route("/Consumption/[action]")]
    public class ConsumptionEntryController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public ConsumptionEntryController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult SubmitConsumption()
        {
           ViewBag.Materials = applicationDb.MaterialMasterOverviews.ToList();
           ViewBag.Plants = applicationDb.Plants.ToList();
                return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitConsumption(ConsumptionEntry consumption)
        {
           if(ModelState.IsValid)
            {
                applicationDb.ConsumptionEntries.Add(consumption);
                applicationDb.SaveChanges();
                return RedirectToAction(nameof(SubmitConsumption));
            }
            return View(consumption);
        }


    }
}

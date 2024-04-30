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
            // Action to display a list of consumption entries

            return View();
        }
        public IActionResult Create( )
        {
            var data = new ConsumptionEntryViewModel
            {
                ConsumptionEntry = new ConsumptionEntry(),
                Plants = applicationDb.Plants.ToList(),
                MaterialMasterOverviews = applicationDb.MaterialMasterOverviews.ToList(),
            };
                return View(data);
        }

        [HttpPost]
        public IActionResult Create(ConsumptionEntryViewModel data)
        {
            if (ModelState.IsValid)
            {
                applicationDb.ConsumptionEntries.Add(data.ConsumptionEntry);
                applicationDb.SaveChanges();

                return RedirectToAction("Create");
            }
            data.Plants = applicationDb.Plants.ToList();
            data.MaterialMasterOverviews = applicationDb.MaterialMasterOverviews.ToList();
            return View(data);
        }

       
    




        // Other action methods for updating, deleting, and viewing consumption entries
    }
}

using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    [Route("/Consumption/[action]")]
    public class ConsumptionEntryController : Controller
    {
        public IActionResult Index()
        {
            // Action to display a list of consumption entries

            return View();
        }



        public IActionResult Create()
        {
            // Action to display the consumption entry form
            List<Plant> plants = new()
            {
                new() { CustomerName = "Customer 1",  CustomerDescription = "Description 1" },
                new()  { CustomerName = "Customer 2",  CustomerDescription = "Description 2" }
                // Add more plants as needed
            };
            return View(plants);
        }

        [HttpPost]
        public IActionResult Create(ConsumptionEntry newEntry)
        {
            // Action to process the form submission and save the consumption entry
            return RedirectToAction("Index");
        }

        // Other action methods for updating, deleting, and viewing consumption entries
    }
}

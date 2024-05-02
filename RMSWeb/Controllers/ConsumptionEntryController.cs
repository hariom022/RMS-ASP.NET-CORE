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
        public IActionResult Create( )
        {
           
                return View();
        }

      
    }
}

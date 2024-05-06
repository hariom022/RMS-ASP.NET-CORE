using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.DataAccess.Repository.IRepository;
using RMS.Models;

namespace RMSWeb.Controllers
{
    [Route("/Plant/[action]")]
    public class PlantController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public PlantController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }

        public IActionResult Index()
        {
            var plantData= applicationDb.Plants.ToList();
            return View(plantData);
        }


        public IActionResult Details(int id)
        {
            var plantDetail= applicationDb.Plants.FirstOrDefault(x=>x.CustomerId==id);
            return View(plantDetail);
        }

        //private Plant GetPlantById(string id)
        //{
        //    // Dummy implementation - Replace with actual data retrieval logic
        //    return new Plant { CustomerName = id, CustomerDescription = "Description for Plant " + id };
        //}
    }
}

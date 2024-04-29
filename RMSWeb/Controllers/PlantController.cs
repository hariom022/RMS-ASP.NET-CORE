using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Repository.IRepository;
using RMS.Models;

namespace RMSWeb.Controllers
{
    [Route("/Plant/[action]")]
    public class PlantController : Controller
    {
        private readonly IPlantRepository _plantRepository;

        public PlantController(IPlantRepository plantRepository)
        {
            _plantRepository = plantRepository;
        }

        public IActionResult Index()
        {
            return View(_plantRepository.GetAllPlants());
        }


        public IActionResult Details(string id)
        {
            Plant plant = GetPlantById(id);

            if (plant == null)
            {
                return NotFound();
            }

            return View(plant);
        }

        private Plant GetPlantById(string id)
        {
            // Dummy implementation - Replace with actual data retrieval logic
            return new Plant { CustomerName = id, CustomerDescription = "Description for Plant " + id };
        }
    }
}

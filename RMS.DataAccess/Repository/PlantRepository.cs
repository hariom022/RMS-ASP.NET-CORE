//using RMS.DataAccess.Repository.IRepository;
//using RMS.Models;

//namespace RMS.DataAccess.Repository
//{
//    public class PlantRepository : IPlantRepository
//    {

//        IEnumerable<Plant> plants = new List<Plant>()
//            {
//                new Plant() {CustomerId= Guid.NewGuid(), CustomerName = "Customer 1",  CustomerDescription = "Description 1" },
//                new Plant()  {CustomerId= Guid.NewGuid(), CustomerName = "Customer 2",  CustomerDescription = "Description 2" }
//            };

//        public IEnumerable<Plant> GetAllPlants()
//        {
//            return plants.ToList();
//        }

//        public Plant? GetPlantById(Guid id)
//        {
//            return plants.FirstOrDefault(p => p.CustomerId == id);
//        }
//    }
//}

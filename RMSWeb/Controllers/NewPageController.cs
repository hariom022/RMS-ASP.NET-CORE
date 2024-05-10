using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class NewPageController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public NewPageController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            IEnumerable<NewPage> model = applicationDb.NewPages;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddNewPage(string product, int quantity) {

            var newPage = new NewPage { Product = product, Quantity = quantity };
            applicationDb.NewPages.Add(newPage);
            applicationDb.SaveChanges();

            return RedirectToAction("Index");
        }
      
        

       
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class Role_AuthenticationController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public Role_AuthenticationController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
           
            return View();
        }


        //[HttpPost]
        //public IActionResult Add(Role_Authentication model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        applicationDb.Role_Authentications.Add(model);
        //        applicationDb.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View("Index", model);
        //}
    }
}

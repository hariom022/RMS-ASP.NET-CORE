using Microsoft.AspNetCore.Mvc;
using RMS.DataAccess.Data;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly ApplicationDbContext applicationDb;

        public UserAccountController(ApplicationDbContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(UserAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                await applicationDb.UserAccounts.AddAsync(userAccount);
                await applicationDb.SaveChangesAsync();
                TempData["Success"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserAccount userAccount)
        {
            var myUser = applicationDb.UserAccounts.Where(x => x.Email == userAccount.Email && x.Password == userAccount.Password).FirstOrDefault();
            if (myUser != null)
            {
                //HttpContext.Session.SetString("UserSession",myUser.Email);
                return RedirectToAction("Overview", "Dashboard");
            }
            else
            {
                ViewBag.Message = " Email or Password in incorrect...";
            }
            return View();
        }
    }
}

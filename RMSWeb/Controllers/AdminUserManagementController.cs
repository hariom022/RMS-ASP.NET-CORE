using Microsoft.AspNetCore.Mvc;
using RMS.Models;

namespace RMSWeb.Controllers
{
    public class AdminUserManagementController : Controller
    {
        public IActionResult Index()
        {
            var adminUser = new List<AdminUserManagement>
            {
                new AdminUserManagement{Id=1, Name="John Doe", Email="john@gmail.com",Role="Admin"},
                new AdminUserManagement{Id=2, Name="Alexander Doe", Email="alexander@gmail.com",Role="Manager"},
                new AdminUserManagement{Id=3, Name="James", Email="james@gmail.com",Role="Admin"},
                new AdminUserManagement{Id=4, Name="Lily", Email="lily@gmail.com",Role="Admin"},
                new AdminUserManagement{Id=5, Name="Aubrey", Email="aubrey@gmail.com",Role="User"},
                new AdminUserManagement{Id=6, Name="Archie", Email="archie@gmail.com",Role="User"},
                new AdminUserManagement{Id=7, Name="Noah", Email="noah@gmail.com",Role="User"},
                new AdminUserManagement{Id=8, Name="Michael", Email="Michael123@gmail.com",Role="User"},

            };

            return View(adminUser);
        }
        public IActionResult ChangePassword()
        {
            
            return View();
        }
        public IActionResult AdminUserProfileUpdate()
        {
           
            return View();
        }
     
    }
}

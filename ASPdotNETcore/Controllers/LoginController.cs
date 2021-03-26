using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NETcore.Models;
using ASPdotNETcore.Models;
using Microsoft.AspNetCore.Http;

namespace ASP.NETcore.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        static List<User> user = new List<User>();
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
            user.Add(new User(){
                UserId = 1,
                UserName = "Admin",
                Password = "123",
                RoleId = 1
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User u)
        {
            if(ModelState.IsValid)
            {
                 var result = CheckLogin(u.UserName,u.Password);
                    if(result)
                    {
                    HttpContext.Session.SetString("username",u.UserName);
                    return RedirectToAction("Index","Home");
                    }
                    else  ModelState.AddModelError("", "Wrong username or password");
                
            }
            
            return View("Login");
        }
        public bool CheckLogin(string username, string password)
        {
            var result = user.Count(x => x.UserName == username  && x.Password == password);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IActionResult Login()
        {
       
            return View();
        }

          public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index","Home");
        }

    }
}

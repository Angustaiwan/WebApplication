using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel usermodel)
        {
            if (usermodel.UserName == "" && usermodel.Password == "")
            {
                return View("LoginSuccess", usermodel);
            }
            else
            {
                return View("LoginFailure", usermodel);
            }
        }
    }
}

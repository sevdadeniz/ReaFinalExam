using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AdminPanel.Models;
using System;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
                {
            var users = new List<UserModel>()
                    {
                        new UserModel{username="admin",password=123456 }
                    };
            return users;
                }
       

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
           var u = PutValue();
            var userName = u.Where(u => u.username.Equals(user.username));
            var userPassword = userName.Where(u => u.password.Equals(user.password));

            if(userPassword.Count() == 1)
            {
               
                return RedirectToAction("Index", "Home");
            }


            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.web.Models;

namespace app.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var nameList = new List<Dog>(){
                new Dog{ Name = "Rocky" },
                new Dog{ Name = "Jake" },
                new Dog{ Name = "Toby" },
                new Dog{ Name = "Murphy" }
            };


            ViewData["Name"] = "Charles";
            
            return View(nameList);
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}

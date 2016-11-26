using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var nameList = new List<string>(){
                "Charles", "Danny", "Sam"
            };


            ViewData["Name"] = "Charles";
            //ViewData["NameList"] = list;
            return View(nameList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.dd";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

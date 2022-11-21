using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _221122_asp.net_core.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PostData(string value1, string value2)
        {
            ViewData["Result"] = Int32.Parse(value1) + Int32.Parse(value2);
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication221212.Data;
using WebApplication221212.Models;

namespace WebApplication221212.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext db;
        public MovieController(MovieContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var movies = db.Movie2.ToList();
            return View(movies);
        }
    }
}
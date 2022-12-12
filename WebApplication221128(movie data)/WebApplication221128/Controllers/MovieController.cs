using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication221128.Models;
using WebApplication221128.Data;

namespace WebApplication221128.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            MovieData db = new MovieData();
            var movies = db.GetMovies();
            return View(movies);
        }
        public IActionResult Search()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Search(string value1)
        {
            MovieData db = new MovieData();
            var movies = db.SearchMovies(value1);

            return View(movies);
        }
    }
}
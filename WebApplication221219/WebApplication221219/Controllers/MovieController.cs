using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication221219.Data;
using WebApplication221219.Models;

namespace WebApplication221219.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext _db;
        public MovieController(MovieContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var movies = _db.Movie2.ToList();
            return View(movies);
        }
        public ViewResult Edit(int Id)
        {
            var movie = _db.Movie2.Where(n => n.Id == Id).FirstOrDefault();
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie2 m)
        {
            _db.Update(m);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication221226.Data;
using WebApplication221226.Models;

namespace WebApplication221226.Controllers
{
    public class Movie3Controller : Controller
    {
        private readonly Movie3Context _context;

        public Movie3Controller(Movie3Context context)
        {
            _context = context;
        }

        // GET: Movie3
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie3.ToListAsync());
        }

        // GET: Movie3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie3 = await _context.Movie3
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie3 == null)
            {
                return NotFound();
            }

            return View(movie3);
        }

        // GET: Movie3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movie3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Price")] Movie3 movie3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie3);
        }

        // GET: Movie3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie3 = await _context.Movie3.FindAsync(id);
            if (movie3 == null)
            {
                return NotFound();
            }
            return View(movie3);
        }

        // POST: Movie3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Price")] Movie3 movie3)
        {
            if (id != movie3.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Movie3Exists(movie3.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie3);
        }

        // GET: Movie3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie3 = await _context.Movie3
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie3 == null)
            {
                return NotFound();
            }

            return View(movie3);
        }

        // POST: Movie3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie3 = await _context.Movie3.FindAsync(id);
            _context.Movie3.Remove(movie3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Movie3Exists(int id)
        {
            return _context.Movie3.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moviz.Data;
using Moviz.Models;

namespace Moviz.Controllers
{
    public class GenreEFController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenreEFController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GenreEF
        public async Task<IActionResult> Index()
        {
            return View(await _context.Genres.ToListAsync());
        }

        // GET: GenreEF/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genreModel = await _context.Genres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genreModel == null)
            {
                return NotFound();
            }

            return View(genreModel);
        }

        // GET: GenreEF/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenreEF/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] GenreModel genreModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genreModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genreModel);
        }

        // GET: GenreEF/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genreModel = await _context.Genres.FindAsync(id);
            if (genreModel == null)
            {
                return NotFound();
            }
            return View(genreModel);
        }

        // POST: GenreEF/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] GenreModel genreModel)
        {
            if (id != genreModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genreModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreModelExists(genreModel.Id))
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
            return View(genreModel);
        }

        // GET: GenreEF/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genreModel = await _context.Genres
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genreModel == null)
            {
                return NotFound();
            }

            return View(genreModel);
        }

        // POST: GenreEF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genreModel = await _context.Genres.FindAsync(id);
            if (genreModel != null)
            {
                _context.Genres.Remove(genreModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenreModelExists(int id)
        {
            return _context.Genres.Any(e => e.Id == id);
        }
    }
}

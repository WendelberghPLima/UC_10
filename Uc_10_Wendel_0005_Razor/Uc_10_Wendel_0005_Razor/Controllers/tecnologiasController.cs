using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0005_Razor.Data;
using Uc_10_Wendel_0005_Razor.Models;

namespace Uc_10_Wendel_0005_Razor.Controllers
{
    public class tecnologiasController : Controller
    {
        private readonly Uc_10_Wendel_0005_RazorContext _context;

        public tecnologiasController(Uc_10_Wendel_0005_RazorContext context)
        {
            _context = context;
        }

        // GET: tecnologias
        public async Task<IActionResult> Index()
        {
            return View(await _context.tecnologia.ToListAsync());
        }

        // GET: tecnologias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnologia = await _context.tecnologia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tecnologia == null)
            {
                return NotFound();
            }

            return View(tecnologia);
        }

        // GET: tecnologias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tecnologias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Url,Date")] tecnologia tecnologia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tecnologia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tecnologia);
        }

        // GET: tecnologias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnologia = await _context.tecnologia.FindAsync(id);
            if (tecnologia == null)
            {
                return NotFound();
            }
            return View(tecnologia);
        }

        // POST: tecnologias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Url,Date")] tecnologia tecnologia)
        {
            if (id != tecnologia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tecnologia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tecnologiaExists(tecnologia.Id))
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
            return View(tecnologia);
        }

        // GET: tecnologias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnologia = await _context.tecnologia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tecnologia == null)
            {
                return NotFound();
            }

            return View(tecnologia);
        }

        // POST: tecnologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tecnologia = await _context.tecnologia.FindAsync(id);
            if (tecnologia != null)
            {
                _context.tecnologia.Remove(tecnologia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tecnologiaExists(int id)
        {
            return _context.tecnologia.Any(e => e.Id == id);
        }
    }
}

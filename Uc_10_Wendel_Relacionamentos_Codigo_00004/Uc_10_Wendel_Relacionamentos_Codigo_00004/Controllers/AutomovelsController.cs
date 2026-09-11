using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamentos_Codigo_00004.Data;
using Uc_10_Wendel_Relacionamentos_Codigo_00004.Models;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Controllers
{
    public class AutomovelsController : Controller
    {
        private readonly Uc_10_Wendel_Relacionamentos_Codigo_00004Context _context;

        public AutomovelsController(Uc_10_Wendel_Relacionamentos_Codigo_00004Context context)
        {
            _context = context;
        }

        // GET: Automovels
        public async Task<IActionResult> Index()
        {
            var uc_10_Wendel_Relacionamentos_Codigo_00004Context = _context.Automovel.Include(a => a.Marca);
            return View(await uc_10_Wendel_Relacionamentos_Codigo_00004Context.ToListAsync());
        }

        // GET: Automovels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel
                .Include(a => a.Marca)
                .FirstOrDefaultAsync(m => m.AutomovelID == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // GET: Automovels/Create
        public IActionResult Create()
        {
            ViewData["MarcaID"] = new SelectList(_context.Set<Marca>(), "MarcaID", "MarcaID");
            return View();
        }

        // POST: Automovels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutomovelID,Nome,MarcaID")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(automovel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaID"] = new SelectList(_context.Set<Marca>(), "MarcaID", "MarcaID", automovel.MarcaID);
            return View(automovel);
        }

        // GET: Automovels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel.FindAsync(id);
            if (automovel == null)
            {
                return NotFound();
            }
            ViewData["MarcaID"] = new SelectList(_context.Set<Marca>(), "MarcaID", "MarcaID", automovel.MarcaID);
            return View(automovel);
        }

        // POST: Automovels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutomovelID,Nome,MarcaID")] Automovel automovel)
        {
            if (id != automovel.AutomovelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(automovel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutomovelExists(automovel.AutomovelID))
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
            ViewData["MarcaID"] = new SelectList(_context.Set<Marca>(), "MarcaID", "MarcaID", automovel.MarcaID);
            return View(automovel);
        }

        // GET: Automovels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var automovel = await _context.Automovel
                .Include(a => a.Marca)
                .FirstOrDefaultAsync(m => m.AutomovelID == id);
            if (automovel == null)
            {
                return NotFound();
            }

            return View(automovel);
        }

        // POST: Automovels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var automovel = await _context.Automovel.FindAsync(id);
            if (automovel != null)
            {
                _context.Automovel.Remove(automovel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutomovelExists(int id)
        {
            return _context.Automovel.Any(e => e.AutomovelID == id);
        }
    }
}

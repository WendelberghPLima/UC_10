using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0002_Razor.Data;
using Uc_10_Wendel_0002_Razor.Models;

namespace Uc_10_Wendel_0002_Razor.Controllers
{
    public class viagensController : Controller
    {
        private readonly Uc_10_Wendel_0002_RazorContext _context;

        public viagensController(Uc_10_Wendel_0002_RazorContext context)
        {
            _context = context;
        }

        // GET: viagens
        public async Task<IActionResult> Index()
        {
            return View(await _context.viagens.ToListAsync());
        }

        // GET: viagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagens = await _context.viagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viagens == null)
            {
                return NotFound();
            }

            return View(viagens);
        }

        // GET: viagens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: viagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Destino,Data,Tipo")] viagens viagens)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viagens);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viagens);
        }

        // GET: viagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagens = await _context.viagens.FindAsync(id);
            if (viagens == null)
            {
                return NotFound();
            }
            return View(viagens);
        }

        // POST: viagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Destino,Data,Tipo")] viagens viagens)
        {
            if (id != viagens.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viagens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!viagensExists(viagens.Id))
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
            return View(viagens);
        }

        // GET: viagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viagens = await _context.viagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viagens == null)
            {
                return NotFound();
            }

            return View(viagens);
        }

        // POST: viagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viagens = await _context.viagens.FindAsync(id);
            if (viagens != null)
            {
                _context.viagens.Remove(viagens);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool viagensExists(int id)
        {
            return _context.viagens.Any(e => e.Id == id);
        }
    }
}

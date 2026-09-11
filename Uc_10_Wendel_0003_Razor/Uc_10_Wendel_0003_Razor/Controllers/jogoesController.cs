using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0003_Razor.Data;
using Uc_10_Wendel_0003_Razor.Models;

namespace Uc_10_Wendel_0003_Razor.Controllers
{
    public class jogoesController : Controller
    {
        private readonly Uc_10_Wendel_0003_RazorContext _context;

        public jogoesController(Uc_10_Wendel_0003_RazorContext context)
        {
            _context = context;
        }

        // GET: jogoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.jogo.ToListAsync());
        }

        // GET: jogoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // GET: jogoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: jogoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Genero,Desenvolvedor,Plataforma,DataLancamento,Preco")] jogo jogo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogo);
        }

        // GET: jogoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogo.FindAsync(id);
            if (jogo == null)
            {
                return NotFound();
            }
            return View(jogo);
        }

        // POST: jogoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Genero,Desenvolvedor,Plataforma,DataLancamento,Preco")] jogo jogo)
        {
            if (id != jogo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!jogoExists(jogo.Id))
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
            return View(jogo);
        }

        // GET: jogoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogo = await _context.jogo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // POST: jogoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jogo = await _context.jogo.FindAsync(id);
            if (jogo != null)
            {
                _context.jogo.Remove(jogo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool jogoExists(int id)
        {
            return _context.jogo.Any(e => e.Id == id);
        }
    }
}

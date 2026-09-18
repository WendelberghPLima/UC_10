using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamentos_Descricao__00500.Data;
using Uc_10_Wendel_Relacionamentos_Descricao__00500.Models;

namespace Uc_10_Wendel_Relacionamentos_Descricao__00500.Controllers
{
    public class TipoConsultasController : Controller
    {
        private readonly Uc_10_Wendel_Relacionamentos_Descricao__00500Context _context;

        public TipoConsultasController(Uc_10_Wendel_Relacionamentos_Descricao__00500Context context)
        {
            _context = context;
        }

        // GET: TipoConsultas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoConsulta.ToListAsync());
        }

        // GET: TipoConsultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.TipoConsultaId == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // GET: TipoConsultas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoConsultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoConsultaId,Nome,Descricao")] TipoConsulta tipoConsulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoConsulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoConsulta);
        }

        // GET: TipoConsultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }
            return View(tipoConsulta);
        }

        // POST: TipoConsultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoConsultaId,Nome,Descricao")] TipoConsulta tipoConsulta)
        {
            if (id != tipoConsulta.TipoConsultaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoConsulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoConsultaExists(tipoConsulta.TipoConsultaId))
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
            return View(tipoConsulta);
        }

        // GET: TipoConsultas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.TipoConsultaId == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // POST: TipoConsultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta != null)
            {
                _context.TipoConsulta.Remove(tipoConsulta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoConsultaExists(int id)
        {
            return _context.TipoConsulta.Any(e => e.TipoConsultaId == id);
        }

        public IActionResult Informacoes()
        {
            return View();
        }

        public IActionResult Orientacoes()
        {
            return View();
        }
    }
}

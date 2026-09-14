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
    public class ConsultasController : Controller
    {
        private readonly Uc_10_Wendel_Relacionamentos_Descricao__00500Context _context;

        public ConsultasController(Uc_10_Wendel_Relacionamentos_Descricao__00500Context context)
        {
            _context = context;
        }

        // GET: Consultas
        public async Task<IActionResult> Index()
        {
            var uc_10_Wendel_Relacionamentos_Descricao__00500Context = _context.Consulta.Include(c => c.Medico).Include(c => c.Paciente).Include(c => c.TipoConsulta);
            return View(await uc_10_Wendel_Relacionamentos_Descricao__00500Context.ToListAsync());
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta
                .Include(c => c.Medico)
                .Include(c => c.Paciente)
                .Include(c => c.TipoConsulta)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        public IActionResult Create()
        {
            ViewData["MedicoId"] = new SelectList(_context.Medico, "MedicoId", "CRM");
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "Nome");
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "TipoConsultaId", "Nome");
            return View();
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultaId,Data,Observacao,PacienteId,MedicoId,TipoConsultaId")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "MedicoId", "CRM", consulta.MedicoId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "Nome", consulta.PacienteId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "TipoConsultaId", "Nome", consulta.TipoConsultaId);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["MedicoId"] = new SelectList(_context.Medico, "MedicoId", "CRM", consulta.MedicoId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "Nome", consulta.PacienteId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "TipoConsultaId", "Nome", consulta.TipoConsultaId);
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultaId,Data,Observacao,PacienteId,MedicoId,TipoConsultaId")] Consulta consulta)
        {
            if (id != consulta.ConsultaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.ConsultaId))
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
            ViewData["MedicoId"] = new SelectList(_context.Medico, "MedicoId", "CRM", consulta.MedicoId);
            ViewData["PacienteId"] = new SelectList(_context.Paciente, "PacienteId", "Nome", consulta.PacienteId);
            ViewData["TipoConsultaId"] = new SelectList(_context.TipoConsulta, "TipoConsultaId", "Nome", consulta.TipoConsultaId);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consulta
                .Include(c => c.Medico)
                .Include(c => c.Paciente)
                .Include(c => c.TipoConsulta)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consulta = await _context.Consulta.FindAsync(id);
            if (consulta != null)
            {
                _context.Consulta.Remove(consulta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(int id)
        {
            return _context.Consulta.Any(e => e.ConsultaId == id);
        }
    }
}

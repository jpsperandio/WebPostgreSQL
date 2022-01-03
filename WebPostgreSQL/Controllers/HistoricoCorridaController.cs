#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;

namespace WebPostgreSQL.Controllers
{
    public class HistoricoCorridaController : Controller
    {
        private readonly Contexto _context;

        public HistoricoCorridaController(Contexto context)
        {
            _context = context;
        }

        // GET: HistoricoCorrida
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricoCorrida.ToListAsync());
        }

        // GET: HistoricoCorrida/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoCorrida = await _context.HistoricoCorrida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoCorrida == null)
            {
                return NotFound();
            }

            return View(historicoCorrida);
        }

        // GET: HistoricoCorrida/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HistoricoCorrida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompetidorId,PistaCorridaId,DataCorrida,TempoGasto")] HistoricoCorrida historicoCorrida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historicoCorrida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicoCorrida);
        }

        // GET: HistoricoCorrida/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoCorrida = await _context.HistoricoCorrida.FindAsync(id);
            if (historicoCorrida == null)
            {
                return NotFound();
            }
            return View(historicoCorrida);
        }

        // POST: HistoricoCorrida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompetidorId,PistaCorridaId,DataCorrida,TempoGasto")] HistoricoCorrida historicoCorrida)
        {
            if (id != historicoCorrida.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicoCorrida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoCorridaExists(historicoCorrida.Id))
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
            return View(historicoCorrida);
        }

        // GET: HistoricoCorrida/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicoCorrida = await _context.HistoricoCorrida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicoCorrida == null)
            {
                return NotFound();
            }

            return View(historicoCorrida);
        }

        // POST: HistoricoCorrida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historicoCorrida = await _context.HistoricoCorrida.FindAsync(id);
            _context.HistoricoCorrida.Remove(historicoCorrida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoCorridaExists(int id)
        {
            return _context.HistoricoCorrida.Any(e => e.Id == id);
        }
    }
}

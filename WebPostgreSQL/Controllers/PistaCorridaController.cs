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
    public class PistaCorridaController : Controller
    {
        private readonly Contexto _context;

        public PistaCorridaController(Contexto context)
        {
            _context = context;
        }

        // GET: PistaCorrida
        public async Task<IActionResult> Index()
        {
            return View(await _context.PistaCorrida.ToListAsync());
        }

        // GET: PistaCorrida/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pistaCorrida = await _context.PistaCorrida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pistaCorrida == null)
            {
                return NotFound();
            }

            return View(pistaCorrida);
        }

        // GET: PistaCorrida/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PistaCorrida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] PistaCorrida pistaCorrida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pistaCorrida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pistaCorrida);
        }

        // GET: PistaCorrida/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pistaCorrida = await _context.PistaCorrida.FindAsync(id);
            if (pistaCorrida == null)
            {
                return NotFound();
            }
            return View(pistaCorrida);
        }

        // POST: PistaCorrida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] PistaCorrida pistaCorrida)
        {
            if (id != pistaCorrida.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pistaCorrida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PistaCorridaExists(pistaCorrida.Id))
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
            return View(pistaCorrida);
        }

        // GET: PistaCorrida/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pistaCorrida = await _context.PistaCorrida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pistaCorrida == null)
            {
                return NotFound();
            }

            return View(pistaCorrida);
        }

        // POST: PistaCorrida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pistaCorrida = await _context.PistaCorrida.FindAsync(id);
            _context.PistaCorrida.Remove(pistaCorrida);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PistaCorridaExists(int id)
        {
            return _context.PistaCorrida.Any(e => e.Id == id);
        }
    }
}

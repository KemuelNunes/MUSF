using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MUSF.Domain.Context;
using MUSF.Domain.Entities;

namespace Musf.Controllers
{
    public class MissaosController : Controller
    {
        private readonly Context _context;

        public MissaosController(Context context)
        {
            _context = context;
        }

        // GET: Missaos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Misao.ToListAsync());
        }

        // GET: Missaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Misao == null)
            {
                return NotFound();
            }

            var missao = await _context.Misao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (missao == null)
            {
                return NotFound();
            }

            return View(missao);
        }

        // GET: Missaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Missaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataInicio,DataFim,Objetivo,Envolvidos,Etapas,Tipos,ExcluidoEm,ExcluidoPor")] Missao missao)
        {
            if (ModelState.IsValid)
            {
                missao.Id = Guid.NewGuid();
                _context.Add(missao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(missao);
        }

        // GET: Missaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Misao == null)
            {
                return NotFound();
            }

            var missao = await _context.Misao.FindAsync(id);
            if (missao == null)
            {
                return NotFound();
            }
            return View(missao);
        }

        // POST: Missaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,DataInicio,DataFim,Objetivo,Envolvidos,Etapas,Tipos,ExcluidoEm,ExcluidoPor")] Missao missao)
        {
            if (id != missao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(missao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MissaoExists(missao.Id))
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
            return View(missao);
        }

        // GET: Missaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Misao == null)
            {
                return NotFound();
            }

            var missao = await _context.Misao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (missao == null)
            {
                return NotFound();
            }

            return View(missao);
        }

        // POST: Missaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Misao == null)
            {
                return Problem("Entity set 'Context.Misao'  is null.");
            }
            var missao = await _context.Misao.FindAsync(id);
            if (missao != null)
            {
                _context.Misao.Remove(missao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MissaoExists(Guid id)
        {
          return _context.Misao.Any(e => e.Id == id);
        }
    }
}

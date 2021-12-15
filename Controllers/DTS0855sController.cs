using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DuThaiSon855.Models;

namespace DuThaiSon855.Controllers
{
    public class DTS0855sController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DTS0855sController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DTS0855s
        public async Task<IActionResult> Index()
        {
            return View(await _context.DTS0855.ToListAsync());
        }

        // GET: DTS0855s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTS0855 = await _context.DTS0855
                .FirstOrDefaultAsync(m => m.DTSID == id);
            if (dTS0855 == null)
            {
                return NotFound();
            }

            return View(dTS0855);
        }

        // GET: DTS0855s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DTS0855s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DTSID,DTSName,DTSGender")] DTS0855 dTS0855)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dTS0855);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dTS0855);
        }

        // GET: DTS0855s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTS0855 = await _context.DTS0855.FindAsync(id);
            if (dTS0855 == null)
            {
                return NotFound();
            }
            return View(dTS0855);
        }

        // POST: DTS0855s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DTSID,DTSName,DTSGender")] DTS0855 dTS0855)
        {
            if (id != dTS0855.DTSID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dTS0855);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DTS0855Exists(dTS0855.DTSID))
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
            return View(dTS0855);
        }

        // GET: DTS0855s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dTS0855 = await _context.DTS0855
                .FirstOrDefaultAsync(m => m.DTSID == id);
            if (dTS0855 == null)
            {
                return NotFound();
            }

            return View(dTS0855);
        }

        // POST: DTS0855s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dTS0855 = await _context.DTS0855.FindAsync(id);
            _context.DTS0855.Remove(dTS0855);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DTS0855Exists(string id)
        {
            return _context.DTS0855.Any(e => e.DTSID == id);
        }
    }
}

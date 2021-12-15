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
    public class Company_DTS855sController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Company_DTS855sController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Company_DTS855s
        public async Task<IActionResult> Index()
        {
            return View(await _context.Company_DTS855.ToListAsync());
        }

        // GET: Company_DTS855s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_DTS855 = await _context.Company_DTS855
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company_DTS855 == null)
            {
                return NotFound();
            }

            return View(company_DTS855);
        }

        // GET: Company_DTS855s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company_DTS855s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName")] Company_DTS855 company_DTS855)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company_DTS855);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(company_DTS855);
        }

        // GET: Company_DTS855s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_DTS855 = await _context.Company_DTS855.FindAsync(id);
            if (company_DTS855 == null)
            {
                return NotFound();
            }
            return View(company_DTS855);
        }

        // POST: Company_DTS855s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyID,CompanyName")] Company_DTS855 company_DTS855)
        {
            if (id != company_DTS855.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company_DTS855);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Company_DTS855Exists(company_DTS855.CompanyID))
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
            return View(company_DTS855);
        }

        // GET: Company_DTS855s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company_DTS855 = await _context.Company_DTS855
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (company_DTS855 == null)
            {
                return NotFound();
            }

            return View(company_DTS855);
        }

        // POST: Company_DTS855s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var company_DTS855 = await _context.Company_DTS855.FindAsync(id);
            _context.Company_DTS855.Remove(company_DTS855);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Company_DTS855Exists(string id)
        {
            return _context.Company_DTS855.Any(e => e.CompanyID == id);
        }
    }
}

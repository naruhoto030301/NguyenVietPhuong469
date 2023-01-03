using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVietPhuong469.Data;
using NguyenVietPhuong469.Models;

namespace NguyenVietPhuong469.Controllers
{
    public class CompanyNVP469Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyNVP469Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNVP469
        public async Task<IActionResult> Index()
        {
              return View(await _context.CompanyNVP469s.ToListAsync());
        }

        // GET: CompanyNVP469/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CompanyNVP469s == null)
            {
                return NotFound();
            }

            var companyNVP469 = await _context.CompanyNVP469s
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNVP469 == null)
            {
                return NotFound();
            }

            return View(companyNVP469);
        }

        // GET: CompanyNVP469/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNVP469/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNVP469 companyNVP469)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNVP469);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNVP469);
        }

        // GET: CompanyNVP469/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CompanyNVP469s == null)
            {
                return NotFound();
            }

            var companyNVP469 = await _context.CompanyNVP469s.FindAsync(id);
            if (companyNVP469 == null)
            {
                return NotFound();
            }
            return View(companyNVP469);
        }

        // POST: CompanyNVP469/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,CompanyName")] CompanyNVP469 companyNVP469)
        {
            if (id != companyNVP469.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNVP469);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNVP469Exists(companyNVP469.CompanyId))
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
            return View(companyNVP469);
        }

        // GET: CompanyNVP469/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CompanyNVP469s == null)
            {
                return NotFound();
            }

            var companyNVP469 = await _context.CompanyNVP469s
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNVP469 == null)
            {
                return NotFound();
            }

            return View(companyNVP469);
        }

        // POST: CompanyNVP469/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CompanyNVP469s == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CompanyNVP469s'  is null.");
            }
            var companyNVP469 = await _context.CompanyNVP469s.FindAsync(id);
            if (companyNVP469 != null)
            {
                _context.CompanyNVP469s.Remove(companyNVP469);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNVP469Exists(int id)
        {
          return _context.CompanyNVP469s.Any(e => e.CompanyId == id);
        }
    }
}

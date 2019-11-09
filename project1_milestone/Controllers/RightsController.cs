using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project1_milestone.Data;
using project1_milestone.Models.Right;

namespace project1_milestone.Controllers
{
    public class RightsController : Controller
    {
        private readonly DBContext _context;

        public RightsController(DBContext context)
        {
            _context = context;
        }

        // GET: Rights
        public async Task<IActionResult> Index()
        {
            return View(await _context.Right.ToListAsync());
        }

        // GET: Rights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var right = await _context.Right
                .FirstOrDefaultAsync(m => m.Id == id);
            if (right == null)
            {
                return NotFound();
            }

            return View(right);
        }

        // GET: Rights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name")] Right right)
        {
            if (ModelState.IsValid)
            {
                _context.Add(right);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(right);
        }

        // GET: Rights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var right = await _context.Right.FindAsync(id);
            if (right == null)
            {
                return NotFound();
            }
            return View(right);
        }

        // POST: Rights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name")] Right right)
        {
            if (id != right.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(right);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RightExists(right.Id))
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
            return View(right);
        }

        // GET: Rights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var right = await _context.Right
                .FirstOrDefaultAsync(m => m.Id == id);
            if (right == null)
            {
                return NotFound();
            }

            return View(right);
        }

        // POST: Rights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var right = await _context.Right.FindAsync(id);
            _context.Right.Remove(right);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RightExists(int id)
        {
            return _context.Right.Any(e => e.Id == id);
        }
    }
}

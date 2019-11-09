using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project1_milestone.Data;
using project1_milestone.Models.UserRoleMap;

namespace project1_milestone.Controllers
{
    public class UserRoleMapsController : Controller
    {
        private readonly DBContext _context;

        public UserRoleMapsController(DBContext context)
        {
            _context = context;
        }

        // GET: UserRoleMaps
        public async Task<IActionResult> Index()
        {
            var dBContext = _context.UserRoleMap.Include(u => u.Role).Include(u => u.User);
            return View(await dBContext.ToListAsync());
        }

        // GET: UserRoleMaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleMap == null)
            {
                return NotFound();
            }

            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Name");
            return View();
        }

        // POST: UserRoleMaps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,RoleId")] UserRoleMap userRoleMap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRoleMap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", userRoleMap.RoleId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userRoleMap.UserId);
            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap.FindAsync(id);
            if (userRoleMap == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", userRoleMap.RoleId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userRoleMap.UserId);
            return View(userRoleMap);
        }

        // POST: UserRoleMaps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,RoleId")] UserRoleMap userRoleMap)
        {
            if (id != userRoleMap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRoleMap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRoleMapExists(userRoleMap.Id))
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
            ViewData["RoleId"] = new SelectList(_context.Role, "Id", "Id", userRoleMap.RoleId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", userRoleMap.UserId);
            return View(userRoleMap);
        }

        // GET: UserRoleMaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userRoleMap = await _context.UserRoleMap
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userRoleMap == null)
            {
                return NotFound();
            }

            return View(userRoleMap);
        }

        // POST: UserRoleMaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userRoleMap = await _context.UserRoleMap.FindAsync(id);
            _context.UserRoleMap.Remove(userRoleMap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRoleMapExists(int id)
        {
            return _context.UserRoleMap.Any(e => e.Id == id);
        }
    }
}

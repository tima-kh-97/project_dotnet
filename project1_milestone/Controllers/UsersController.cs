using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project1_milestone.Data;
using project1_milestone.Models.User;
using project1_milestone.Services;

namespace project1_milestone.Controllers
{
    public class UsersController : Controller
    {

        private UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(_usersService.GetUsersList());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _usersService.GetDetails(id);

            if (user == null)
            {
                return NotFound();
            }

            HttpContext.Session.SetString("user", "Hello! " + user.Surname + " " + user.Name);
            ViewData["myUser"] = HttpContext.Session.GetString("user");
            TempData["user"] = user.IDN;

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Middlename,IDN,Phone,Email,Nationality,Birthday,Password")] User user)
        {

            if (ModelState.IsValid)
            {
                _usersService.Create(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        [AllowAnonymous]
        [AcceptVerbs("GET","POST")]
        public async Task<ActionResult> VerifyForExistence(string Phone)
        {
            var user = await _usersService.VerifyForExistence(Phone);
            if (user != null)
            {
                return Json("This phone number was registered before!");
            } 

            return Json(true);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _usersService.Edit(id);

            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Middlename,Phone,Email,Nationality,Birthday")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _usersService.Edit(user);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _usersService.Delete(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             _usersService.DeleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _usersService.UserExists(id);
        }
    }
}

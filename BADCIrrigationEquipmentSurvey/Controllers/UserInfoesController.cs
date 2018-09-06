using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models;


namespace BADCIrrigationEquipmentSurvey.Controllers
{
    public class UserInfoesController : Controller
    {
        private readonly UserDbContext _context;

        public UserInfoesController(UserDbContext context)
        {
            _context = context;
        }

        // GET: BadcAppUseres
        public async Task<IActionResult> Index()
        {
            return View(await _context.BadcAppUseres.ToListAsync());
        }

        // GET: BadcAppUseres/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoes = await _context.BadcAppUseres
                .SingleOrDefaultAsync(m => m.Id == id);
            if (userInfoes == null)
            {
                return NotFound();
            }

            return View(userInfoes);
        }

        // GET: UserInfoeses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInfoeses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Password,ConfirmPassword,Name,Designation,MobileNo,CreatedBy,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] BadcAppUser userInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(userInfo);
        }

        // GET: UserInfoeses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfo = await _context.BadcAppUseres.SingleOrDefaultAsync(m => m.Id == id);
            if (userInfo == null)
            {
                return NotFound();
            }

            return View(userInfo);
        }

        // POST: BadcAppUseres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserId,Password,ConfirmPassword,Name,Designation,MobileNo,CreatedBy,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] BadcAppUser userInfo)
        {
            if (id != userInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoesExists(userInfo.Id))
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

            return View(userInfo);
        }

        // GET: UserInfoeses/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoes = await _context.BadcAppUseres
                .SingleOrDefaultAsync(m => m.Id == id);
            if (userInfoes == null)
            {
                return NotFound();
            }

            return View(userInfoes);
        }

        // POST: UserInfoeses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userInfo = await _context.BadcAppUseres.SingleOrDefaultAsync(m => m.Id == id);
            _context.BadcAppUseres.Remove(userInfo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool UserInfoesExists(string id)
        {
            return _context.BadcAppUseres.Any(e => e.Id == id);
        }
    }
}

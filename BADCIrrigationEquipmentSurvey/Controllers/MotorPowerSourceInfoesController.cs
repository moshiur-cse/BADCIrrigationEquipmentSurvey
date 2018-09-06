using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models.DataModels;


namespace BADCIrrigationEquipmentSurvey.Controllers
{
    public class MotorPowerSourceInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public MotorPowerSourceInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: MotorPowerSourceInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MotorPowerSourceInfoes.ToListAsync());
        }

        // GET: MotorPowerSourceInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorPowerSourceInfo = await _context.MotorPowerSourceInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (motorPowerSourceInfo == null)
            {
                return NotFound();
            }

            return View(motorPowerSourceInfo);
        }

        // GET: MotorPowerSourceInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotorPowerSourceInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,ElectricMotorSourceOfPower")] MotorPowerSourceInfo motorPowerSourceInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorPowerSourceInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motorPowerSourceInfo);
        }

        // GET: MotorPowerSourceInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorPowerSourceInfo = await _context.MotorPowerSourceInfoes.SingleOrDefaultAsync(m => m.Code == id);
            if (motorPowerSourceInfo == null)
            {
                return NotFound();
            }
            return View(motorPowerSourceInfo);
        }

        // POST: MotorPowerSourceInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,ElectricMotorSourceOfPower")] MotorPowerSourceInfo motorPowerSourceInfo)
        {
            if (id != motorPowerSourceInfo.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorPowerSourceInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorPowerSourceInfoExists(motorPowerSourceInfo.Code))
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
            return View(motorPowerSourceInfo);
        }

        // GET: MotorPowerSourceInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorPowerSourceInfo = await _context.MotorPowerSourceInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (motorPowerSourceInfo == null)
            {
                return NotFound();
            }

            return View(motorPowerSourceInfo);
        }

        // POST: MotorPowerSourceInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motorPowerSourceInfo = await _context.MotorPowerSourceInfoes.SingleOrDefaultAsync(m => m.Code == id);
            _context.MotorPowerSourceInfoes.Remove(motorPowerSourceInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorPowerSourceInfoExists(int id)
        {
            return _context.MotorPowerSourceInfoes.Any(e => e.Code == id);
        }
    }
}

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
    public class EquipmentInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public EquipmentInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: EquipmentInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.EquipmentInfoes.Include(e => e.EquipmentTypeInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: EquipmentInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentInfo = await _context.EquipmentInfoes
                .Include(e => e.EquipmentTypeInfo)
                .FirstOrDefaultAsync(m => m.EquipmentId == id);
            if (equipmentInfo == null)
            {
                return NotFound();
            }

            return View(equipmentInfo);
        }

        // GET: EquipmentInfoes/Create
        public IActionResult Create()
        {
            ViewData["EquipmentTypeId"] = new SelectList(_context.EquipmentTypeInfoes, "EquipmentTypeId", "EquipmentType");
            return View();
        }

        // POST: EquipmentInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipmentId,EquipmentTypeId,NameOfEquipment")] EquipmentInfo equipmentInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentTypeId"] = new SelectList(_context.EquipmentTypeInfoes, "EquipmentTypeId", "EquipmentType", equipmentInfo.EquipmentTypeId);
            return View(equipmentInfo);
        }

        // GET: EquipmentInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentInfo = await _context.EquipmentInfoes.FindAsync(id);
            if (equipmentInfo == null)
            {
                return NotFound();
            }
            ViewData["EquipmentTypeId"] = new SelectList(_context.EquipmentTypeInfoes, "EquipmentTypeId", "EquipmentType", equipmentInfo.EquipmentTypeId);
            return View(equipmentInfo);
        }

        // POST: EquipmentInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipmentId,EquipmentTypeId,NameOfEquipment")] EquipmentInfo equipmentInfo)
        {
            if (id != equipmentInfo.EquipmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentInfoExists(equipmentInfo.EquipmentId))
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
            ViewData["EquipmentTypeId"] = new SelectList(_context.EquipmentTypeInfoes, "EquipmentTypeId", "EquipmentType", equipmentInfo.EquipmentTypeId);
            return View(equipmentInfo);
        }

        // GET: EquipmentInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentInfo = await _context.EquipmentInfoes
                .Include(e => e.EquipmentTypeInfo)
                .FirstOrDefaultAsync(m => m.EquipmentId == id);
            if (equipmentInfo == null)
            {
                return NotFound();
            }

            return View(equipmentInfo);
        }

        // POST: EquipmentInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentInfo = await _context.EquipmentInfoes.FindAsync(id);
            _context.EquipmentInfoes.Remove(equipmentInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentInfoExists(int id)
        {
            return _context.EquipmentInfoes.Any(e => e.EquipmentId == id);
        }
    }
}

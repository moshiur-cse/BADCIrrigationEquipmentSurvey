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
    public class EquipmentTypeInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public EquipmentTypeInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: EquipmentTypeInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EquipmentTypeInfoes.ToListAsync());
        }

        // GET: EquipmentTypeInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentTypeInfo = await _context.EquipmentTypeInfoes
                .FirstOrDefaultAsync(m => m.EquipmentTypeId == id);
            if (equipmentTypeInfo == null)
            {
                return NotFound();
            }

            return View(equipmentTypeInfo);
        }

        // GET: EquipmentTypeInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EquipmentTypeInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipmentTypeId,EquipmentType")] EquipmentTypeInfo equipmentTypeInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentTypeInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipmentTypeInfo);
        }

        // GET: EquipmentTypeInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentTypeInfo = await _context.EquipmentTypeInfoes.FindAsync(id);
            if (equipmentTypeInfo == null)
            {
                return NotFound();
            }
            return View(equipmentTypeInfo);
        }

        // POST: EquipmentTypeInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipmentTypeId,EquipmentType")] EquipmentTypeInfo equipmentTypeInfo)
        {
            if (id != equipmentTypeInfo.EquipmentTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentTypeInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentTypeInfoExists(equipmentTypeInfo.EquipmentTypeId))
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
            return View(equipmentTypeInfo);
        }

        // GET: EquipmentTypeInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentTypeInfo = await _context.EquipmentTypeInfoes
                .FirstOrDefaultAsync(m => m.EquipmentTypeId == id);
            if (equipmentTypeInfo == null)
            {
                return NotFound();
            }

            return View(equipmentTypeInfo);
        }

        // POST: EquipmentTypeInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentTypeInfo = await _context.EquipmentTypeInfoes.FindAsync(id);
            _context.EquipmentTypeInfoes.Remove(equipmentTypeInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentTypeInfoExists(int id)
        {
            return _context.EquipmentTypeInfoes.Any(e => e.EquipmentTypeId == id);
        }
    }
}

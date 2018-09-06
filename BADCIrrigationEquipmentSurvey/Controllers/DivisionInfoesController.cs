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
    public class DivisionInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public DivisionInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: DivisionInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DivisionInfoes.ToListAsync());
        }

        // GET: DivisionInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisionInfo = await _context.DivisionInfoes
                .SingleOrDefaultAsync(m => m.DivCode == id);
            if (divisionInfo == null)
            {
                return NotFound();
            }

            return View(divisionInfo);
        }

        // GET: DivisionInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DivisionInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DivCode,DivName")] DivisionInfo divisionInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(divisionInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(divisionInfo);
        }

        // GET: DivisionInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisionInfo = await _context.DivisionInfoes.SingleOrDefaultAsync(m => m.DivCode == id);
            if (divisionInfo == null)
            {
                return NotFound();
            }
            return View(divisionInfo);
        }

        // POST: DivisionInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DivCode,DivName")] DivisionInfo divisionInfo)
        {
            if (id != divisionInfo.DivCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divisionInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivisionInfoExists(divisionInfo.DivCode))
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
            return View(divisionInfo);
        }

        // GET: DivisionInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisionInfo = await _context.DivisionInfoes
                .SingleOrDefaultAsync(m => m.DivCode == id);
            if (divisionInfo == null)
            {
                return NotFound();
            }

            return View(divisionInfo);
        }

        // POST: DivisionInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var divisionInfo = await _context.DivisionInfoes.SingleOrDefaultAsync(m => m.DivCode == id);
            _context.DivisionInfoes.Remove(divisionInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivisionInfoExists(string id)
        {
            return _context.DivisionInfoes.Any(e => e.DivCode == id);
        }
    }
}

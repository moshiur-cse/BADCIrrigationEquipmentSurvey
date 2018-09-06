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
    public class DistrictInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public DistrictInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: DistrictInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.DistrictInfoes.Include(d => d.DivisionInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: DistrictInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var districtInfo = await _context.DistrictInfoes
                .Include(d => d.DivisionInfo)
                .SingleOrDefaultAsync(m => m.DistCode == id);
            if (districtInfo == null)
            {
                return NotFound();
            }

            return View(districtInfo);
        }

        // GET: DistrictInfoes/Create
        public IActionResult Create()
        {
            ViewData["DivCode"] = new SelectList(_context.DivisionInfoes, "DivCode", "DivCode");
            return View();
        }

        // POST: DistrictInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistCode,DistName,DivCode")] DistrictInfo districtInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(districtInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DivCode"] = new SelectList(_context.DivisionInfoes, "DivCode", "DivCode", districtInfo.DivCode);
            return View(districtInfo);
        }

        // GET: DistrictInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var districtInfo = await _context.DistrictInfoes.SingleOrDefaultAsync(m => m.DistCode == id);
            if (districtInfo == null)
            {
                return NotFound();
            }
            ViewData["DivCode"] = new SelectList(_context.DivisionInfoes, "DivCode", "DivCode", districtInfo.DivCode);
            return View(districtInfo);
        }

        // POST: DistrictInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DistCode,DistName,DivCode")] DistrictInfo districtInfo)
        {
            if (id != districtInfo.DistCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(districtInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DistrictInfoExists(districtInfo.DistCode))
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
            ViewData["DivCode"] = new SelectList(_context.DivisionInfoes, "DivCode", "DivCode", districtInfo.DivCode);
            return View(districtInfo);
        }

        // GET: DistrictInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var districtInfo = await _context.DistrictInfoes
                .Include(d => d.DivisionInfo)
                .SingleOrDefaultAsync(m => m.DistCode == id);
            if (districtInfo == null)
            {
                return NotFound();
            }

            return View(districtInfo);
        }

        // POST: DistrictInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var districtInfo = await _context.DistrictInfoes.SingleOrDefaultAsync(m => m.DistCode == id);
            _context.DistrictInfoes.Remove(districtInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DistrictInfoExists(string id)
        {
            return _context.DistrictInfoes.Any(e => e.DistCode == id);
        }
    }
}

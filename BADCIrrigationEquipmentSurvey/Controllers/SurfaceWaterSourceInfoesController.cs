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
    public class SurfaceWaterSourceInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public SurfaceWaterSourceInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: SurfaceWaterSourceInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SurfaceWaterSourceInfoes.ToListAsync());
        }

        // GET: SurfaceWaterSourceInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfaceWaterSourceInfo = await _context.SurfaceWaterSourceInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (surfaceWaterSourceInfo == null)
            {
                return NotFound();
            }

            return View(surfaceWaterSourceInfo);
        }

        // GET: SurfaceWaterSourceInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SurfaceWaterSourceInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,SourceOfSurfaceWater")] SurfaceWaterSourceInfo surfaceWaterSourceInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surfaceWaterSourceInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(surfaceWaterSourceInfo);
        }

        // GET: SurfaceWaterSourceInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfaceWaterSourceInfo = await _context.SurfaceWaterSourceInfoes.SingleOrDefaultAsync(m => m.Code == id);
            if (surfaceWaterSourceInfo == null)
            {
                return NotFound();
            }
            return View(surfaceWaterSourceInfo);
        }

        // POST: SurfaceWaterSourceInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,SourceOfSurfaceWater")] SurfaceWaterSourceInfo surfaceWaterSourceInfo)
        {
            if (id != surfaceWaterSourceInfo.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surfaceWaterSourceInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfaceWaterSourceInfoExists(surfaceWaterSourceInfo.Code))
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
            return View(surfaceWaterSourceInfo);
        }

        // GET: SurfaceWaterSourceInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surfaceWaterSourceInfo = await _context.SurfaceWaterSourceInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (surfaceWaterSourceInfo == null)
            {
                return NotFound();
            }

            return View(surfaceWaterSourceInfo);
        }

        // POST: SurfaceWaterSourceInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surfaceWaterSourceInfo = await _context.SurfaceWaterSourceInfoes.SingleOrDefaultAsync(m => m.Code == id);
            _context.SurfaceWaterSourceInfoes.Remove(surfaceWaterSourceInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfaceWaterSourceInfoExists(int id)
        {
            return _context.SurfaceWaterSourceInfoes.Any(e => e.Code == id);
        }
    }
}

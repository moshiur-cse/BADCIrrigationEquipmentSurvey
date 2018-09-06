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
    public class CropInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public CropInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: CropInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.CropInfoes.Include(c => c.SeasonInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: CropInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropInfo = await _context.CropInfoes
                .Include(c => c.SeasonInfo)
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (cropInfo == null)
            {
                return NotFound();
            }

            return View(cropInfo);
        }

        // GET: CropInfoes/Create
        public IActionResult Create()
        {
            ViewData["SeasonId"] = new SelectList(_context.SeasonInfoes, "SeasonId", "SeasonName");
            return View();
        }

        // POST: CropInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CropId,SeasonId,CropName")] CropInfo cropInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cropInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SeasonId"] = new SelectList(_context.SeasonInfoes, "SeasonId", "SeasonName", cropInfo.SeasonId);
            return View(cropInfo);
        }

        // GET: CropInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropInfo = await _context.CropInfoes.FindAsync(id);
            if (cropInfo == null)
            {
                return NotFound();
            }
            ViewData["SeasonId"] = new SelectList(_context.SeasonInfoes, "SeasonId", "SeasonName", cropInfo.SeasonId);
            return View(cropInfo);
        }

        // POST: CropInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CropId,SeasonId,CropName")] CropInfo cropInfo)
        {
            if (id != cropInfo.CropId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cropInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CropInfoExists(cropInfo.CropId))
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
            ViewData["SeasonId"] = new SelectList(_context.SeasonInfoes, "SeasonId", "SeasonName", cropInfo.SeasonId);
            return View(cropInfo);
        }

        // GET: CropInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cropInfo = await _context.CropInfoes
                .Include(c => c.SeasonInfo)
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (cropInfo == null)
            {
                return NotFound();
            }

            return View(cropInfo);
        }

        // POST: CropInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cropInfo = await _context.CropInfoes.FindAsync(id);
            _context.CropInfoes.Remove(cropInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CropInfoExists(int id)
        {
            return _context.CropInfoes.Any(e => e.CropId == id);
        }
    }
}

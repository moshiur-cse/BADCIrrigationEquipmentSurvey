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
    public class SeasonInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public SeasonInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: SeasonInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SeasonInfoes.ToListAsync());
        }

        // GET: SeasonInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seasonInfo = await _context.SeasonInfoes
                .FirstOrDefaultAsync(m => m.SeasonId == id);
            if (seasonInfo == null)
            {
                return NotFound();
            }

            return View(seasonInfo);
        }

        // GET: SeasonInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SeasonInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SeasonId,SeasonName")] SeasonInfo seasonInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seasonInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seasonInfo);
        }

        // GET: SeasonInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seasonInfo = await _context.SeasonInfoes.FindAsync(id);
            if (seasonInfo == null)
            {
                return NotFound();
            }
            return View(seasonInfo);
        }

        // POST: SeasonInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SeasonId,SeasonName")] SeasonInfo seasonInfo)
        {
            if (id != seasonInfo.SeasonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seasonInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeasonInfoExists(seasonInfo.SeasonId))
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
            return View(seasonInfo);
        }

        // GET: SeasonInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seasonInfo = await _context.SeasonInfoes
                .FirstOrDefaultAsync(m => m.SeasonId == id);
            if (seasonInfo == null)
            {
                return NotFound();
            }

            return View(seasonInfo);
        }

        // POST: SeasonInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seasonInfo = await _context.SeasonInfoes.FindAsync(id);
            _context.SeasonInfoes.Remove(seasonInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeasonInfoExists(int id)
        {
            return _context.SeasonInfoes.Any(e => e.SeasonId == id);
        }
    }
}

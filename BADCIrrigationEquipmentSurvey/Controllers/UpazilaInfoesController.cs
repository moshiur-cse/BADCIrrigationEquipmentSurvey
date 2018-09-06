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
    public class UpazilaInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public UpazilaInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: UpazilaInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.UpazilaInfoes.Include(u => u.DistrictInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: UpazilaInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upazilaInfo = await _context.UpazilaInfoes
                .Include(u => u.DistrictInfo)
                .SingleOrDefaultAsync(m => m.UpazCode == id);
            if (upazilaInfo == null)
            {
                return NotFound();
            }

            return View(upazilaInfo);
        }

        // GET: UpazilaInfoes/Create
        public IActionResult Create()
        {
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode");
            return View();
        }

        // POST: UpazilaInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UpazCode,UpazName,DistCode")] UpazilaInfo upazilaInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(upazilaInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", upazilaInfo.DistCode);
            return View(upazilaInfo);
        }

        // GET: UpazilaInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upazilaInfo = await _context.UpazilaInfoes.SingleOrDefaultAsync(m => m.UpazCode == id);
            if (upazilaInfo == null)
            {
                return NotFound();
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", upazilaInfo.DistCode);
            return View(upazilaInfo);
        }

        // POST: UpazilaInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UpazCode,UpazName,DistCode")] UpazilaInfo upazilaInfo)
        {
            if (id != upazilaInfo.UpazCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upazilaInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpazilaInfoExists(upazilaInfo.UpazCode))
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
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", upazilaInfo.DistCode);
            return View(upazilaInfo);
        }

        // GET: UpazilaInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upazilaInfo = await _context.UpazilaInfoes
                .Include(u => u.DistrictInfo)
                .SingleOrDefaultAsync(m => m.UpazCode == id);
            if (upazilaInfo == null)
            {
                return NotFound();
            }

            return View(upazilaInfo);
        }

        // POST: UpazilaInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var upazilaInfo = await _context.UpazilaInfoes.SingleOrDefaultAsync(m => m.UpazCode == id);
            _context.UpazilaInfoes.Remove(upazilaInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpazilaInfoExists(string id)
        {
            return _context.UpazilaInfoes.Any(e => e.UpazCode == id);
        }
    }
}

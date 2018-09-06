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
    public class UnionInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public UnionInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: UnionInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.UnionInfoes.Include(u => u.DistrictInfo).Include(u => u.UpazilaInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: UnionInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionInfo = await _context.UnionInfoes
                .Include(u => u.DistrictInfo)
                .Include(u => u.UpazilaInfo)
                .SingleOrDefaultAsync(m => m.UnionCode == id);
            if (unionInfo == null)
            {
                return NotFound();
            }

            return View(unionInfo);
        }

        // GET: UnionInfoes/Create
        public IActionResult Create()
        {
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode");
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode");
            return View();
        }

        // POST: UnionInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UnionCode,UnionName,DistCode,UpazCode")] UnionInfo unionInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unionInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", unionInfo.DistCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", unionInfo.UpazCode);
            return View(unionInfo);
        }

        // GET: UnionInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionInfo = await _context.UnionInfoes.SingleOrDefaultAsync(m => m.UnionCode == id);
            if (unionInfo == null)
            {
                return NotFound();
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", unionInfo.DistCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", unionInfo.UpazCode);
            return View(unionInfo);
        }

        // POST: UnionInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UnionCode,UnionName,DistCode,UpazCode")] UnionInfo unionInfo)
        {
            if (id != unionInfo.UnionCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unionInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnionInfoExists(unionInfo.UnionCode))
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
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", unionInfo.DistCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", unionInfo.UpazCode);
            return View(unionInfo);
        }

        // GET: UnionInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionInfo = await _context.UnionInfoes
                .Include(u => u.DistrictInfo)
                .Include(u => u.UpazilaInfo)
                .SingleOrDefaultAsync(m => m.UnionCode == id);
            if (unionInfo == null)
            {
                return NotFound();
            }

            return View(unionInfo);
        }

        // POST: UnionInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var unionInfo = await _context.UnionInfoes.SingleOrDefaultAsync(m => m.UnionCode == id);
            _context.UnionInfoes.Remove(unionInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnionInfoExists(string id)
        {
            return _context.UnionInfoes.Any(e => e.UnionCode == id);
        }
    }
}

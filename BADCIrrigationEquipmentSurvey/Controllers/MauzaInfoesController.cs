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
    public class MauzaInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public MauzaInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: MauzaInfoes
        public async Task<IActionResult> Index()
        {
            //var badcDbContext = _context.MauzaInfoes.Include(m => m.DistrictInfo).Include(m => m.UnionInfo).Include(m => m.UpazilaInfo);
            var badcDbContext = _context.MauzaInfoes.Take(2500).Include(m => m.DistrictInfo).Include(m => m.UnionInfo).Include(m => m.UpazilaInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: MauzaInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mauzaInfo = await _context.MauzaInfoes
                .Include(m => m.DistrictInfo)
                .Include(m => m.UnionInfo)
                .Include(m => m.UpazilaInfo)
                .SingleOrDefaultAsync(m => m.MauzaCode == id);
            if (mauzaInfo == null)
            {
                return NotFound();
            }

            return View(mauzaInfo);
        }

        // GET: MauzaInfoes/Create
        public IActionResult Create()
        {
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode");
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode");
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode");
            return View();
        }

        // POST: MauzaInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MauzaCode,MauzaName,MauzaJlNo,DistCode,UpazCode,UnionCode")] MauzaInfo mauzaInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mauzaInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", mauzaInfo.DistCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", mauzaInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", mauzaInfo.UpazCode);
            return View(mauzaInfo);
        }

        // GET: MauzaInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mauzaInfo = await _context.MauzaInfoes.SingleOrDefaultAsync(m => m.MauzaCode == id);
            if (mauzaInfo == null)
            {
                return NotFound();
            }
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", mauzaInfo.DistCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", mauzaInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", mauzaInfo.UpazCode);
            return View(mauzaInfo);
        }

        // POST: MauzaInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MauzaCode,MauzaName,MauzaJlNo,DistCode,UpazCode,UnionCode")] MauzaInfo mauzaInfo)
        {
            if (id != mauzaInfo.MauzaCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mauzaInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MauzaInfoExists(mauzaInfo.MauzaCode))
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
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", mauzaInfo.DistCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", mauzaInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", mauzaInfo.UpazCode);
            return View(mauzaInfo);
        }

        // GET: MauzaInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mauzaInfo = await _context.MauzaInfoes
                .Include(m => m.DistrictInfo)
                .Include(m => m.UnionInfo)
                .Include(m => m.UpazilaInfo)
                .SingleOrDefaultAsync(m => m.MauzaCode == id);
            if (mauzaInfo == null)
            {
                return NotFound();
            }

            return View(mauzaInfo);
        }

        // POST: MauzaInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var mauzaInfo = await _context.MauzaInfoes.SingleOrDefaultAsync(m => m.MauzaCode == id);
            _context.MauzaInfoes.Remove(mauzaInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MauzaInfoExists(string id)
        {
            return _context.MauzaInfoes.Any(e => e.MauzaCode == id);
        }
    }
}

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
    public class AgencyInfoesController : Controller
    {
        private readonly BadcDbContext _context;

        public AgencyInfoesController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: AgencyInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgencyInfoes.ToListAsync());
        }

        // GET: AgencyInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencyInfo = await _context.AgencyInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (agencyInfo == null)
            {
                return NotFound();
            }

            return View(agencyInfo);
        }

        // GET: AgencyInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgencyInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,NameOfAgency")] AgencyInfo agencyInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agencyInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agencyInfo);
        }

        // GET: AgencyInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencyInfo = await _context.AgencyInfoes.SingleOrDefaultAsync(m => m.Code == id);
            if (agencyInfo == null)
            {
                return NotFound();
            }
            return View(agencyInfo);
        }

        // POST: AgencyInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,NameOfAgency")] AgencyInfo agencyInfo)
        {
            if (id != agencyInfo.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agencyInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgencyInfoExists(agencyInfo.Code))
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
            return View(agencyInfo);
        }

        // GET: AgencyInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agencyInfo = await _context.AgencyInfoes
                .SingleOrDefaultAsync(m => m.Code == id);
            if (agencyInfo == null)
            {
                return NotFound();
            }

            return View(agencyInfo);
        }

        // POST: AgencyInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agencyInfo = await _context.AgencyInfoes.SingleOrDefaultAsync(m => m.Code == id);
            _context.AgencyInfoes.Remove(agencyInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgencyInfoExists(int id)
        {
            return _context.AgencyInfoes.Any(e => e.Code == id);
        }
    }
}

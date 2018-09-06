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
    public class Kharif2SurveyInfoController : Controller
    {
        private readonly BadcDbContext _context;

        public Kharif2SurveyInfoController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: Kharif2SurveyInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kharif2SurveyInfo.ToListAsync());
        }

        // GET: Kharif2SurveyInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif2SurveyInfo = await _context.Kharif2SurveyInfo
                .FirstOrDefaultAsync(m => m.SurveyKharif1Id == id);
            if (kharif2SurveyInfo == null)
            {
                return NotFound();
            }

            return View(kharif2SurveyInfo);
        }

        // GET: Kharif2SurveyInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kharif2SurveyInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyKharif1Id,TotalOperatingHour,TAmanArea,OthersArea,TAmanCost,OthersCost,BenefitedFarmerMale,BenefitedAgricultureLabourMale")] Kharif2SurveyInfo kharif2SurveyInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kharif2SurveyInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kharif2SurveyInfo);
        }

        // GET: Kharif2SurveyInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif2SurveyInfo = await _context.Kharif2SurveyInfo.FindAsync(id);
            if (kharif2SurveyInfo == null)
            {
                return NotFound();
            }
            return View(kharif2SurveyInfo);
        }

        // POST: Kharif2SurveyInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyKharif1Id,TotalOperatingHour,TAmanArea,OthersArea,TAmanCost,OthersCost,BenefitedFarmerMale,BenefitedAgricultureLabourMale")] Kharif2SurveyInfo kharif2SurveyInfo)
        {
            if (id != kharif2SurveyInfo.SurveyKharif1Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kharif2SurveyInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Kharif2SurveyInfoExists(kharif2SurveyInfo.SurveyKharif1Id))
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
            return View(kharif2SurveyInfo);
        }

        // GET: Kharif2SurveyInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif2SurveyInfo = await _context.Kharif2SurveyInfo
                .FirstOrDefaultAsync(m => m.SurveyKharif1Id == id);
            if (kharif2SurveyInfo == null)
            {
                return NotFound();
            }

            return View(kharif2SurveyInfo);
        }

        // POST: Kharif2SurveyInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kharif2SurveyInfo = await _context.Kharif2SurveyInfo.FindAsync(id);
            _context.Kharif2SurveyInfo.Remove(kharif2SurveyInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Kharif2SurveyInfoExists(int id)
        {
            return _context.Kharif2SurveyInfo.Any(e => e.SurveyKharif1Id == id);
        }
    }
}

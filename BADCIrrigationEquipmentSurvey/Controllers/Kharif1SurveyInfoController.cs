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
    public class Kharif1SurveyInfoController : Controller
    {
        private readonly BadcDbContext _context;

        public Kharif1SurveyInfoController(BadcDbContext context)
        {
            _context = context;
        }

        // GET: Kharif1SurveyInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kharif1SurveyInfo.ToListAsync());
        }

        // GET: Kharif1SurveyInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif1SurveyInfo = await _context.Kharif1SurveyInfo
                .FirstOrDefaultAsync(m => m.SurveyKharif1Id == id);
            if (kharif1SurveyInfo == null)
            {
                return NotFound();
            }

            return View(kharif1SurveyInfo);
        }

        // GET: Kharif1SurveyInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kharif1SurveyInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyKharif1Id,TotalOperatingHour,AusArea,JuteArea,VegArea,OthersArea,AusCost,JuteCost,VegCost,OthersCost,BenefitedFarmerMale,BenefitedAgricultureLabourMale,UseInKharif2Season")] Kharif1SurveyInfo kharif1SurveyInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kharif1SurveyInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kharif1SurveyInfo);
        }

        // GET: Kharif1SurveyInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif1SurveyInfo = await _context.Kharif1SurveyInfo.FindAsync(id);
            if (kharif1SurveyInfo == null)
            {
                return NotFound();
            }
            return View(kharif1SurveyInfo);
        }

        // POST: Kharif1SurveyInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyKharif1Id,TotalOperatingHour,AusArea,JuteArea,VegArea,OthersArea,AusCost,JuteCost,VegCost,OthersCost,BenefitedFarmerMale,BenefitedAgricultureLabourMale,UseInKharif2Season")] Kharif1SurveyInfo kharif1SurveyInfo)
        {
            if (id != kharif1SurveyInfo.SurveyKharif1Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kharif1SurveyInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Kharif1SurveyInfoExists(kharif1SurveyInfo.SurveyKharif1Id))
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
            return View(kharif1SurveyInfo);
        }

        // GET: Kharif1SurveyInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kharif1SurveyInfo = await _context.Kharif1SurveyInfo
                .FirstOrDefaultAsync(m => m.SurveyKharif1Id == id);
            if (kharif1SurveyInfo == null)
            {
                return NotFound();
            }

            return View(kharif1SurveyInfo);
        }

        // POST: Kharif1SurveyInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kharif1SurveyInfo = await _context.Kharif1SurveyInfo.FindAsync(id);
            _context.Kharif1SurveyInfo.Remove(kharif1SurveyInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Kharif1SurveyInfoExists(int id)
        {
            return _context.Kharif1SurveyInfo.Any(e => e.SurveyKharif1Id == id);
        }
    }
}

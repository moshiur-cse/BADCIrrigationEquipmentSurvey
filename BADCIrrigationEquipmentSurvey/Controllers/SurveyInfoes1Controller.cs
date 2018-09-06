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
    public class SurveyInfoes1Controller : Controller
    {
        private readonly BadcDbContext _context;

        public SurveyInfoes1Controller(BadcDbContext context)
        {
            _context = context;
        }

        // GET: SurveyInfoes1
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _context.SurveyInfoes.Include(s => s.AgencyInfo).Include(s => s.DistrictInfo).Include(s => s.ElectricMotorPowerSourceInfo).Include(s => s.EquipmentInfo).Include(s => s.SurfaceWaterSourceInfo).Include(s => s.UnionInfo).Include(s => s.UpazilaInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: SurveyInfoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _context.SurveyInfoes
                .Include(s => s.AgencyInfo)
                .Include(s => s.DistrictInfo)
                .Include(s => s.ElectricMotorPowerSourceInfo)
                .Include(s => s.EquipmentInfo)
                .Include(s => s.SurfaceWaterSourceInfo)
                .Include(s => s.UnionInfo)
                .Include(s => s.UpazilaInfo)
                .FirstOrDefaultAsync(m => m.SurveyId == id);

            if (surveyInfo == null)
            {
                return NotFound();
            }

            return View(surveyInfo);
        }

        // GET: SurveyInfoes1/Create
        public IActionResult Create()
        {
            ViewData["AgencyCode"] = new SelectList(_context.AgencyInfoes, "Code", "NameOfAgency");
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode");
            ViewData["EmPowerSourceCode"] = new SelectList(_context.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower");
            ViewData["EquipmentId"] = new SelectList(_context.EquipmentInfoes, "EquipmentId", "NameOfEquipment");
            ViewData["SwSourceCode"] = new SelectList(_context.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater");
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode");
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode");
            return View();
        }

        // POST: SurveyInfoes1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyId,EquipmentId,DistCode,UpazCode,UnionCode,MauzaName,JlNo,PlotNo,SurveyDate,NameOfScheme,OwnerOrManagerName,OwnerOrManagerMobileNo,AgencyCode,DieselEngineMakeAndModel,DieselEngineHp,ElectricMotorMakeAndModel,ElectricMotorKw,EmPowerSourceCode,PumpCapacityInCusec,SwSourceCode,SmartCard,IsPit,IsServiceable,TotalOperatingHour,BoroArea,WheatArea,PotatoArea,MaizeArea,VegWinterArea,MustardArea,OthersArea,BoroCost,WheatCost,PotatoCost,MaizeCost,VegWinterCost,OthersCost,CanalLengthPacca,CanalLengthBuriedPipe,CanalLengthFitaPipe,CanalLengthKacha,BenefitedFarmerMale,BenefitedAgricultureLabourMale,UseInKharif1Season,EntryDateTime,EntryUserId")] SurveyInfo surveyInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surveyInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgencyCode"] = new SelectList(_context.AgencyInfoes, "Code", "NameOfAgency", surveyInfo.AgencyCode);
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", surveyInfo.DistCode);
            ViewData["EmPowerSourceCode"] = new SelectList(_context.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower", surveyInfo.EmPowerSourceCode);
            ViewData["EquipmentId"] = new SelectList(_context.EquipmentInfoes, "EquipmentId", "NameOfEquipment", surveyInfo.EquipmentId);
            ViewData["SwSourceCode"] = new SelectList(_context.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater", surveyInfo.SwSourceCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", surveyInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", surveyInfo.UpazCode);
            return View(surveyInfo);
        }

        // GET: SurveyInfoes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _context.SurveyInfoes.FindAsync(id);
            if (surveyInfo == null)
            {
                return NotFound();
            }

            ViewData["AgencyCode"] = new SelectList(_context.AgencyInfoes, "Code", "NameOfAgency", surveyInfo.AgencyCode);
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", surveyInfo.DistCode);
            ViewData["EmPowerSourceCode"] = new SelectList(_context.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower", surveyInfo.EmPowerSourceCode);
            //ViewData["EquipmentId"] = new SelectList(_context.EquipmentInfoes, "EquipmentId", "NameOfEquipment", surveyInfo.EquipmentId);
            ViewData["SwSourceCode"] = new SelectList(_context.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater", surveyInfo.SwSourceCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", surveyInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", surveyInfo.UpazCode);
            return View(surveyInfo);
        }

        // POST: SurveyInfoes1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyId,EquipmentId,DistCode,UpazCode,UnionCode,MauzaName,JlNo,PlotNo,SurveyDate,NameOfScheme,OwnerOrManagerName,OwnerOrManagerMobileNo,AgencyCode,DieselEngineMakeAndModel,DieselEngineHp,ElectricMotorMakeAndModel,ElectricMotorKw,EmPowerSourceCode,PumpCapacityInCusec,SwSourceCode,SmartCard,IsPit,IsServiceable,TotalOperatingHour,BoroArea,WheatArea,PotatoArea,MaizeArea,VegWinterArea,MustardArea,OthersArea,BoroCost,WheatCost,PotatoCost,MaizeCost,VegWinterCost,OthersCost,CanalLengthPacca,CanalLengthBuriedPipe,CanalLengthFitaPipe,CanalLengthKacha,BenefitedFarmerMale,BenefitedAgricultureLabourMale,UseInKharif1Season,EntryDateTime,EntryUserId")] SurveyInfo surveyInfo)
        {
            if (id != surveyInfo.SurveyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surveyInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyInfoExists(surveyInfo.SurveyId))
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
            ViewData["AgencyCode"] = new SelectList(_context.AgencyInfoes, "Code", "NameOfAgency", surveyInfo.AgencyCode);
            ViewData["DistCode"] = new SelectList(_context.DistrictInfoes, "DistCode", "DistCode", surveyInfo.DistCode);
            ViewData["EmPowerSourceCode"] = new SelectList(_context.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower", surveyInfo.EmPowerSourceCode);
            ViewData["EquipmentId"] = new SelectList(_context.EquipmentInfoes, "EquipmentId", "NameOfEquipment", surveyInfo.EquipmentId);
            ViewData["SwSourceCode"] = new SelectList(_context.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater", surveyInfo.SwSourceCode);
            ViewData["UnionCode"] = new SelectList(_context.UnionInfoes, "UnionCode", "UnionCode", surveyInfo.UnionCode);
            ViewData["UpazCode"] = new SelectList(_context.UpazilaInfoes, "UpazCode", "UpazCode", surveyInfo.UpazCode);
            return View(surveyInfo);
        }

        // GET: SurveyInfoes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _context.SurveyInfoes
                .Include(s => s.AgencyInfo)
                .Include(s => s.DistrictInfo)
                .Include(s => s.ElectricMotorPowerSourceInfo)
                .Include(s => s.EquipmentInfo)
                .Include(s => s.SurfaceWaterSourceInfo)
                .Include(s => s.UnionInfo)
                .Include(s => s.UpazilaInfo)
                .FirstOrDefaultAsync(m => m.SurveyId == id);

            if (surveyInfo == null)
            {
                return NotFound();
            }

            return View(surveyInfo);
        }

        // POST: SurveyInfoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surveyInfo = await _context.SurveyInfoes.FindAsync(id);

            _context.SurveyInfoes.Remove(surveyInfo);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool SurveyInfoExists(int id)
        {
            return _context.SurveyInfoes.Any(e => e.SurveyId == id);
        }
    }
}

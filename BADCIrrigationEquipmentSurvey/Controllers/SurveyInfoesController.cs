using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models.DataModels;
using BADCIrrigationEquipmentSurvey.Models.ViewModels;
using Microsoft.AspNetCore.Routing;


namespace BADCIrrigationEquipmentSurvey.Controllers
{
    public class SurveyInfoesController : Controller
    {
        private readonly BadcDbContext _dbContext;

        public SurveyInfoesController(BadcDbContext context)
        {
            _dbContext = context;
        }

        // GET: SurveyInfoes
        public async Task<IActionResult> Index(int? equipmentId)
        {
            ViewBag.EquipmentId = equipmentId;
            ViewBag.Title = _dbContext.EquipmentInfoes
                .Where(eqi => equipmentId == null || eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();

            ViewData["EquipmentId"] = equipmentId;
            ViewData["Title"] = _dbContext.EquipmentInfoes
                .Where(eqi => equipmentId == null || eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();

            var surveyInfoes = _dbContext.SurveyInfoes
                .Where(si => equipmentId == null || si.EquipmentId == equipmentId)
                .Include(si => si.EquipmentInfo)
                .Include(si => si.DistrictInfo)
                .Include(si => si.UpazilaInfo)
                .Include(si => si.UnionInfo)
                .Include(si => si.AgencyInfo)
                .Include(si => si.ElectricMotorPowerSourceInfo)
                .Include(si => si.SurfaceWaterSourceInfo);

            return View(await surveyInfoes.ToListAsync());
        }

        // GET: SurveyInfoes/Details/5

        // GET: SurveyInfoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _dbContext.SurveyInfoes
                .Include(si => si.EquipmentInfo)
                .Include(si => si.AgencyInfo)
                .Include(si => si.DistrictInfo)
                .Include(si => si.ElectricMotorPowerSourceInfo)
                .Include(si => si.SurfaceWaterSourceInfo)
                .Include(si => si.UnionInfo)
                .Include(si => si.UpazilaInfo)
                .FirstOrDefaultAsync(sif => sif.SurveyId == id);

            if (surveyInfo == null)
            {
                return NotFound();
            }

            ViewData["EquipmentId"] = surveyInfo.EquipmentId;
            ViewData["Title"] = surveyInfo.EquipmentInfo.NameOfEquipment;

            //ViewBag.EquipmentId = surveyInfo.EquipmentId;
            //ViewBag.Title = surveyInfo.EquipmentInfo.NameOfEquipment;

            return View(surveyInfo);
        }



        //ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes, "DistCode", "DistName");
        //ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes, "UpazCode", "UpazName");
        //ViewData["UnionCode"] = new SelectList(_dbContext.UnionInfoes, "UnionCode", "UnionName");

        [HttpPost]
        public JsonResult GetDistrictList(string divCode)
        {
            var distList = _dbContext.DistrictInfoes
                .Where(d => d.DivCode.Equals(divCode))
                .Select(d => new { d.DistCode, d.DistName })
                .OrderBy(d => d.DistName).ToList();

            return Json(new SelectList(distList, "UpazCode", "UpazName"));
        }

        [HttpPost]
        public JsonResult GetUpazilaList(string distCode)
        {
            var upzaList = _dbContext.UpazilaInfoes
                .Where(u => u.DistCode.Equals(distCode))
                .Select(u => new { u.UpazCode, u.UpazName })
                .OrderBy(u => u.UpazName).ToList();

            return Json(new SelectList(upzaList, "UpazCode", "UpazName"));
        }

        [HttpPost]
        public JsonResult GetUnionList(string distCode, string upazCode)
        {
            var unionList = _dbContext.UnionInfoes
                .Where(u => u.DistCode.Equals(distCode) && u.UpazCode.Equals(upazCode))
                .Select(u => new { u.UnionCode, u.UnionName })
                .OrderBy(u => u.UnionName).ToList();

            return Json(new SelectList(unionList, "UnionCode", "UnionName"));
        }

        [HttpPost]
        public JsonResult GetMauzaList(string distCode, string upazCode, string unionCode)
        {
            var mauzaList = _dbContext.MauzaInfoes
                .Where(m => m.DistCode.Equals(distCode) && m.UpazCode.Equals(upazCode) && m.UnionCode.Equals(unionCode))
                .Select(m => new { m.MauzaCode, m.MauzaName })
                .OrderBy(m => m.MauzaName).ToList();

            return Json(new SelectList(mauzaList, "MauzaCode", "MauzaName"));
        }

        [HttpPost]
        public JsonResult GetMauzaWithJlNoList(string distCode, string upazCode, string unionCode)
        {
            var mauzaList = _dbContext.MauzaInfoes
                .Where(m => m.DistCode.Equals(distCode) && m.UpazCode.Equals(upazCode) && m.UnionCode.Equals(unionCode))
                .Select(m => new { m.MauzaCode, m.MauzaName, m.MauzaJlNo })
                .OrderBy(m => m.MauzaName).ToList();

            return Json(new SelectList(mauzaList, "MauzaCode", "MauzaName", "MauzaJlNo"));
        }

        [HttpPost]
        public JsonResult GetMauzaListX(string distCode, string upazCode)
        {
            var mauzaList = _dbContext.MauzaInfoes
                .Where(m => m.DistCode.Equals(distCode) && m.UpazCode.Equals(upazCode))
                .Select(m => new { m.UnionCode, m.MauzaCode, m.MauzaName })
                .OrderBy(m => m.MauzaName).ToList();

            return Json(mauzaList);
            //return Json(new SelectList(mauzaList, "MauzaCode", "MauzaName"));
        }


        // GET: SurveyInfoes/Add
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Add(int? equipmentId)
        {
            ViewBag.EquipmentId = equipmentId;

            ViewBag.Title = _dbContext.EquipmentInfoes
                .Where(eqi => equipmentId == null || eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();


            ViewData["DistCode"] =
                new SelectList(_dbContext.DistrictInfoes.OrderBy(d => d.DistName), "DistCode", "DistName");

            ViewData["UpazCode"] = ViewData["UnionCode"] = null;


            var agencyInfoes = _dbContext.AgencyInfoes.Select(agn =>
                new { Code = agn.Code, NameOfAgency = agn.Code.ToString("00") + " : " + agn.NameOfAgency });
            var pwSourceInfoes = _dbContext.MotorPowerSourceInfoes.Select(mps => new
            {
                Code = mps.Code,
                ElectricMotorSourceOfPower = mps.Code.ToString("00") + " : " + mps.ElectricMotorSourceOfPower
            });
            var swSourceInfoes = _dbContext.SurfaceWaterSourceInfoes.Select(sws => new
            {
                Code = sws.Code,
                SourceOfSurfaceWater = sws.Code.ToString("00") + " : " + sws.SourceOfSurfaceWater
            });

            ViewData["AgencyCode"] = new SelectList(agencyInfoes, "Code", "NameOfAgency");
            ViewData["EmPowerSourceCode"] = new SelectList(pwSourceInfoes, "Code", "ElectricMotorSourceOfPower");
            ViewData["SwSourceCode"] = new SelectList(swSourceInfoes, "Code", "SourceOfSurfaceWater");

            return View();
        }

        // POST: SurveyInfoes/Add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(IList<SurveyInfo> surveyInfoes, int? equipmentId, string distCode, string upazCode, string surveyDate)
        {
            /*ViewBag.Error = "Add new Survey end info.";*/
            //ViewBag.surveyDate = surveyDate;

            var errMsg = string.Empty;

            if (equipmentId == null)
            {
                errMsg = "Survey Equipment not selected !";
            }
            else if (string.IsNullOrEmpty(distCode))
            {
                errMsg = "Survey District name not selected !";
            }
            else if (string.IsNullOrEmpty(upazCode))
            {
                errMsg = "Survey Upazila name not selected !";
            }
            else if (string.IsNullOrEmpty(surveyDate))
            {
                errMsg = "Survey Date not selected !";
            }

            if (string.IsNullOrEmpty(errMsg))
            {
                var allSurveyInfo = new List<SurveyInfo>();

                equipmentId = equipmentId ?? 0;

                foreach (var surveyInfo in surveyInfoes)
                {
                    //if (!surveyInfo.IsEmpty() || true)
                    //{
                    //    continue;
                    //}

                    if (surveyInfo.UnionCode == "" || string.IsNullOrEmpty(surveyInfo.UnionCode))
                    {
                        continue;
                    }

                    surveyInfo.EquipmentId = (int)equipmentId;
                    surveyInfo.DistCode = distCode;
                    surveyInfo.UpazCode = upazCode;
                    surveyInfo.SurveyDate = DateTime.ParseExact(surveyDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    surveyInfo.EntryDateTime = DateTime.Now;

                    allSurveyInfo.Add(surveyInfo);


                    // _dbContext.SurveyInfoes.Add(surveyInfo);
                    // _dbContext.SaveChanges();


                    //try
                    //{
                    //    _dbContext.Add(allSurveyInfos);
                    //    await _dbContext.SaveChangesAsync();
                    //}
                    //catch (Exception e)
                    //{
                    //    errMsg = e.Message;
                    //    Console.WriteLine(e);
                    //    //throw;
                    //}


                    //DateTime dtSurveyDate;
                    //if (!string.IsNullOrEmpty(surveyDate) && DateTime.TryParseExact(surveyDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out dtSurveyDate))
                    //{
                    //    surveyInfo.SurveyDate = dtSurveyDate;
                    //}
                }

                if (allSurveyInfo.Any())
                {
                    _dbContext.AddRange(allSurveyInfo.AsEnumerable());
                    await _dbContext.SaveChangesAsync();
                    //await _dbContext.AddRangeAsync();

                    //_dbContext.Add(newSurveyInfos);
                    //await _dbContext.SaveChangesAsync();

                    //return RedirectToAction(nameof(Index));

                    return RedirectToAction("Index", new RouteValueDictionary(
                        new { controller = "SurveyInfoes", action = "Index", equipmentId = equipmentId })
                    );

                }
                else
                {
                    errMsg = "Empty/Invalid Survey Data !";
                }

                //if (ModelState.IsValid)
                //{
                //    _dbContext.Add(surveyInfoes);
                //    await _dbContext.SaveChangesAsync();

                //    return RedirectToAction(nameof(Index));
                //}
            }

            ViewBag.Error = errMsg;

            ViewBag.EquipmentId = equipmentId;
            ViewBag.Title = _dbContext.EquipmentInfoes
                .Where(eqi => equipmentId == null || eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();

            ViewData["distCode"] = distCode;
            ViewData["upazCode"] = upazCode;
            ViewData["surveyDate"] = surveyDate;


            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes.OrderBy(d => d.DistName), "DistCode",
                "DistName", distCode);

            if (!string.IsNullOrEmpty(distCode))
            {
                ViewData["UpazCode"] =
                    new SelectList(
                        _dbContext.UpazilaInfoes.Where(u => u.DistCode.Equals(distCode)).OrderBy(u => u.UpazName)
                            .ToList(), "UpazCode", "UpazName", upazCode);
            }
            else
            {
                ViewData["UpazCode"] = null;
            }

            if (!string.IsNullOrEmpty(upazCode))
            {
                ViewData["UnionCode"] =
                    new SelectList(
                        _dbContext.UnionInfoes.Where(u => u.UpazCode.Equals(upazCode)).OrderBy(u => u.UnionName)
                            .ToList(), "UnionCode", "UnionName");
            }
            else
            {
                ViewData["UnionCode"] = null;
            }


            var agencyInfoes = _dbContext.AgencyInfoes.Select(agn =>
                new { Code = agn.Code, NameOfAgency = agn.Code.ToString("00") + " : " + agn.NameOfAgency });
            var pwSourceInfoes = _dbContext.MotorPowerSourceInfoes.Select(mps => new
            {
                Code = mps.Code,
                ElectricMotorSourceOfPower = mps.Code.ToString("00") + " : " + mps.ElectricMotorSourceOfPower
            });
            var swSourceInfoes = _dbContext.SurfaceWaterSourceInfoes.Select(sws => new
            {
                Code = sws.Code,
                SourceOfSurfaceWater = sws.Code.ToString("00") + " : " + sws.SourceOfSurfaceWater
            });

            ViewData["AgencyCode"] = new SelectList(agencyInfoes, "Code", "NameOfAgency");
            ViewData["EmPowerSourceCode"] = new SelectList(pwSourceInfoes, "Code", "ElectricMotorSourceOfPower");
            ViewData["SwSourceCode"] = new SelectList(swSourceInfoes, "Code", "SourceOfSurfaceWater");

            return View(surveyInfoes);
        }

        // GET: SurveyInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _dbContext.SurveyInfoes.SingleOrDefaultAsync(si => si.SurveyId == id);
            if (surveyInfo == null)
            {
                return NotFound();
            }

            var equipmentId = surveyInfo.EquipmentId;

            ViewData["EquipmentId"] = equipmentId;
            ViewData["Title"] = _dbContext.EquipmentInfoes
                .Where(eqi => eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();
            
            //ViewBag.EquipmentId = surveyInfo.EquipmentId;
            //ViewBag.Title = surveyInfo.EquipmentInfo.NameOfEquipment;

            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes.OrderBy(d => d.DistName), "DistCode",
                "DistName", surveyInfo.DistCode);
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes.OrderBy(u => u.UpazName), "UpazCode",
                "UpazName", surveyInfo.UpazCode);
            ViewData["UnionCode"] = new SelectList(_dbContext.UnionInfoes.OrderBy(u => u.UnionName), "UnionCode",
                "UnionName", surveyInfo.UnionCode);


            var agencyInfoes = _dbContext.AgencyInfoes
                .Select(agn => new { Code = agn.Code, NameOfAgency = agn.Code.ToString("00") + " : " + agn.NameOfAgency });
            var pwSourceInfoes = _dbContext.MotorPowerSourceInfoes
                .Select(mps => new
                {
                    Code = mps.Code,
                    ElectricMotorSourceOfPower = mps.Code.ToString("00") + " : " + mps.ElectricMotorSourceOfPower
                });
            var swSourceInfoes = _dbContext.SurfaceWaterSourceInfoes
                .Select(sws => new
                {
                    Code = sws.Code,
                    SourceOfSurfaceWater = sws.Code.ToString("00") + " : " + sws.SourceOfSurfaceWater
                });

            ViewData["AgencyCode"] = new SelectList(agencyInfoes, "Code", "NameOfAgency");
            ViewData["EmPowerSourceCode"] = new SelectList(pwSourceInfoes, "Code", "ElectricMotorSourceOfPower");
            ViewData["SwSourceCode"] = new SelectList(swSourceInfoes, "Code", "SourceOfSurfaceWater");

            //ViewData["AgencyCode"] = new SelectList(_dbContext.AgencyInfoes, "Code", "NameOfAgency", surveyInfo.AgencyCode);
            //ViewData["EmPowerSourceCode"] = new SelectList(_dbContext.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower", surveyInfo.EmPowerSourceCode);
            //ViewData["SwSourceCode"] = new SelectList(_dbContext.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater", surveyInfo.SwSourceCode);

            return View(surveyInfo);
        }

        // POST: SurveyInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //public async Task<IActionResult> Edit(int id, [Bind("SurveyId,EquipmentId,DistCode,UpazCode,UnionCode,MauzaName,JlNo,PlotNo,SurveyDate,NameOfScheme,OwnerOrManagerName,OwnerOrManagerMobileNo,AgencyCode,DieselEngineMakeAndModel,DieselEngineHp,ElectricMotorMakeAndModel,ElectricMotorKw,EmPowerSourceCode,PumpCapacityInCusec,SwSourceCode,SmartCard,IsPit,IsServiceable,TotalOperatingHour,BoroArea,WheatArea,PotatoArea,MaizeArea,VegWinterArea,MustardArea,OthersArea,BoroCost,WheatCost,PotatoCost,MaizeCost,VegWinterCost,OthersCost,CanalLengthPacca,CanalLengthBuriedPipe,CanalLengthFitaPipe,CanalLengthKacha,BenefitedFarmerMale,BenefitedAgricultureLabourMale,UseInKharif1Season,EntryDateTime,EntryUserId")] SurveyInfo surveyInfo)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SurveyInfo surveyInfo)
        {
            if (id != surveyInfo.SurveyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(surveyInfo);
                    await _dbContext.SaveChangesAsync();
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


            //ViewBag.EquipmentId = surveyInfo.EquipmentId;
            //ViewBag.Title = surveyInfo.EquipmentInfo.NameOfEquipment;


            var equipmentId = surveyInfo.EquipmentId;

            ViewData["EquipmentId"] = equipmentId;
            ViewData["Title"] = _dbContext.EquipmentInfoes
                .Where(eqi => eqi.EquipmentId == equipmentId)
                .Select(eqi => eqi.NameOfEquipment)
                .FirstOrDefault();
            
            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes.OrderBy(d => d.DistName), "DistCode",
                "DistName", surveyInfo.DistCode);
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes.OrderBy(u => u.UpazName), "UpazCode",
                "UpazName", surveyInfo.UpazCode);
            ViewData["UnionCode"] = new SelectList(_dbContext.UnionInfoes.OrderBy(u => u.UnionName), "UnionCode",
                "UnionName", surveyInfo.UnionCode);


            var agencyInfoes = _dbContext.AgencyInfoes.Select(agn =>
                new { Code = agn.Code, NameOfAgency = agn.Code.ToString("00") + " : " + agn.NameOfAgency });
            var pwSourceInfoes = _dbContext.MotorPowerSourceInfoes.Select(mps => new
            {
                Code = mps.Code,
                ElectricMotorSourceOfPower = mps.Code.ToString("00") + " : " + mps.ElectricMotorSourceOfPower
            });
            var swSourceInfoes = _dbContext.SurfaceWaterSourceInfoes.Select(sws => new
            {
                Code = sws.Code,
                SourceOfSurfaceWater = sws.Code.ToString("00") + " : " + sws.SourceOfSurfaceWater
            });

            ViewData["AgencyCode"] = new SelectList(agencyInfoes, "Code", "NameOfAgency");
            ViewData["EmPowerSourceCode"] = new SelectList(pwSourceInfoes, "Code", "ElectricMotorSourceOfPower");
            ViewData["SwSourceCode"] = new SelectList(swSourceInfoes, "Code", "SourceOfSurfaceWater");

            //ViewData["AgencyCode"] = new SelectList(_dbContext.AgencyInfoes, "Code", "NameOfAgency", surveyInfo.AgencyCode);
            //ViewData["EmPowerSourceCode"] = new SelectList(_dbContext.MotorPowerSourceInfoes, "Code", "ElectricMotorSourceOfPower", surveyInfo.EmPowerSourceCode);
            //ViewData["SwSourceCode"] = new SelectList(_dbContext.SurfaceWaterSourceInfoes, "Code", "SourceOfSurfaceWater", surveyInfo.SwSourceCode);

            return View(surveyInfo);
        }

        // GET: SurveyInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyInfo = await _dbContext.SurveyInfoes
                .Include(si => si.EquipmentInfo)
                .Include(si => si.DistrictInfo)
                .Include(si => si.UpazilaInfo)
                .Include(si => si.UnionInfo)
                .Include(si => si.AgencyInfo)
                .Include(si => si.ElectricMotorPowerSourceInfo)
                .Include(si => si.SurfaceWaterSourceInfo)
                .SingleOrDefaultAsync(si => si.SurveyId == id);

            if (surveyInfo == null)
            {
                return NotFound();
            }

            ViewData["EquipmentId"] = surveyInfo.EquipmentId;
            ViewData["Title"] = surveyInfo.EquipmentInfo.NameOfEquipment;

            //ViewBag.EquipmentId = surveyInfo.EquipmentId;
            //ViewBag.Title = surveyInfo.EquipmentInfo.NameOfEquipment;

            return View(surveyInfo);
        }

        // POST: SurveyInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surveyInfo = await _dbContext.SurveyInfoes.SingleOrDefaultAsync(si => si.SurveyId == id);

            _dbContext.SurveyInfoes.Remove(surveyInfo);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool SurveyInfoExists(int id)
        {
            return _dbContext.SurveyInfoes.Any(e => e.SurveyId == id);
        }

    }

}

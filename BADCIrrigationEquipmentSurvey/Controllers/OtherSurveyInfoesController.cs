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


namespace BADCIrrigationEquipmentSurvey.Controllers
{
    public class OtherSurveyInfoesController : Controller
    {
        private readonly BadcDbContext _dbContext;

        public OtherSurveyInfoesController(BadcDbContext context)
        {
            _dbContext = context;
        }

        // GET: OtherSurveyInfoes
        public async Task<IActionResult> Index()
        {
            var badcDbContext = _dbContext.OtherSurveyInfo.Include(o => o.DistrictInfo).Include(o => o.EquipmentInfo).Include(o => o.UpazilaInfo);
            return View(await badcDbContext.ToListAsync());
        }

        // GET: OtherSurveyInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherSurveyInfo = await _dbContext.OtherSurveyInfo
                .Include(o => o.DistrictInfo)
                .Include(o => o.EquipmentInfo)
                .Include(o => o.UpazilaInfo)
                .FirstOrDefaultAsync(m => m.OtherSurveyId == id);

            if (otherSurveyInfo == null)
            {
                return NotFound();
            }

            return View(otherSurveyInfo);
        }




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
        public IActionResult Add()
        {
            ViewBag.Title = "Others Equipment";


            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes.OrderBy(d => d.DistName), "DistCode", "DistName");

            ViewData["UpazCode"] = null;


            var equipmentInfoes = _dbContext.EquipmentInfoes
                .Where(eqi => eqi.EquipmentTypeId == 2)
                .Select(eqi => new { eqi.EquipmentId, eqi.NameOfEquipment });

            ViewData["EquipmentId"] = new SelectList(equipmentInfoes, "EquipmentId", "NameOfEquipment");

            return View();
        }

        // POST: SurveyInfoes/Add
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(IList<OtherSurveyInfo> surveyInfoes, string distCode, string upazCode, string surveyDate)
        {
            /*ViewBag.Error = "Add new Survey end info.";*/
            //ViewBag.surveyDate = surveyDate;

            var errMsg = string.Empty;

            if (string.IsNullOrEmpty(distCode))
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
                var allSurveyInfo = new List<OtherSurveyInfo>();

                foreach (var surveyInfo in surveyInfoes)
                {
                    //if (!surveyInfo.IsEmpty() || true)
                    //{
                    //    continue;
                    //}
                    
                    surveyInfo.DistCode = distCode;
                    surveyInfo.UpazCode = upazCode;
                    surveyInfo.SurveyDate = DateTime.ParseExact(surveyDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    surveyInfo.EntryDateTime = DateTime.Now;

                    allSurveyInfo.Add(surveyInfo);


                    // _dbContext.SurveyInfoes.Add(surveyInfo);
                    // _dbContext.SaveChanges();
                }

                if (allSurveyInfo.Any())
                {
                    _dbContext.AddRange(allSurveyInfo.AsEnumerable());
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
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

            ViewBag.Title = "Others Equipment";

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

            var equipmentInfoes = _dbContext.EquipmentInfoes
                .Where(eqi => eqi.EquipmentTypeId == 2)
                .Select(eqi => new { eqi.EquipmentId, eqi.NameOfEquipment });

            ViewData["EquipmentId"] = new SelectList(equipmentInfoes, "EquipmentId", "NameOfEquipment");

            return View(surveyInfoes);
        }



        // GET: OtherSurveyInfoes/Create
        public IActionResult Create()
        {
            ViewData["EquipmentId"] = new SelectList(_dbContext.EquipmentInfoes.Where(ei => ei.EquipmentTypeId == 2), "EquipmentId", "NameOfEquipment");

            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes, "DistCode", "DistCode");
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes, "UpazCode", "UpazCode");
            return View();
        }

        // POST: OtherSurveyInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OtherSurveyInfo otherSurveyInfo)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(otherSurveyInfo);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes, "DistCode", "DistCode", otherSurveyInfo.DistCode);
            ViewData["EquipmentId"] = new SelectList(_dbContext.EquipmentInfoes.Where(ei => ei.EquipmentTypeId == 2), "EquipmentId", "NameOfEquipment", otherSurveyInfo.EquipmentId);
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes, "UpazCode", "UpazCode", otherSurveyInfo.UpazCode);
            return View(otherSurveyInfo);
        }

        // GET: OtherSurveyInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherSurveyInfo = await _dbContext.OtherSurveyInfo.FindAsync(id);
            if (otherSurveyInfo == null)
            {
                return NotFound();
            }

            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes, "DistCode", "DistCode", otherSurveyInfo.DistCode);
            ViewData["EquipmentId"] = new SelectList(_dbContext.EquipmentInfoes.Where(ei => ei.EquipmentTypeId == 2), "EquipmentId", "NameOfEquipment", otherSurveyInfo.EquipmentId);
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes, "UpazCode", "UpazCode", otherSurveyInfo.UpazCode);
            return View(otherSurveyInfo);
        }

        // POST: OtherSurveyInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OtherSurveyId,EquipmentId,DistCode,UpazCode,SurveyDate,RobiBoroArea,RobiWheatArea,RobiPotatoArea,RobiMaizeArea,RobiVegWinterArea,RobiMustardArea,RobiOthersArea,RobiBenefitedFarmerMale,RobiBenefitedAgricultureLabourMale,Kharif1AusArea,Kharif1JuteArea,Kharif1VegSummerArea,Kharif1OthersArea,Kharif1BenefitedFarmerMale,Kharif1BenefitedAgricultureLabourMale,Kharif2TAmanArea,Kharif2OthersArea,Kharif2BenefitedFarmerMale,Kharif2BenefitedAgricultureLabourMale")] OtherSurveyInfo otherSurveyInfo)
        {
            if (id != otherSurveyInfo.OtherSurveyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Update(otherSurveyInfo);
                    await _dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtherSurveyInfoExists(otherSurveyInfo.OtherSurveyId))
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

            ViewData["DistCode"] = new SelectList(_dbContext.DistrictInfoes, "DistCode", "DistCode", otherSurveyInfo.DistCode);
            ViewData["EquipmentId"] = new SelectList(_dbContext.EquipmentInfoes.Where(ei => ei.EquipmentTypeId == 2), "EquipmentId", "NameOfEquipment", otherSurveyInfo.EquipmentId);
            ViewData["UpazCode"] = new SelectList(_dbContext.UpazilaInfoes, "UpazCode", "UpazCode", otherSurveyInfo.UpazCode);
            return View(otherSurveyInfo);
        }

        // GET: OtherSurveyInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otherSurveyInfo = await _dbContext.OtherSurveyInfo
                .Include(o => o.DistrictInfo)
                .Include(o => o.EquipmentInfo)
                .Include(o => o.UpazilaInfo)
                .FirstOrDefaultAsync(m => m.OtherSurveyId == id);

            if (otherSurveyInfo == null)
            {
                return NotFound();
            }

            return View(otherSurveyInfo);
        }

        // POST: OtherSurveyInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otherSurveyInfo = await _dbContext.OtherSurveyInfo.FindAsync(id);
            _dbContext.OtherSurveyInfo.Remove(otherSurveyInfo);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OtherSurveyInfoExists(int id)
        {
            return _dbContext.OtherSurveyInfo.Any(e => e.OtherSurveyId == id);
        }
    }
}

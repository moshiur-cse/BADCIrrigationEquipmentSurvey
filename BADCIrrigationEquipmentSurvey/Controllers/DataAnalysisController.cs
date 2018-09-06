using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models.ViewModels;
using BADCIrrigationEquipmentSurvey.Models.DataModels;
using Extensions;


namespace BADCIrrigationEquipmentSurvey.Controllers
{
    public class DataAnalysisController : Controller
    {
        private readonly BadcDbContext _dbContext;
        public DataAnalysisController(BadcDbContext context)
        {
            _dbContext = context;
        }
        private Expression<Func<SurveyInfo, Boolean>> AppendExpression(Expression<Func<SurveyInfo, Boolean>> left, Expression<Func<SurveyInfo, Boolean>> right, string condition)
        {
            Expression<Func<SurveyInfo, Boolean>> where;

            switch (condition)
            {
                case "OR":
                     
                    //the initial case starts off with a left epxression as null. If that's the case,
                    //then give the short-circuit operator something to trigger on for the right expression
                    if (left == null)
                    { left = model => false; }

                    where = ExpressionExtension<SurveyInfo>.OrElse(left, right);
                    break;
                case "AND":

                    if (left == null)
                    { left = model => true; }

                    where = ExpressionExtension<SurveyInfo>.AndAlso(left, right);
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return where;
        }
        public ActionResult ByIrrigationEquipments()
        {
            ViewBag.Items = _dbContext.DistrictInfoes.ToList();


            //adminName = "a";
            //Expression<Func<SurveyInfo, Boolean>> where = null;

            //if (adminName != null)
            //{
            //    var parameter1 = Expression.Parameter(typeof(SurveyInfo), "x");
            //    var member1 = Expression.Property(parameter1, "DistCode"); //x.Id
            //    var constant = Expression.Constant("100409");
            //    var body = Expression.Equal(member1, constant); //x.Id >= 3
            //    var exp = Expression.Lambda<Func<SurveyInfo, bool>>(body, parameter1); //x => x.Id >= 3
            //    where = AppendExpression(where, exp, "AND");
            //}

            //OrderBy or GroupBy
            //var parameter = Expression.Parameter(typeof(SurveyInfo), "x");
            //var member = Expression.Property(parameter, "DistCode"); //x.Id
            //var groupBy = Expression.Lambda<Func<SurveyInfo, string>>(member, parameter);
            Expression < Func<SurveyInfo, string>> groupBy = model => model.UpazilaInfo.UpazName;

            ViewBag.Admin = "Upazila";

            //ViewBag.query = _dbContext.SurveyInfoes.Where(where).
            ViewBag.query = _dbContext.SurveyInfoes.
                GroupBy(groupBy).Select(k => new {

                    UpazName = k.Key,
                    b = k.Select(i => i.DistrictInfo.DistName),
                    c = k.Select(i => i.AgencyInfo.NameOfAgency),

                    PDBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    PDBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    FarmrsCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),

                    FarmrsCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),

                    AreaCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    AreaCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    UnitCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count(),
                    UnitCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count()

                }).ToList();
           


            List<ReportViewModel> aList = new List<ReportViewModel>();

            ReportViewModel aReportViewModel;

            for (int r = 0; r < ViewBag.query.Count; r++)
            {
                aReportViewModel = new ReportViewModel();


                aReportViewModel.Upazila = ViewBag.query[r].UpazName.ToString();

                aReportViewModel.PDBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByBADC);
                aReportViewModel.REBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].REBCountGroupByBADC);

                aReportViewModel.PDBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByOthers);
                aReportViewModel.REBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].REBCountGroupByOthers);

                aReportViewModel.FarmrsCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndDieselEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndDieselEngines);

                aReportViewModel.FarmrsCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndElectricityEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndElectricityEngines);


                aReportViewModel.AreaCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndDieselEngines);
                aReportViewModel.AreaCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndDieselEngines);

                aReportViewModel.AreaCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndElectricityEngines);
                aReportViewModel.AreaCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndElectricityEngines);

                aReportViewModel.UnitCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByBADSAndDieselEngines);
                aReportViewModel.UnitCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByOthersAndDieselEngines);

                aList.Add(aReportViewModel);
            }
            return View(aList);
        }


        public ActionResult _ByIrrigationEquipmentsPartialView(string adminName, string sessionName, string equipmentName, string condition)
        {
           

            //Expression<Func<SurveyInfo, Boolean>> where = null;

            //if (sessionName == "Kkharif - 1" || sessionName == "Kkharif - 2")
            //{
            //    var parameter1 = Expression.Parameter(typeof(SurveyInfo), "x");
            //    var member1 = Expression.Property(parameter1, "AgencyCode"); //x.Id
            //    var constant = Expression.Convert(Expression.Constant(4), member1.Type);
            //    Expression body = Expression.GreaterThanOrEqual(member1,constant);
            //    var exp = Expression.Lambda<Func<SurveyInfo, bool>>(body, parameter1); //x => x.Id >= 3
            //    where = AppendExpression(where, exp, "AND");
            //}
            //if (equipmentName == "STW" || equipmentName == "DTW")
            //{
            //    var parameter1 = Expression.Parameter(typeof(SurveyInfo), "x");
            //    var member1 = Expression.Property(parameter1, "AgencyCode"); //x.Id
            //    var constant = Expression.Convert(Expression.Constant(4), member1.Type);
            //    var body = Expression.Equal(member1, constant); //x.Id >= 3
            //    var exp = Expression.Lambda<Func<SurveyInfo, bool>>(body, parameter1); //x => x.Id >= 3
            //    where = AppendExpression(where, exp, "AND");
            //}
            //OrderBy or GroupBy
            //var parameter = Expression.Parameter(typeof(SurveyInfo), "x");
            //var member = Expression.Property(parameter, "DistCode"); //x.Id
            //var groupBy = Expression.Lambda<Func<SurveyInfo, string>>(member, parameter);

            Expression<Func<SurveyInfo, string>> groupBy = model => model.UpazilaInfo.UpazName;
            ViewBag.Admin = "Upazila";
            if (adminName == "District")
            {
                groupBy = model => model.DistrictInfo.DistName;

                ViewBag.Admin = "District";
            }

            

            if (sessionName == "Kkharif1" || sessionName == "Kkharif2" || equipmentName == "STW" ||
                equipmentName == "DTW")
            {
                ViewBag.query = _dbContext.SurveyInfoes.Where(i=>i.DistrictInfo.DistName == "ABC").
                GroupBy(groupBy).Select(k => new {

                    UpazName = k.Key,
                    b = k.Select(i => i.DistrictInfo.DistName),
                    c = k.Select(i => i.AgencyInfo.NameOfAgency),

                    PDBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    PDBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    FarmrsCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),

                    FarmrsCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),

                    AreaCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    AreaCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    UnitCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count(),
                    UnitCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count()

                }).ToList();

            }
            else
            {


                //ViewBag.query = _dbContext.SurveyInfoes.Where(where).  Where(where). //Where(where).
                ViewBag.query = _dbContext.SurveyInfoes.GroupBy(groupBy).Select(k => new
                {

                    UpazName = k.Key,
                    b = k.Select(i => i.DistrictInfo.DistName),
                    c = k.Select(i => i.AgencyInfo.NameOfAgency),

                    PDBCountGroupByBADC = k.Where(i =>
                        i.AgencyInfo.NameOfAgency == "BADC" &&
                        i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByBADC = k.Where(i =>
                        i.AgencyInfo.NameOfAgency == "BADC" &&
                        i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    PDBCountGroupByOthers = k.Where(i =>
                        i.AgencyInfo.NameOfAgency != "BADC" &&
                        i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByOthers = k.Where(i =>
                        i.AgencyInfo.NameOfAgency != "BADC" &&
                        i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    FarmrsCountGroupByBADSAndDieselEngines =
                    k.Where(i =>
                        i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" &&
                        i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndDieselEngines =
                    k.Where(i =>
                        i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" &&
                        i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),

                    FarmrsCountGroupByBADSAndElectricityEngines = k.Where(i =>
                        i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" &&
                        i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndElectricityEngines = k.Where(i =>
                        i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" &&
                        i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),

                    AreaCountGroupByBADSAndDieselEngines = k
                        .Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" &&
                                    i.DieselEngineHp != null).Sum(i =>
                            i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea +
                            i.OthersArea),
                    AreaCountGroupByOthersAndDieselEngines = k
                        .Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" &&
                                    i.DieselEngineHp != null).Sum(i =>
                            i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea +
                            i.OthersArea),

                    AreaCountGroupByBADSAndElectricityEngines = k
                        .Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" &&
                                    i.ElectricMotorKw != null).Sum(i =>
                            i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea +
                            i.OthersArea),
                    AreaCountGroupByOthersAndElectricityEngines = k
                        .Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" &&
                                    i.ElectricMotorKw != null).Sum(i =>
                            i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea +
                            i.OthersArea),

                    UnitCountGroupByBADSAndDieselEngines = k.Where(i =>
                        i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" &&
                        i.DieselEngineHp != null).Count(),
                    UnitCountGroupByOthersAndDieselEngines = k.Where(i =>
                        i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" &&
                        i.DieselEngineHp != null).Count()

                }).ToList();

            }

            List<ReportViewModel> aList = new List<ReportViewModel>();

            ReportViewModel aReportViewModel;

            for (int r = 0; r < ViewBag.query.Count; r++)
            {
                aReportViewModel = new ReportViewModel();


                aReportViewModel.Upazila = ViewBag.query[r].UpazName.ToString();

                aReportViewModel.PDBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByBADC);
                aReportViewModel.REBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].REBCountGroupByBADC);

                aReportViewModel.PDBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByOthers);
                aReportViewModel.REBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].REBCountGroupByOthers);

                aReportViewModel.FarmrsCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndDieselEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndDieselEngines);

                aReportViewModel.FarmrsCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndElectricityEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndElectricityEngines);


                aReportViewModel.AreaCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndDieselEngines);
                aReportViewModel.AreaCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndDieselEngines);

                aReportViewModel.AreaCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndElectricityEngines);
                aReportViewModel.AreaCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndElectricityEngines);

                aReportViewModel.UnitCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByBADSAndDieselEngines);
                aReportViewModel.UnitCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByOthersAndDieselEngines);

                aList.Add(aReportViewModel);
            }
            return PartialView(aList);
        }
        public ActionResult ByIrrigatedArea()
        {
            ViewBag.Items = _dbContext.DistrictInfoes.ToList();


            Expression<Func<SurveyInfo, string>> groupBy = model => model.UpazilaInfo.UpazName;

            ViewBag.Admin = "Upazila";

            //ViewBag.query = _dbContext.SurveyInfoes.Where(where).
            ViewBag.query = _dbContext.SurveyInfoes.
                GroupBy(groupBy).Select(k => new {

                    UpazName = k.Key,
                    b = k.Select(i => i.DistrictInfo.DistName),
                    c = k.Select(i => i.AgencyInfo.NameOfAgency),

                    PDBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByBADC = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    PDBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "PDB").Count(),
                    REBCountGroupByOthers = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorPowerSourceInfo.ElectricMotorSourceOfPower == "REB").Count(),

                    FarmrsCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BenefitedFarmerMale),

                    FarmrsCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),
                    FarmrsCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BenefitedFarmerMale),

                    AreaCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    AreaCountGroupByBADSAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),
                    AreaCountGroupByOthersAndElectricityEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.ElectricMotorMakeAndModel != "" && i.ElectricMotorKw != null).Sum(i => i.BoroArea + i.WheatArea + i.PotatoArea + i.MaizeArea + i.VegWinterArea + i.MustardArea + i.OthersArea),

                    UnitCountGroupByBADSAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency == "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count(),
                    UnitCountGroupByOthersAndDieselEngines = k.Where(i => i.AgencyInfo.NameOfAgency != "BADC" && i.DieselEngineMakeAndModel != "" && i.DieselEngineHp != null).Count()

                }).ToList();



            List<ReportViewModel> aList = new List<ReportViewModel>();

            ReportViewModel aReportViewModel;

            for (int r = 0; r < ViewBag.query.Count; r++)
            {
                aReportViewModel = new ReportViewModel();


                aReportViewModel.Upazila = ViewBag.query[r].UpazName.ToString();

                aReportViewModel.PDBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByBADC);
                aReportViewModel.REBCountGroupByBADC = Convert.ToDouble(ViewBag.query[r].REBCountGroupByBADC);

                aReportViewModel.PDBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].PDBCountGroupByOthers);
                aReportViewModel.REBCountGroupByOthers = Convert.ToDouble(ViewBag.query[r].REBCountGroupByOthers);

                aReportViewModel.FarmrsCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndDieselEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndDieselEngines);

                aReportViewModel.FarmrsCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByBADSAndElectricityEngines);
                aReportViewModel.FarmrsCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].FarmrsCountGroupByOthersAndElectricityEngines);


                aReportViewModel.AreaCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndDieselEngines);
                aReportViewModel.AreaCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndDieselEngines);

                aReportViewModel.AreaCountGroupByBADSAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByBADSAndElectricityEngines);
                aReportViewModel.AreaCountGroupByOthersAndElectricityEngines = Convert.ToDouble(ViewBag.query[r].AreaCountGroupByOthersAndElectricityEngines);

                aReportViewModel.UnitCountGroupByBADSAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByBADSAndDieselEngines);
                aReportViewModel.UnitCountGroupByOthersAndDieselEngines = Convert.ToDouble(ViewBag.query[r].UnitCountGroupByOthersAndDieselEngines);

                aList.Add(aReportViewModel);
            }
            return View();
        }
        public ActionResult ByIrrigatedCost()
        {
            return View();
        }
        public ActionResult ByBenefitedFarmerMale()
        {
            return View();
        }

        public ActionResult ByIrrigationDistributionEfficiency()
        {
            return View();
        }

        


    }
}
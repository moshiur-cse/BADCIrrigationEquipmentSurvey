using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.ViewModels
{
    public class ReportViewModel
    {
        public string Upazila { get; set; }
        public double PDBCountGroupByBADC { get; set; }
        public double REBCountGroupByBADC { get; set; }

        public double PDBCountGroupByOthers { get; set; }
        public double REBCountGroupByOthers { get; set; }

        public double FarmrsCountGroupByBADSAndDieselEngines { get; set; }
        public double FarmrsCountGroupByOthersAndDieselEngines { get; set; }

        public double FarmrsCountGroupByBADSAndElectricityEngines { get; set; }
        public double FarmrsCountGroupByOthersAndElectricityEngines { get; set; }

        public double AreaCountGroupByBADSAndDieselEngines { get; set; }
        public double AreaCountGroupByOthersAndDieselEngines { get; set; }

        public double AreaCountGroupByBADSAndElectricityEngines { get; set; }
        public double AreaCountGroupByOthersAndElectricityEngines { get; set; }

        public double UnitCountGroupByBADSAndDieselEngines { get; set; }
        public double UnitCountGroupByOthersAndDieselEngines { get; set; }

    }
}

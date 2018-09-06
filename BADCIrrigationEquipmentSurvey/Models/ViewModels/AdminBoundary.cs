using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BADCIrrigationEquipmentSurvey.DbContexts;
using BADCIrrigationEquipmentSurvey.Models.DataModels;


namespace BADCIrrigationEquipmentSurvey.Models.ViewModels
{
    public class AdminBoundary
    {
    }

    public class GetDistInfo
    {

        private readonly BadcDbContext _dbc;
        
        public GetDistInfo(BadcDbContext context)
        {
            _dbc = context;
        }


    }



    public class GetUpazInfo
    {

        private readonly BadcDbContext _dbc;
        
        public GetUpazInfo(BadcDbContext context)
        {
            _dbc = context;
        }

        //public IQueryable<UpazilaInfo> GetProjectDataSheets(string distCode)
        //{
        //    var pdsList = _dbc.UnionInfoes.AsQueryable<UpazilaInfo>();

        //    if (distCode == null) return pdsList;

        //    //if (searchOpts.PdsId.HasValue && searchOpts.PdsId > 0)
        //    //    pdsList = pdsList.Where(pds => pds.PdsId == searchOpts.PdsId);

        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectName))
        //    //    pdsList = pdsList.Where(pds => pds.ProjectInfo.ProjectName.Contains(searchOpts.ProjectName));
        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectPl))
        //    //    pdsList = pdsList.Where(pds => pds.ProjectInfo.ProjectPl.Contains(searchOpts.ProjectPl));

        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectLocation))
        //    //    pdsList = pdsList.Where(pds => pds.ProjectLocation.Contains(searchOpts.ProjectLocation));
        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectKeywords))
        //    //    pdsList = pdsList.Where(pds => pds.ProjectKeywords.Contains(searchOpts.ProjectKeywords));

        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectStartDate))
        //    //{
        //    //    var projectStartDate = DateTime.ParseExact(searchOpts.ProjectStartDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        //    //    pdsList = pdsList.Where(pds => pds.ProjectStartDate >= projectStartDate);
        //    //}

        //    //if (!string.IsNullOrEmpty(searchOpts.ProjectCompletionDate))
        //    //{
        //    //    var projectCompletionDate = DateTime.ParseExact(searchOpts.ProjectCompletionDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        //    //    pdsList = pdsList.Where(pds => pds.ProjectCompletionDate <= projectCompletionDate);
        //    //}

        //    //if (!string.IsNullOrEmpty(searchOpts.ClientName))
        //    //    pdsList = pdsList.Where(pds =>
        //    //        pds.ClientInfo.ClientShortName.Contains(searchOpts.ClientName) ||
        //    //        pds.ClientInfo.ClientFullName.Contains(searchOpts.ClientName));

        //    //if (!string.IsNullOrEmpty(searchOpts.CompletedBy))
        //    //    pdsList = pdsList.Where(pds => pds.CompletedBy.Contains(searchOpts.CompletedBy));

        //    //return pdsList;
        //}
    }
}

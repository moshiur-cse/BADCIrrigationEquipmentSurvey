using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class AgencyInfo
    {
        //public int AgencyCode { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataType(DataType.Text)]
        [Column(Order = 0, TypeName = "int")]
        [Display(Name = "Agency Code")]
        public int Code { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Name of Agency")]
        public string NameOfAgency { get; set; }

        //public ICollection<LowLiftPumpInfo> LowLiftPumpList { get; set; }
        
    }
}

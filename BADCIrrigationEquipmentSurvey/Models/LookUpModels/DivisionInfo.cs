using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class DivisionInfo
    {
        public DivisionInfo()
        {
            DistrictList = new HashSet<DistrictInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column(Order = 0, TypeName = "varchar(2)")]
        [StringLength(2, ErrorMessage = "The {0} must be {1} characters.")]
        [Display(Name = "Division Code")]
        public string DivCode { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Division Name")]
        public string DivName { get; set; }

       
        public ICollection<DistrictInfo> DistrictList { get; set; }
    }


}

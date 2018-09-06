using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class MotorPowerSourceInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataType(DataType.Text)]
        [Column(Order = 0, TypeName = "int")]
        [Display(Name = "Source of Power Code")]
        public int Code { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Electric Motor Source of Power")]
        public string ElectricMotorSourceOfPower { get; set; }
    }
}

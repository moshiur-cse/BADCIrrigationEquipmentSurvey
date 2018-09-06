using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BADCIrrigationEquipmentSurvey.Models.DataModels;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class SurveyTypeInfoBk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SurveyTypeId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Survey Type Id")]
        public int SurveyTypeId { get; set; }
        

        [Required(ErrorMessage = "Survey Type is required !")]
        [Column("SurveyType", Order = 2, TypeName = "varchar(250)")]
        [StringLength(250)]
        [Display(Name = "Survey Type")]
        [DataType(DataType.Text)]
        public string SurveyType { get; set; }

    }
}

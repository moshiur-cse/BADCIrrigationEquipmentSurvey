using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BADCIrrigationEquipmentSurvey.Models.DataModels;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class EquipmentTypeInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EquipmentTypeId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Equipment Type Id")]
        public int EquipmentTypeId { get; set; }
        
        [Required(ErrorMessage = "Equipment Type is required !")]
        [Column("EquipmentType", Order = 2, TypeName = "varchar(250)")]
        [StringLength(250)]
        [Display(Name = "Equipment Type")]
        [DataType(DataType.Text)]
        public string EquipmentType { get; set; }
    }
}

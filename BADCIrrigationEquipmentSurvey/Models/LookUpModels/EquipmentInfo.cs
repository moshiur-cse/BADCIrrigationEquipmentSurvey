using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class EquipmentInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EquipmentId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Equipment Id")]
        public int EquipmentId { get; set; }

        [Column("EquipmentTypeId", Order = 1, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Equipment Type")]
        public int EquipmentTypeId { get; set; }
        [ForeignKey("EquipmentTypeId")]
        public virtual EquipmentTypeInfo EquipmentTypeInfo { get; set; }

        [Required(ErrorMessage = "Name of Equipment is required !")]
        [Column("NameOfEquipment", Order = 2, TypeName = "varchar(250)")]
        [StringLength(250)]
        [Display(Name = "Name of Equipment")]
        [DataType(DataType.Text)]
        public string NameOfEquipment { get; set; }

    }
}

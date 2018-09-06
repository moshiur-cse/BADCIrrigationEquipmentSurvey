using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class CropInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CropId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Crop Id")]
        public int CropId { get; set; }

        [Column("SeasonId", Order = 1, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Season")]
        public int SeasonId { get; set; }
        [ForeignKey("SeasonId")]
        public virtual SeasonInfo SeasonInfo { get; set; }

        [Required(ErrorMessage = "Crop Name is required !")]
        [Column("CropName", Order = 2, TypeName = "varchar(250)")]
        [StringLength(250)]
        [Display(Name = "CropName")]
        [DataType(DataType.Text)]
        public string CropName { get; set; }

    }
}

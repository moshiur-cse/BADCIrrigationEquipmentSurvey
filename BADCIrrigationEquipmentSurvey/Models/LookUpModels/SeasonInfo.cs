using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class SeasonInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SeasonId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Season Id")]
        public int SeasonId { get; set; }
        
        [Required(ErrorMessage = "Season Name is required !")]
        [Column("SeasonName", Order = 2, TypeName = "varchar(250)")]
        [StringLength(250)]
        [Display(Name = "Season Name")]
        [DataType(DataType.Text)]
        public string SeasonName { get; set; }

    }
}

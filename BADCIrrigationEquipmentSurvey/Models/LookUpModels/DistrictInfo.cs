using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class DistrictInfo
    {
        public DistrictInfo()
        {
            MauzaList = new HashSet<MauzaInfo>();
            UnionList = new HashSet<UnionInfo>();
            UpazilaList = new HashSet<UpazilaInfo>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column(Order = 0, TypeName = "varchar(4)")]
        [StringLength(4, ErrorMessage = "The {0} must be {1} characters.")]
        [Display(Name = "District Code")]
        public string DistCode { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "District Name")]
        public string DistName { get; set; }

        
        [Column(Order = 2, TypeName = "varchar(2)")]
        [StringLength(2)]
        [Display(Name = "Division Code")]
        public string DivCode { get; set; }
        [ForeignKey("DivCode")]
        public virtual DivisionInfo DivisionInfo { get; set; }


        public ICollection<MauzaInfo> MauzaList { get; set; }
        public ICollection<UnionInfo> UnionList { get; set; }
        public ICollection<UpazilaInfo> UpazilaList { get; set; }
    }
}

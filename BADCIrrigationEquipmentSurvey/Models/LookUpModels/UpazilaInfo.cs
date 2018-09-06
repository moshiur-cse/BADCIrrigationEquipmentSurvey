using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class UpazilaInfo
    {
        public UpazilaInfo()
        {
            MauzaList = new HashSet<MauzaInfo>();
            UnionList = new HashSet<UnionInfo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column(Order = 0, TypeName = "varchar(6)")]
        [StringLength(6, ErrorMessage = "The {0} must be {1} characters.")]
        [Display(Name = "Upazila Code")]
        public string UpazCode { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Upazila Name")]
        public string UpazName { get; set; }
        
        [Column(Order = 2, TypeName = "varchar(4)")]
        [StringLength(4)]
        [Display(Name = "District Code")]
        public string DistCode { get; set; }
        [ForeignKey("DistCode")]
        public virtual DistrictInfo DistrictInfo { get; set; }

        public ICollection<MauzaInfo> MauzaList { get; set; }
        public ICollection<UnionInfo> UnionList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class UnionInfo
    {
        public UnionInfo()
        {
            MauzaList = new HashSet<MauzaInfo>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column(Order = 0, TypeName = "varchar(8)")]
        [StringLength(8, ErrorMessage = "The {0} must be {1} characters.")]
        [Display(Name = "Union Code")]
        public string UnionCode { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Union Name")]
        public string UnionName { get; set; }

        [Column(Order = 2, TypeName = "varchar(4)")]
        [StringLength(4)]
        [Display(Name = "District Code")]
        public string DistCode { get; set; }
        [ForeignKey("DistCode")]
        public virtual DistrictInfo DistrictInfo { get; set; }

        [Column(Order = 3, TypeName = "varchar(6)")]
        [StringLength(6)]
        [Display(Name = "Upazila Code")]
        public string UpazCode { get; set; }
        [ForeignKey("UpazCode")]
        public virtual UpazilaInfo UpazilaInfo { get; set; }


        public ICollection<MauzaInfo> MauzaList { get; set; }
    }


}

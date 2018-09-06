using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class MauzaInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column(Order = 0, TypeName = "varchar(11)")]
        [StringLength(11, ErrorMessage = "The {0} must be {1} characters.")]
        [Display(Name = "Mauza Code")]
        public string MauzaCode { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Mauza Name")]
        public string MauzaName { get; set; }

        [Column(Order = 2, TypeName = "nvarchar(150)")]
        [StringLength(150)]
        [Display(Name = "Mauza JL No.")]
        public string MauzaJlNo { get; set; }

        [Column(Order = 3, TypeName = "varchar(4)")]
        [StringLength(4)]
        [Display(Name = "District Code")]
        public string DistCode { get; set; }
        [ForeignKey("DistCode")]
        public virtual DistrictInfo DistrictInfo { get; set; }
        
        [Column(Order = 4, TypeName = "varchar(6)")]
        [StringLength(6)]
        [Display(Name = "Upazila Code")]
        public string UpazCode { get; set; }
        [ForeignKey("UpazCode")]
        public virtual UpazilaInfo UpazilaInfo { get; set; }

        [Column(Order = 5, TypeName = "varchar(8)")]
        [StringLength(8)]
        [Display(Name = "Union Code")]
        public string UnionCode { get; set; }
        [ForeignKey("UnionCode")]
        public virtual UnionInfo UnionInfo { get; set; }
    }
    

}

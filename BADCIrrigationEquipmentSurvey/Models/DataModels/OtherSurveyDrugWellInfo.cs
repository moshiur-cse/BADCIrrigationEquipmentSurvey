using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class OtherSurveyDrugWellInfo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Other Survey Id is required !")]
        [Column("OtherSurveyId", Order = 1, TypeName = "int")]
        [Display(Name = "OtherSurveyId")]
        public int OtherSurveyId { get; set; }
        [ForeignKey("OtherSurveyId")]
        public virtual OtherSurveyInfo OtherSurveyInfo { get; set; }



        /*
                [Required(ErrorMessage = "Survey District is required !")]
                [Column("DistCode", Order = 2, TypeName = "varchar(4)")]
                [StringLength(4)]
                [Display(Name = "District")]
                public string DistCode { get; set; }
                [ForeignKey("DistCode")]
                public virtual DistrictInfo DistrictInfo { get; set; }

                [Required(ErrorMessage = "Survey Upazila is required !")]
                [Column("UpazCode", Order = 3, TypeName = "varchar(6)")]
                [StringLength(6)]
                [Display(Name = "Upazila")]
                public string UpazCode { get; set; }
                [ForeignKey("UpazCode")]
                public virtual UpazilaInfo UpazilaInfo { get; set; }
                */


        //[Required(ErrorMessage = "Survey Union is required !")]
        [Column("UnionCode", Order = 4, TypeName = "varchar(8)")]
        [StringLength(8)]
        [Display(Name = "Union")]
        public string UnionCode { get; set; }
        [ForeignKey("UnionCode")]
        public virtual UnionInfo UnionInfo { get; set; }


        [Column("MauzaName", Order = 5, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Mauza Name")]
        public string MauzaName { get; set; }


        //[Required]
        [Column("JlNo", Order = 6, TypeName = "varchar(10)")]
        [DataType(DataType.Text)]
        [StringLength(10, ErrorMessage = "{0} maximum length must be {1} digit")]
        [Display(Name = "J/L No.")]
        public string JlNo { get; set; }

        //[Required]
        [Column("PlotNo", Order = 7, TypeName = "varchar(10)")]
        [DataType(DataType.Text)]
        [StringLength(10, ErrorMessage = "{0} maximum length must be {1} digit")]
        [Display(Name = "Plot No.")]
        public string PlotNo { get; set; }


        ////[Required]
        //[Column("SurveyDate", Order = 8, TypeName = "date")]
        //[DataType(DataType.Text)]
        //[DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Survey Date")]
        //public DateTime? SurveyDate { get; set; }

        //[Required]
        [Column("NameOfScheme", Order = 9, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Scheme")]
        public string NameOfScheme { get; set; }


        //[Required]
        [Column("OwnerOrManagerName", Order = 5, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Owner/Manager")]
        public string OwnerOrManagerName { get; set; }

        //[Required]
        [Column("OwnerOrManagerMobileNo", Order = 6, TypeName = "nvarchar(15)")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters.", MinimumLength = 11)]
        [Display(Name = "Owner/Manager Mobile No.")]
        public string OwnerOrManagerMobileNo { get; set; }


        //[Required]
        [Column("AgencyCode", Order = 7, TypeName = "int")]
        [Display(Name = "Name of Agency")]
        public int? AgencyCode { get; set; }
        [ForeignKey("AgencyCode")]
        public virtual AgencyInfo AgencyInfo { get; set; }
    }
}

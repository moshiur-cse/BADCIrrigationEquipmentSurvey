using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class OtherSurveyInfoPre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OtherSurveyId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Other Survey Id")]
        public int OtherSurveyId { get; set; }

        [Column("EquipmentId", Order = 1, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Equipment Type")]
        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]
        public virtual EquipmentInfo EquipmentInfo { get; set; }



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
        

        //[Required]
        [Column("SurveyDate", Order = 8, TypeName = "date")]
        [DataType(DataType.Text)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Survey Date")]
        public DateTime? SurveyDate { get; set; }


        [Column("RobiBoroArea", Order = 1, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Boro Area (Acres)")]
        public decimal? RobiBoroArea { get; set; }

        //[Required]
        [Column("RobiWheatArea", Order = 2, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Area (Acres)")]
        public decimal? RobiWheatArea { get; set; }

        //[Required]
        [Column("RobiPotatoArea", Order = 3, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Area (Acres)")]
        public decimal? RobiPotatoArea { get; set; }

        //[Required]
        [Column("RobiMaizeArea", Order = 4, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Area (Acres)")]
        public decimal? RobiMaizeArea { get; set; }

        //[Required]
        [Column("RobiVegWinterArea", Order = 5, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Area (Acres)")]
        public decimal? RobiVegWinterArea { get; set; }

        //[Required]
        [Column("RobiMustardArea", Order = 6, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Mustard Area (Acres)")]
        public decimal? RobiMustardArea { get; set; }

        //[Required]
        [Column("RobiOthersArea", Order = 7, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? RobiOthersArea { get; set; }

        //[Required]
        [Column("RobiBenefitedFarmerMale", Order = 8, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer")]
        public decimal? RobiBenefitedFarmerMale { get; set; }

        //[Required]
        [Column("RobiBenefitedAgricultureLabourMale", Order = 9, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour")]
        public decimal? RobiBenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("Kharif1AusArea", Order = 10, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Aus Area (Acres)")]
        public decimal? Kharif1AusArea { get; set; }

        //[Required]
        [Column("Kharif1JuteArea", Order = 11, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Area (Acres)")]
        public decimal? Kharif1JuteArea { get; set; }

        //[Required]
        [Column("Kharif1VegSummerArea", Order = 12, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Area (Acres)")]
        public decimal? Kharif1VegSummerArea { get; set; }

        //[Required]
        [Column("Kharif1OthersArea", Order = 13, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? Kharif1OthersArea { get; set; }


        //[Required]
        [Column("Kharif1BenefitedFarmerMale", Order = 14, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer")]
        public decimal? Kharif1BenefitedFarmerMale { get; set; }

        //[Required]
        [Column("Kharif1BenefitedAgricultureLabourMale", Order = 15, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour")]
        public decimal? Kharif1BenefitedAgricultureLabourMale { get; set; }


        [Column("Kharif2TAmanArea", Order = 16, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "T-Aman Area (Acres)")]
        public decimal? Kharif2TAmanArea { get; set; }


        [Column("Kharif2OthersArea", Order = 17, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? Kharif2OthersArea { get; set; }

        //[Required]
        [Column("Kharif2BenefitedFarmerMale", Order = 18, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer")]
        public decimal? Kharif2BenefitedFarmerMale { get; set; }

        //[Required]
        [Column("Kharif2BenefitedAgricultureLabourMale", Order = 19, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour")]
        public decimal? Kharif2BenefitedAgricultureLabourMale { get; set; }


    }
}

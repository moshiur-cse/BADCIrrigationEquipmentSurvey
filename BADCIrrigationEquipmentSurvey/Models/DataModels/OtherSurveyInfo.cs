using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class OtherSurveyInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OtherSurveyId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Other Survey Id")]
        public int OtherSurveyId { get; set; }


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
        [Column("SurveyDate", Order = 4, TypeName = "date")]
        [DataType(DataType.Text)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Survey Date")]
        public DateTime? SurveyDate { get; set; }


        [Column("EquipmentId", Order = 5, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Equipment Type")]
        public int EquipmentId { get; set; }
        [ForeignKey("EquipmentId")]
        public virtual EquipmentInfo EquipmentInfo { get; set; }

        //[Required]
        [Column("NoOfEquipmentWellScheme", Order = 6, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "No. of Equipment/Well/Scheme")]
        public decimal? NoOfEquipmentWellScheme { get; set; }


        [Column("RobiBoroArea", Order = 7, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Boro Area (Acres)")]
        public decimal? RobiBoroArea { get; set; }

        //[Required]
        [Column("RobiWheatArea", Order = 8, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Area (Acres)")]
        public decimal? RobiWheatArea { get; set; }

        //[Required]
        [Column("RobiPotatoArea", Order = 9, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Area (Acres)")]
        public decimal? RobiPotatoArea { get; set; }

        //[Required]
        [Column("RobiMaizeArea", Order = 10, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Area (Acres)")]
        public decimal? RobiMaizeArea { get; set; }

        //[Required]
        [Column("RobiVegWinterArea", Order = 11, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Area (Acres)")]
        public decimal? RobiVegWinterArea { get; set; }

        //[Required]
        [Column("RobiMustardArea", Order = 12, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Mustard Area (Acres)")]
        public decimal? RobiMustardArea { get; set; }

        //[Required]
        [Column("RobiOthersArea", Order = 13, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? RobiOthersArea { get; set; }

        //[Required]
        [Column("RobiBenefitedFarmerMale", Order = 14, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer")]
        public decimal? RobiBenefitedFarmerMale { get; set; }

        //[Required]
        [Column("RobiBenefitedAgricultureLabourMale", Order = 15, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour")]
        public decimal? RobiBenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("Kharif1AusArea", Order = 16, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Aus Area (Acres)")]
        public decimal? Kharif1AusArea { get; set; }

        //[Required]
        [Column("Kharif1JuteArea", Order = 17, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Area (Acres)")]
        public decimal? Kharif1JuteArea { get; set; }

        //[Required]
        [Column("Kharif1VegSummerArea", Order = 18, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Area (Acres)")]
        public decimal? Kharif1VegSummerArea { get; set; }

        //[Required]
        [Column("Kharif1OthersArea", Order = 19, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? Kharif1OthersArea { get; set; }


        //[Required]
        [Column("Kharif1BenefitedFarmerMale", Order = 20, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male)")]
        public decimal? Kharif1BenefitedFarmerMale { get; set; }

        //[Required]
        [Column("Kharif1BenefitedFarmerFemale", Order = 21, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female)")]
        public decimal? Kharif1BenefitedFarmerFemale { get; set; }

        //[Required]
        [Column("Kharif1BenefitedAgricultureLabourMale", Order = 22, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male)")]
        public decimal? Kharif1BenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("Kharif1BenefitedAgricultureLabourFemale", Order = 23, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female)")]
        public decimal? Kharif1BenefitedAgricultureLabourFemale { get; set; }


        [Column("Kharif2TAmanArea", Order = 24, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "T-Aman Area (Acres)")]
        public decimal? Kharif2TAmanArea { get; set; }


        [Column("Kharif2OthersArea", Order = 25, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? Kharif2OthersArea { get; set; }

        //[Required]
        [Column("Kharif2BenefitedFarmerMale", Order = 26, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male)")]
        public decimal? Kharif2BenefitedFarmerMale { get; set; }

        //[Required]
        [Column("Kharif2BenefitedFarmerFemale", Order = 27, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female)")]
        public decimal? Kharif2BenefitedFarmerFemale { get; set; }

        //[Required]
        [Column("Kharif2BenefitedAgricultureLabourMale", Order = 28, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour")]
        public decimal? Kharif2BenefitedAgricultureLabourMale { get; set; }
        
        //[Required]
        [Column("Kharif2BenefitedAgricultureLabourFemale", Order = 29, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female)")]
        public decimal? Kharif2BenefitedAgricultureLabourFemale { get; set; }


        [Column("EntryDateTime", Order = 31, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy # h:m}", ApplyFormatInEditMode = true)]
        public DateTime EntryDateTime { get; set; } = DateTime.Now;

        [Column("EntryUserId", Order = 32, TypeName = "nvarchar(20)")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        [Display(Name = "User Id")]
        public string EntryUserId { get; set; }
    }
}

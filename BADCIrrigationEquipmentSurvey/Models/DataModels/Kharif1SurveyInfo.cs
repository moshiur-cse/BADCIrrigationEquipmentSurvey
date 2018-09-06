using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class Kharif1SurveyInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SurveyKharif1Id", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Kharif-1 Survey Id")]
        public int SurveyKharif1Id { get; set; }

        [ForeignKey("SurveyId")]
        public virtual SurveyInfo SurveyInfo { get; set; }


        //[Required]
        [Column("TotalOperatingHour", Order = 1, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total Operating Hour (hr)")]
        public decimal? TotalOperatingHour { get; set; }

        //[Required]
        [Column("AusArea", Order = 2, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Aus Area (Acres)")]
        public decimal? AusArea { get; set; }

        //[Required]
        [Column("JuteArea", Order = 3, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Area (Acres)")]
        public decimal? JuteArea { get; set; }

        //[Required]
        [Column("VegArea", Order = 4, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Area (Acres)")]
        public decimal? VegArea { get; set; }

        //[Required]
        [Column("OthersArea", Order = 5, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? OthersArea { get; set; }



        //[Required]
        [Column("AusCost", Order = 6, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        [Display(Name = "Aus Cost (Tk/Acres)")]
        public decimal? AusCost { get; set; }


        //[Required]
        [Column("JuteCost", Order = 7, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Cost (Tk/Acres)")]
        public decimal? JuteCost { get; set; }

        //[Required]
        [Column("VegCost", Order = 8, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Cost (Tk/Acres)")]
        public decimal? VegCost { get; set; }

        //[Required]
        [Column("OthersCost", Order = 9, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Cost (Tk/Acres)")]
        public decimal? OthersCost { get; set; }

        //[Required]
        [Column("BenefitedFarmerMale", Order = 10, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male)")]
        public decimal? BenefitedFarmerMale { get; set; }

        //[Required]
        [Column("BenefitedFarmerFemale", Order = 11, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female)")]
        public decimal? BenefitedFarmerFemale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourMale", Order = 12, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male)")]
        public decimal? BenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourFemale", Order = 13, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female)")]
        public decimal? BenefitedAgricultureLabourFemale { get; set; }


        //[Required]
        [Column("UseInKharif2Season", Order = 14, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Use in Kharif-2 Season")]
        public bool UseInKharif2Season { get; set; }

    }


}

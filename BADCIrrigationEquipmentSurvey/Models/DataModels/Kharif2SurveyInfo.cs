using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class Kharif2SurveyInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SurveyKharif2Id", Order = 0, TypeName = "int")]
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


        [Column("TAmanArea", Order = 2, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "T-Aman Area (Acres)")]
        public decimal? TAmanArea { get; set; }
        

        [Column("OthersArea", Order = 5, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? OthersArea { get; set; }


        [Column("TAmanCost", Order = 6, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        [Display(Name = "T-Aman Cost (Tk/Acres)")]
        public decimal? TAmanCost { get; set; }
        
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

    }



}

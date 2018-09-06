using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BADCIrrigationEquipmentSurvey.Models.DataModels
{
    public class SurveyInfo
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SurveyId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Survey Id")]
        public int SurveyId { get; set; }

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

        //[Required(ErrorMessage = "Survey Union is required !")]
        [Column("UnionCode", Order = 4, TypeName = "varchar(8)")]
        [StringLength(8)]
        [Display(Name = "Union")]
        public string UnionCode { get; set; }
        [ForeignKey("UnionCode")]
        public virtual UnionInfo UnionInfo { get; set; }


        [Column("MauzaName", Order = 5, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Mauza")]
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


        //[Required]
        [Column("SurveyDate", Order = 8, TypeName = "date")]
        [DataType(DataType.Text)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Survey Date")]
        public DateTime? SurveyDate { get; set; }

        //[Required]
        [Column("NameOfScheme", Order = 9, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Scheme")]
        public string NameOfScheme { get; set; }

        //[Required]
        [Column("OwnerOrManagerName", Order = 10, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Owner/Manager")]
        public string OwnerOrManagerName { get; set; }

        //[Required]
        [Column("OwnerOrManagerMobileNo", Order = 11, TypeName = "nvarchar(15)")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters.", MinimumLength = 11)]
        [Display(Name = "Owner/Manager Mobile No.")]
        public string OwnerOrManagerMobileNo { get; set; }


        //[Required]
        [Column("AgencyCode", Order = 12, TypeName = "int")]
        [Display(Name = "Name of Agency")]
        public int? AgencyCode { get; set; }
        [ForeignKey("AgencyCode")]
        public virtual AgencyInfo AgencyInfo { get; set; }
        //public string NameOfAgency { get; set; }

        //[Required]
        [Column("DieselEngineMakeAndModel", Order = 13, TypeName = "nvarchar(200)")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Diesel Engine Make & Model")]
        public string DieselEngineMakeAndModel { get; set; }

        //[Required]
        [Column("DieselEngineHp", Order = 14, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Diesel Engine HP")]
        public decimal? DieselEngineHp { get; set; }


        //[Required]
        [Column("ElectricMotorMakeAndModel", Order = 15, TypeName = "nvarchar(200)")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Electric Motor Make & Model")]
        public string ElectricMotorMakeAndModel { get; set; }

        //[Required]
        [Column("ElectricMotorKw", Order = 16, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Electric Motor KW")]
        public decimal? ElectricMotorKw { get; set; }

        [Column("EmPowerSourceCode", Order = 17, TypeName = "int")]
        [Display(Name = "Electric Motor Source of Power")]
        public int? EmPowerSourceCode { get; set; }
        [ForeignKey("EmPowerSourceCode")]
        public virtual MotorPowerSourceInfo ElectricMotorPowerSourceInfo { get; set; }
        //public string ElectricMotorSourceOfPower { get; set; }


        //[Required]
        [Column("PumpCapacityInCusec", Order = 18, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Pump Capacity (Cusec)")]
        public decimal? PumpCapacityInCusec { get; set; }


        [Column("SwSourceCode", Order = 19, TypeName = "int")]
        [Display(Name = "Source of Surface Water")]
        public int? SwSourceCode { get; set; }
        [ForeignKey("SwSourceCode")]
        public virtual SurfaceWaterSourceInfo SurfaceWaterSourceInfo { get; set; }

        //[Required]
        [Column(Order = 19, TypeName = "nvarchar(100)")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Display(Name = "Smart Card")]
        public string SmartCard { get; set; }

        //[Required]
        [Column(Order = 19, TypeName = "bit")]
        [Display(Name = "Pit/Non Pit")]
        public bool? IsPit { get; set; }


        //[Required]
        [Column("IsServiceable", Order = 20, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Serviceable/UnServiceable")]
        public bool IsServiceable { get; set; }

        //[Required]
        [Column("TotalOperatingHour", Order = 21, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total Operating Hour")]
        public decimal? TotalOperatingHour { get; set; }


        //[Required]
        [Column("BoroArea", Order = 22, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Boro Area (Acres)")]
        public decimal? BoroArea { get; set; }

        //[Required]
        [Column("WheatArea", Order = 23, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Area (Acres)")]
        public decimal? WheatArea { get; set; }

        //[Required]
        [Column("PotatoArea", Order = 24, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Area (Acres)")]
        public decimal? PotatoArea { get; set; }

        //[Required]
        [Column("MaizeArea", Order = 25, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Area (Acres)")]
        public decimal? MaizeArea { get; set; }

        //[Required]
        [Column("VegWinterArea", Order = 26, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Area (Acres)")]
        public decimal? VegWinterArea { get; set; }

        //[Required]
        [Column("MustardArea", Order = 27, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Mustard Area (Acres)")]
        public decimal? MustardArea { get; set; }

        //[Required]
        [Column("OthersArea", Order = 28, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? OthersArea { get; set; }


        //[Required]
        [Column("BoroCost", Order = 29, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)][Display(Name = "Boro Cost (Tk/Acres)")]
        public decimal? BoroCost { get; set; }

        //[Required]
        [Column("WheatCost", Order = 30, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Cost (Tk/Acres)")]
        public decimal? WheatCost { get; set; }

        //[Required]
        [Column("PotatoCost", Order = 31, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Cost (Tk/Acres)")]
        public decimal? PotatoCost { get; set; }

        //[Required]
        [Column("MaizeCost", Order = 32, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Cost (Tk/Acres)")]
        public decimal? MaizeCost { get; set; }

        //[Required]
        [Column("VegWinterCost", Order = 33, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Cost (Tk/Acres)")]
        public decimal? VegWinterCost { get; set; }

        //[Required]
        [Column("OthersCost", Order = 34, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Cost (Tk/Acres)")]
        public decimal? OthersCost { get; set; }


        //[Required]
        [Column("CanalLengthPacca", Order = 35, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Pacca)")]
        public decimal? CanalLengthPacca { get; set; }

        //[Required]
        [Column("CanalLengthBuriedPipe", Order = 36, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Buried Pipe)")]
        public decimal? CanalLengthBuriedPipe { get; set; }

        //[Required]
        [Column("CanalLengthFitaPipe", Order = 37, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Fita Pipe)")]
        public decimal? CanalLengthFitaPipe { get; set; }

        //[Required]
        [Column("CanalLengthKacha", Order = 38, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Kacha)")]
        public decimal? CanalLengthKacha { get; set; }


        //[Required]
        [Column("BenefitedFarmerMale", Order = 39, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male)")]
        public decimal? BenefitedFarmerMale { get; set; }


        //[Required]
        [Column("BenefitedFarmerFemale", Order = 40, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female)")]
        public decimal? BenefitedFarmerFemale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourMale", Order = 41, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male)")]
        public decimal? BenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourFemale", Order = 42, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female)")]
        public decimal? BenefitedAgricultureLabourFemale { get; set; }


        
        //[Required]
        [Column("UseInKharif1Season", Order = 43, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Use in Kharif-1 Season")]
        public bool UseInKharif1Season { get; set; }


        //[Required]
        [Column("UseInKharif2Season", Order = 43, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Use in Kharif-2 Season")]
        public bool UseInKharif2Season { get; set; }



        //[Required]
        [Column("TotalOperatingHourKh1", Order = 44, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total Operating Hour (hr) Kharif-1")]
        public decimal? TotalOperatingHourKh1 { get; set; }

        //[Required]
        [Column("AusAreaKh1", Order = 45, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Aus Area (Acres) Kharif-1")]
        public decimal? AusAreaKh1 { get; set; }

        //[Required]
        [Column("JuteAreaKh1", Order = 46, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Area (Acres) Kharif-1")]
        public decimal? JuteAreaKh1 { get; set; }

        //[Required]
        [Column("VegAreaKh1", Order = 47, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Area (Acres) Kharif-1")]
        public decimal? VegAreaKh1 { get; set; }

        //[Required]
        [Column("OthersAreaKh1", Order = 48, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres) Kharif-1")]
        public decimal? OthersAreaKh1 { get; set; }
        

        //[Required]
        [Column("AusCostKh1", Order = 49, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        [Display(Name = "Aus Cost (Tk/Acres) Kharif-1")]
        public decimal? AusCostKh1 { get; set; }


        //[Required]
        [Column("JuteCostKh1", Order = 50, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jute Cost (Tk/Acres) Kharif-1")]
        public decimal? JuteCostKh1 { get; set; }

        //[Required]
        [Column("VegCostKh1", Order = 51, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Veg Cost (Tk/Acres) Kharif-1")]
        public decimal? VegCostKh1 { get; set; }

        //[Required]
        [Column("OthersCostKh1", Order = 52, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Cost (Tk/Acres) Kharif-1")]
        public decimal? OthersCostKh1 { get; set; }

        //[Required]
        [Column("BenefitedFarmerMaleKh1", Order = 53, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male) Kharif-1")]
        public decimal? BenefitedFarmerMaleKh1 { get; set; }

        //[Required]
        [Column("BenefitedFarmerFemaleKh1", Order = 54, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female) Kharif-1")]
        public decimal? BenefitedFarmerFemaleKh1 { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourMaleKh1", Order = 55, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male) Kharif-1")]
        public decimal? BenefitedAgricultureLabourMaleKh1 { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourFemaleKh1", Order = 56, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female) Kharif-1")]
        public decimal? BenefitedAgricultureLabourFemaleKh1 { get; set; }




        //[Required]
        [Column("TotalOperatingHourKh2", Order = 58, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total Operating Hour (hr) Kharif-2")]
        public decimal? TotalOperatingHourKh2 { get; set; }


        [Column("TAmanAreaKh2", Order = 59, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "T-Aman Area (Acres) Kharif-2")]
        public decimal? TAmanAreaKh2 { get; set; }


        [Column("OthersAreaKh2", Order = 60, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres) Kharif-2")]
        public decimal? OthersAreaKh2 { get; set; }


        [Column("TAmanCostKh2", Order = 61, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        [Display(Name = "T-Aman Cost (Tk/Acres) Kharif-2")]
        public decimal? TAmanCostKh2 { get; set; }

        [Column("OthersCostKh2", Order = 62, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Cost (Tk/Acres) Kharif-2")]
        public decimal? OthersCostKh2 { get; set; }

        //[Required]
        [Column("BenefitedFarmerMaleKh2", Order = 63, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male) Kharif-2")]
        public decimal? BenefitedFarmerMaleKh2 { get; set; }

        //[Required]
        [Column("BenefitedFarmerFemaleKh2", Order = 64, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female) Kharif-2")]
        public decimal? BenefitedFarmerFemaleKh2 { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourMaleKh2", Order = 65, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male) Kharif-2")]
        public decimal? BenefitedAgricultureLabourMaleKh2 { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourFemaleKh2", Order = 66, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female) Kharif-2")]
        public decimal? BenefitedAgricultureLabourFemaleKh2 { get; set; }



        [Column("EntryDateTime", Order = 67, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy # h:m}", ApplyFormatInEditMode = true)]
        public DateTime EntryDateTime { get; set; } = DateTime.Now;


        [Column("EntryUserId", Order = 68, TypeName = "nvarchar(20)")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        [Display(Name = "User Id")]
        public string EntryUserId { get; set; }

        //[Column("", Order = 0)]


        public bool IsEmpty(bool isBase = false)
        {
            return //(isBase || !SurveyId.HasValue) &&
                   SurveyDate.HasValue &&
                   !string.IsNullOrEmpty(NameOfScheme) &&

                   //!string.IsNullOrEmpty(DistCode) &&
                   //!string.IsNullOrEmpty(UpazCode) &&
                   //!string.IsNullOrEmpty(UnionCode) &&

                   !string.IsNullOrEmpty(MauzaName) &&
                   !string.IsNullOrEmpty(JlNo) &&
                   !string.IsNullOrEmpty(PlotNo) &&

                   AgencyCode.HasValue &&
                   EmPowerSourceCode.HasValue &&
                   SwSourceCode.HasValue &&

                   !string.IsNullOrEmpty(OwnerOrManagerName) &&
                   !string.IsNullOrEmpty(DieselEngineMakeAndModel) &&
                   !string.IsNullOrEmpty(ElectricMotorMakeAndModel) &&

                   PumpCapacityInCusec.HasValue &&
                   TotalOperatingHour.HasValue &&

                   BoroArea.HasValue && BoroCost.HasValue &&
                   WheatArea.HasValue && WheatCost.HasValue &&
                   PotatoArea.HasValue && PotatoCost.HasValue &&
                   MaizeArea.HasValue && MaizeCost.HasValue &&
                   VegWinterArea.HasValue && VegWinterCost.HasValue &&
                   MustardArea.HasValue &&
                   OthersArea.HasValue && OthersCost.HasValue &&

                   CanalLengthPacca.HasValue && CanalLengthBuriedPipe.HasValue &&
                   CanalLengthFitaPipe.HasValue && CanalLengthKacha.HasValue &&

                   BenefitedFarmerMale.HasValue && BenefitedAgricultureLabourMale.HasValue;

        }



        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SurveyId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Survey Id")]
        public int SurveyId { get; set; }

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

        //[Required(ErrorMessage = "Survey Union is required !")]
        [Column("UnionCode", Order = 4, TypeName = "varchar(8)")]
        [StringLength(8)]
        [Display(Name = "Union")]
        public string UnionCode { get; set; }
        [ForeignKey("UnionCode")]
        public virtual UnionInfo UnionInfo { get; set; }

        ////[Required]
        //[Column("MauzaCode", Order = 50, TypeName = "varchar(11)")]
        //[StringLength(11)]
        //[Display(Name = "Mauza")]
        //public string MauzaCode { get; set; }
        //[ForeignKey("MauzaCode")]
        //public virtual MauzaInfo MauzaInfo { get; set; }

        //public string DistCode { get; set; }
        //public string UpazCode { get; set; }
        //public string UnionCode { get; set; }
        //public string MauzaCode { get; set; }

        [Column("MauzaName", Order = 5, TypeName = "nvarchar(250)")]
        [StringLength(250)]
        [Display(Name = "Mauza")]
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


        //[Required]
        [Column("SurveyDate", Order = 8, TypeName = "date")]
        [DataType(DataType.Text)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Survey Date")]
        public DateTime? SurveyDate { get; set; }

        //[Required]
        [Column("NameOfScheme", Order = 9, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Scheme")]
        public string NameOfScheme { get; set; }

        //[Required]
        [Column("OwnerOrManagerName", Order = 10, TypeName = "nvarchar(250)")]
        [DataType(DataType.Text)]
        [StringLength(250)]
        [Display(Name = "Name of Owner/Manager")]
        public string OwnerOrManagerName { get; set; }

        //[Required]
        [Column("OwnerOrManagerMobileNo", Order = 11, TypeName = "nvarchar(15)")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters.", MinimumLength = 11)]
        [Display(Name = "Owner/Manager Mobile No.")]
        public string OwnerOrManagerMobileNo { get; set; }


        //[Required]
        [Column("AgencyCode", Order = 12, TypeName = "int")]
        [Display(Name = "Name of Agency")]
        public int? AgencyCode { get; set; }
        [ForeignKey("AgencyCode")]
        public virtual AgencyInfo AgencyInfo { get; set; }
        //public string NameOfAgency { get; set; }

        //[Required]
        [Column("DieselEngineMakeAndModel", Order = 13, TypeName = "nvarchar(200)")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Diesel Engine Make & Model")]
        public string DieselEngineMakeAndModel { get; set; }

        //[Required]
        [Column("DieselEngineHp", Order = 14, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Diesel Engine HP")]
        public decimal? DieselEngineHp { get; set; }


        //[Required]
        [Column("ElectricMotorMakeAndModel", Order = 15, TypeName = "nvarchar(200)")]
        [DataType(DataType.Text)]
        [StringLength(200)]
        [Display(Name = "Electric Motor Make & Model")]
        public string ElectricMotorMakeAndModel { get; set; }

        //[Required]
        [Column("ElectricMotorKw", Order = 16, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Electric Motor KW")]
        public decimal? ElectricMotorKw { get; set; }

        [Column("EmPowerSourceCode", Order = 17, TypeName = "int")]
        [Display(Name = "Electric Motor Source of Power")]
        public int? EmPowerSourceCode { get; set; }
        [ForeignKey("EmPowerSourceCode")]
        public virtual MotorPowerSourceInfo ElectricMotorPowerSourceInfo { get; set; }
        //public string ElectricMotorSourceOfPower { get; set; }


        //[Required]
        [Column("PumpCapacityInCusec", Order = 18, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Pump Capacity (Cusec)")]
        public decimal? PumpCapacityInCusec { get; set; }


        [Column("SwSourceCode", Order = 19, TypeName = "int")]
        [Display(Name = "Source of Surface Water")]
        public int? SwSourceCode { get; set; }
        [ForeignKey("SwSourceCode")]
        public virtual SurfaceWaterSourceInfo SurfaceWaterSourceInfo { get; set; }

        //[Required]
        [Column(Order = 19, TypeName = "nvarchar(100)")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Display(Name = "Smart Card")]
        public string SmartCard { get; set; }
        
        //[Required]
        [Column(Order = 19, TypeName = "bit")]
        [Display(Name = "Pit/Non Pit")]
        public bool? IsPit { get; set; }
        

        //[Required]
        [Column("IsServiceable", Order = 20, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Serviceable/UnServiceable")]
        public bool IsServiceable { get; set; }

        //[Required]
        [Column("TotalOperatingHour", Order = 21, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total Operating Hour")]
        public decimal? TotalOperatingHour { get; set; }


        //[Required]
        [Column("BoroArea", Order = 22, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        [Display(Name = "Boro Area (Acres)")]
        public decimal? BoroArea { get; set; }

        //[Required]
        [Column("WheatArea", Order = 23, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Area (Acres)")]
        public decimal? WheatArea { get; set; }

        //[Required]
        [Column("PotatoArea", Order = 24, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Area (Acres)")]
        public decimal? PotatoArea { get; set; }

        //[Required]
        [Column("MaizeArea", Order = 25, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Area (Acres)")]
        public decimal? MaizeArea { get; set; }

        //[Required]
        [Column("VegWinterArea", Order = 26, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Area (Acres)")]
        public decimal? VegWinterArea { get; set; }

        //[Required]
        [Column("MustardArea", Order = 27, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Mustard Area (Acres)")]
        public decimal? MustardArea { get; set; }

        //[Required]
        [Column("OthersArea", Order = 28, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Area (Acres)")]
        public decimal? OthersArea { get; set; }


        //[Required]
        [Column("BoroCost", Order = 29, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)][Display(Name = "Boro Cost (Tk/Acres)")]
        public decimal? BoroCost { get; set; }

        //[Required]
        [Column("WheatCost", Order = 30, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Wheat Cost (Tk/Acres)")]
        public decimal? WheatCost { get; set; }

        //[Required]
        [Column("PotatoCost", Order = 31, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Potato Cost (Tk/Acres)")]
        public decimal? PotatoCost { get; set; }

        //[Required]
        [Column("MaizeCost", Order = 32, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maize Cost (Tk/Acres)")]
        public decimal? MaizeCost { get; set; }

        //[Required]
        [Column("VegWinterCost", Order = 33, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "VegWinter Cost (Tk/Acres)")]
        public decimal? VegWinterCost { get; set; }

        //[Required]
        [Column("OthersCost", Order = 34, TypeName = "decimal(12, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 9999999999.99, ErrorMessage = "Invalid {0}; Max 12 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Others Cost (Tk/Acres)")]
        public decimal? OthersCost { get; set; }


        //[Required]
        [Column("CanalLengthPacca", Order = 35, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Pacca)")]
        public decimal? CanalLengthPacca { get; set; }

        //[Required]
        [Column("CanalLengthBuriedPipe", Order = 36, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Buried Pipe)")]
        public decimal? CanalLengthBuriedPipe { get; set; }

        //[Required]
        [Column("CanalLengthFitaPipe", Order = 37, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Fita Pipe)")]
        public decimal? CanalLengthFitaPipe { get; set; }

        //[Required]
        [Column("CanalLengthKacha", Order = 38, TypeName = "decimal(10, 2)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0.00", DataFormatString = "{0:d2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Canal Length (Kacha)")]
        public decimal? CanalLengthKacha { get; set; }


        //[Required]
        [Column("BenefitedFarmerMale", Order = 39, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Male)")]
        public decimal? BenefitedFarmerMale { get; set; }


        //[Required]
        [Column("BenefitedFarmerFemale", Order = 39, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Farmer (Female)")]
        public decimal? BenefitedFarmerFemale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourMale", Order = 40, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Male)")]
        public decimal? BenefitedAgricultureLabourMale { get; set; }

        //[Required]
        [Column("BenefitedAgricultureLabourFemale", Order = 40, TypeName = "decimal(10, 0)")]
        [DataType(DataType.Text)]
        [Range(0, 99999999.99, ErrorMessage = "Invalid {0}; Max 10 digits")]
        //[DisplayFormat(NullDisplayText = "0", DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Benefited Agriculture Labour (Female)")]
        public decimal? BenefitedAgricultureLabourFemale { get; set; }


        ////[Required]
        //[Column("IsServiceable", Order = 390, TypeName = "bit")]
        ////[DataType(DataType.Text)]
        //[Display(Name = "Serviceable/UnServiceable")]
        //public bool IsServiceable { get; set; }

        //[Required]
        [Column("UseInKharif1Season", Order = 41, TypeName = "bit")]
        //[DataType(DataType.Text)]
        [Display(Name = "Use in Kharif-1 Season")]
        public bool UseInKharif1Season { get; set; }


        [Column("EntryDateTime", Order = 42, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:dd-MM-yyyy # h:m}", ApplyFormatInEditMode = true)]
        public DateTime EntryDateTime { get; set; } = DateTime.Now;


        [Column("EntryUserId", Order = 43, TypeName = "nvarchar(20)")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        [Display(Name = "User Id")]
        public string EntryUserId { get; set; }

        //[Column("", Order = 0)]
        

        public bool IsEmpty(bool isBase = false)
        {
            return //(isBase || !SurveyId.HasValue) &&
                   SurveyDate.HasValue &&
                   !string.IsNullOrEmpty(NameOfScheme) &&

                   //!string.IsNullOrEmpty(DistCode) &&
                   //!string.IsNullOrEmpty(UpazCode) &&
                   //!string.IsNullOrEmpty(UnionCode) &&

                   !string.IsNullOrEmpty(MauzaName) &&
                   !string.IsNullOrEmpty(JlNo) &&
                   !string.IsNullOrEmpty(PlotNo) &&

                   AgencyCode.HasValue &&
                   EmPowerSourceCode.HasValue &&
                   SwSourceCode.HasValue &&

                   !string.IsNullOrEmpty(OwnerOrManagerName) &&
                   !string.IsNullOrEmpty(DieselEngineMakeAndModel) &&
                   !string.IsNullOrEmpty(ElectricMotorMakeAndModel) &&

                   PumpCapacityInCusec.HasValue &&
                   TotalOperatingHour.HasValue &&

                   BoroArea.HasValue && BoroCost.HasValue &&
                   WheatArea.HasValue && WheatCost.HasValue &&
                   PotatoArea.HasValue && PotatoCost.HasValue &&
                   MaizeArea.HasValue && MaizeCost.HasValue &&
                   VegWinterArea.HasValue && VegWinterCost.HasValue &&
                   MustardArea.HasValue &&
                   OthersArea.HasValue && OthersCost.HasValue &&

                   CanalLengthPacca.HasValue && CanalLengthBuriedPipe.HasValue &&
                   CanalLengthFitaPipe.HasValue && CanalLengthKacha.HasValue &&

                   BenefitedFarmerMale.HasValue && BenefitedAgricultureLabourMale.HasValue;

        }
        */

    }

}

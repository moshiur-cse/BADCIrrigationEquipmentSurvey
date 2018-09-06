using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BADCIrrigationEquipmentSurvey.Models.DataModels;
using BADCIrrigationEquipmentSurvey.Models.ViewModels;


namespace BADCIrrigationEquipmentSurvey.DbContexts
{
    public partial class BadcDbContext : DbContext
    {
        public virtual DbSet<DivisionInfo> DivisionInfoes { get; set; }
        public virtual DbSet<DistrictInfo> DistrictInfoes { get; set; }
        public virtual DbSet<UpazilaInfo> UpazilaInfoes { get; set; }
        public virtual DbSet<UnionInfo> UnionInfoes { get; set; }
        public virtual DbSet<MauzaInfo> MauzaInfoes { get; set; }

        public virtual DbSet<SeasonInfo> SeasonInfoes { get; set; }
        public virtual DbSet<CropInfo> CropInfoes { get; set; }

        public virtual DbSet<EquipmentInfo> EquipmentInfoes { get; set; }
        public virtual DbSet<EquipmentTypeInfo> EquipmentTypeInfoes { get; set; }

        public virtual DbSet<AgencyInfo> AgencyInfoes { get; set; }
        public virtual DbSet<MotorPowerSourceInfo> MotorPowerSourceInfoes { get; set; }
        public virtual DbSet<SurfaceWaterSourceInfo> SurfaceWaterSourceInfoes { get; set; }


        public virtual DbSet<SurveyInfo> SurveyInfoes { get; set; }
        public virtual DbSet<Kharif1SurveyInfo> Kharif1SurveyInfo { get; set; }
        public virtual DbSet<Kharif2SurveyInfo> Kharif2SurveyInfo { get; set; }
        public virtual DbSet<OtherSurveyInfo> OtherSurveyInfo { get; set; }


        public virtual DbSet<ViewCategoryInfo> ViewCategoryInfoes { get; set; }
        public virtual DbSet<ViewSubCategoryInfo> ViewSubCategoryInfoes { get; set; }
        public virtual DbSet<ViewSubSubCategoryInfo> ViewSubSubCategoryInfoes { get; set; }

        //public virtual DbSet<LowLiftPumpInfo> LowLiftPumpInfoes { get; set; }
        //public virtual DbSet<DeepTubeWellInfo> DeepTubeWellSurveyInfoes { get; set; }
        //public virtual DbSet<ShallowTubeWellInfo> ShallowTubeWellSurveyInfoes { get; set; }



        public BadcDbContext() { }

        public BadcDbContext(DbContextOptions<BadcDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<DivisionInfo>().ToTable("LookUpDivisions");
            modelBuilder.Entity<DistrictInfo>().ToTable("LookUpDistricts");
            modelBuilder.Entity<UpazilaInfo>().ToTable("LookUpUpazilas");
            modelBuilder.Entity<UnionInfo>().ToTable("LookUpUnions");
            modelBuilder.Entity<MauzaInfo>().ToTable("LookUpMauzas");

            modelBuilder.Entity<EquipmentInfo>().ToTable("LookUpEquipmentInfoes");
            modelBuilder.Entity<EquipmentTypeInfo>().ToTable("LookUpEquipmentTypeInfoes");

            modelBuilder.Entity<SeasonInfo>().ToTable("LookUpSeasonInfoes");
            modelBuilder.Entity<CropInfo>().ToTable("LookUpCropInfoes");

            //modelBuilder.Entity<SurveyTypeInfo>().ToTable("LookUpSurveyTypeInfoes");

            modelBuilder.Entity<AgencyInfo>().ToTable("LookUpAgencies");
            modelBuilder.Entity<MotorPowerSourceInfo>().ToTable("LookUpMotorPowerSources");
            modelBuilder.Entity<SurfaceWaterSourceInfo>().ToTable("LookUpSurfaceWaterSources");

            //modelBuilder.Entity<LowLiftPumpInfo>().ToTable("TblLowLiftPumpInfoes");
            //modelBuilder.Entity<DeepTubeWellInfo>().ToTable("TblDeepTubeWellSurveyInfoes");
            //modelBuilder.Entity<ShallowTubeWellInfo>().ToTable("TblShallowTubeWellSurveyInfoes");


            modelBuilder.Entity<SurveyInfo>().ToTable("TblSurveyInfoes");
            modelBuilder.Entity<OtherSurveyInfo>().ToTable("TblOtherSurveyInfoes");
            modelBuilder.Entity<OtherSurveyDrugWellInfo>().ToTable("TblOtherSurveyDrugWellInfoes");


            modelBuilder.Entity<Kharif1SurveyInfo>().ToTable("TblKharif1SurveyInfoes");
            modelBuilder.Entity<Kharif2SurveyInfo>().ToTable("TblKharif2SurveyInfoes");


            modelBuilder.Entity<ViewCategoryInfo>().ToTable("LookUpViewCategoryInfoes");
            modelBuilder.Entity<ViewSubCategoryInfo>().ToTable("LookUpViewSubCategoryInfoes");
            modelBuilder.Entity<ViewSubSubCategoryInfo>().ToTable("LookUpViewSubSubCategoryInfoes");

        }



    }
}

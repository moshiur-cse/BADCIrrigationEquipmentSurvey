using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BADCIrrigationEquipmentSurvey.DbContexts.Migrations.BadcDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookUpAgencies",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfAgency = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpAgencies", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "LookUpDivisions",
                columns: table => new
                {
                    DivCode = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    DivName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpDivisions", x => x.DivCode);
                });

            migrationBuilder.CreateTable(
                name: "LookUpEquipmentTypeInfoes",
                columns: table => new
                {
                    EquipmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentType = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpEquipmentTypeInfoes", x => x.EquipmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LookUpMotorPowerSources",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ElectricMotorSourceOfPower = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpMotorPowerSources", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "LookUpSeasonInfoes",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpSeasonInfoes", x => x.SeasonId);
                });

            migrationBuilder.CreateTable(
                name: "LookUpSurfaceWaterSources",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SourceOfSurfaceWater = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpSurfaceWaterSources", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "LookUpViewCategoryInfoes",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpViewCategoryInfoes", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "LookUpDistricts",
                columns: table => new
                {
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false),
                    DistName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DivCode = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpDistricts", x => x.DistCode);
                    table.ForeignKey(
                        name: "FK_LookUpDistricts_LookUpDivisions_DivCode",
                        column: x => x.DivCode,
                        principalTable: "LookUpDivisions",
                        principalColumn: "DivCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LookUpEquipmentInfoes",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentTypeId = table.Column<int>(type: "int", nullable: false),
                    NameOfEquipment = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpEquipmentInfoes", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_LookUpEquipmentInfoes_LookUpEquipmentTypeInfoes_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "LookUpEquipmentTypeInfoes",
                        principalColumn: "EquipmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUpCropInfoes",
                columns: table => new
                {
                    CropId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonId = table.Column<int>(type: "int", nullable: false),
                    CropName = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpCropInfoes", x => x.CropId);
                    table.ForeignKey(
                        name: "FK_LookUpCropInfoes_LookUpSeasonInfoes_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "LookUpSeasonInfoes",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUpViewSubCategoryInfoes",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategory = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpViewSubCategoryInfoes", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_LookUpViewSubCategoryInfoes_LookUpViewCategoryInfoes_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "LookUpViewCategoryInfoes",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUpUpazilas",
                columns: table => new
                {
                    UpazCode = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    UpazName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpUpazilas", x => x.UpazCode);
                    table.ForeignKey(
                        name: "FK_LookUpUpazilas_LookUpDistricts_DistCode",
                        column: x => x.DistCode,
                        principalTable: "LookUpDistricts",
                        principalColumn: "DistCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LookUpViewSubSubCategoryInfoes",
                columns: table => new
                {
                    SubSubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    SubSubCategory = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpViewSubSubCategoryInfoes", x => x.SubSubCategoryId);
                    table.ForeignKey(
                        name: "FK_LookUpViewSubSubCategoryInfoes_LookUpViewSubCategoryInfoes_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "LookUpViewSubCategoryInfoes",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUpUnions",
                columns: table => new
                {
                    UnionCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    UnionName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true),
                    UpazCode = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpUnions", x => x.UnionCode);
                    table.ForeignKey(
                        name: "FK_LookUpUnions_LookUpDistricts_DistCode",
                        column: x => x.DistCode,
                        principalTable: "LookUpDistricts",
                        principalColumn: "DistCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LookUpUnions_LookUpUpazilas_UpazCode",
                        column: x => x.UpazCode,
                        principalTable: "LookUpUpazilas",
                        principalColumn: "UpazCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOtherSurveyInfoes",
                columns: table => new
                {
                    OtherSurveyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false),
                    UpazCode = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "date", nullable: true),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    NoOfEquipmentWellScheme = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    RobiBoroArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiWheatArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiPotatoArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiMaizeArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiVegWinterArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiMustardArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiOthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    RobiBenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    RobiBenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif1AusArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif1JuteArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif1VegSummerArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif1OthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif1BenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif1BenefitedFarmerFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif1BenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif1BenefitedAgricultureLabourFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif2TAmanArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif2OthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Kharif2BenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif2BenefitedFarmerFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif2BenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    Kharif2BenefitedAgricultureLabourFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    EntryDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EntryUserId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOtherSurveyInfoes", x => x.OtherSurveyId);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyInfoes_LookUpDistricts_DistCode",
                        column: x => x.DistCode,
                        principalTable: "LookUpDistricts",
                        principalColumn: "DistCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyInfoes_LookUpEquipmentInfoes_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "LookUpEquipmentInfoes",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyInfoes_LookUpUpazilas_UpazCode",
                        column: x => x.UpazCode,
                        principalTable: "LookUpUpazilas",
                        principalColumn: "UpazCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookUpMauzas",
                columns: table => new
                {
                    MauzaCode = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    MauzaName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MauzaJlNo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true),
                    UpazCode = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true),
                    UnionCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpMauzas", x => x.MauzaCode);
                    table.ForeignKey(
                        name: "FK_LookUpMauzas_LookUpDistricts_DistCode",
                        column: x => x.DistCode,
                        principalTable: "LookUpDistricts",
                        principalColumn: "DistCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LookUpMauzas_LookUpUnions_UnionCode",
                        column: x => x.UnionCode,
                        principalTable: "LookUpUnions",
                        principalColumn: "UnionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LookUpMauzas_LookUpUpazilas_UpazCode",
                        column: x => x.UpazCode,
                        principalTable: "LookUpUpazilas",
                        principalColumn: "UpazCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblSurveyInfoes",
                columns: table => new
                {
                    SurveyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    DistCode = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false),
                    UpazCode = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false),
                    UnionCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true),
                    MauzaName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    JlNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    PlotNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    SurveyDate = table.Column<DateTime>(type: "date", nullable: true),
                    NameOfScheme = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OwnerOrManagerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OwnerOrManagerMobileNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AgencyCode = table.Column<int>(type: "int", nullable: true),
                    DieselEngineMakeAndModel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DieselEngineHp = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    ElectricMotorMakeAndModel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ElectricMotorKw = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    EmPowerSourceCode = table.Column<int>(type: "int", nullable: true),
                    PumpCapacityInCusec = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    SwSourceCode = table.Column<int>(type: "int", nullable: true),
                    SmartCard = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsPit = table.Column<bool>(type: "bit", nullable: true),
                    IsServiceable = table.Column<bool>(type: "bit", nullable: false),
                    TotalOperatingHour = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    BoroArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    WheatArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    PotatoArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    MaizeArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    VegWinterArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    MustardArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    OthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    BoroCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    WheatCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    PotatoCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    MaizeCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    VegWinterCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    OthersCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    CanalLengthPacca = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    CanalLengthBuriedPipe = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    CanalLengthFitaPipe = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    CanalLengthKacha = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    BenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedFarmerFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    UseInKharif1Season = table.Column<bool>(type: "bit", nullable: false),
                    EntryDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EntryUserId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSurveyInfoes", x => x.SurveyId);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpAgencies_AgencyCode",
                        column: x => x.AgencyCode,
                        principalTable: "LookUpAgencies",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpDistricts_DistCode",
                        column: x => x.DistCode,
                        principalTable: "LookUpDistricts",
                        principalColumn: "DistCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpMotorPowerSources_EmPowerSourceCode",
                        column: x => x.EmPowerSourceCode,
                        principalTable: "LookUpMotorPowerSources",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpEquipmentInfoes_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "LookUpEquipmentInfoes",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpSurfaceWaterSources_SwSourceCode",
                        column: x => x.SwSourceCode,
                        principalTable: "LookUpSurfaceWaterSources",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpUnions_UnionCode",
                        column: x => x.UnionCode,
                        principalTable: "LookUpUnions",
                        principalColumn: "UnionCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSurveyInfoes_LookUpUpazilas_UpazCode",
                        column: x => x.UpazCode,
                        principalTable: "LookUpUpazilas",
                        principalColumn: "UpazCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblOtherSurveyDrugWellInfoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OtherSurveyId = table.Column<int>(type: "int", nullable: false),
                    UnionCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true),
                    MauzaName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    JlNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    PlotNo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    NameOfScheme = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OwnerOrManagerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OwnerOrManagerMobileNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AgencyCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOtherSurveyDrugWellInfoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyDrugWellInfoes_LookUpAgencies_AgencyCode",
                        column: x => x.AgencyCode,
                        principalTable: "LookUpAgencies",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyDrugWellInfoes_TblOtherSurveyInfoes_OtherSurveyId",
                        column: x => x.OtherSurveyId,
                        principalTable: "TblOtherSurveyInfoes",
                        principalColumn: "OtherSurveyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblOtherSurveyDrugWellInfoes_LookUpUnions_UnionCode",
                        column: x => x.UnionCode,
                        principalTable: "LookUpUnions",
                        principalColumn: "UnionCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblKharif1SurveyInfoes",
                columns: table => new
                {
                    SurveyKharif1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyId = table.Column<int>(nullable: true),
                    TotalOperatingHour = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    AusArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    JuteArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    VegArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    OthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    AusCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    JuteCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    VegCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    OthersCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    BenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedFarmerFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    UseInKharif2Season = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKharif1SurveyInfoes", x => x.SurveyKharif1Id);
                    table.ForeignKey(
                        name: "FK_TblKharif1SurveyInfoes_TblSurveyInfoes_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "TblSurveyInfoes",
                        principalColumn: "SurveyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblKharif2SurveyInfoes",
                columns: table => new
                {
                    SurveyKharif2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyId = table.Column<int>(nullable: true),
                    TotalOperatingHour = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    TAmanArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    OthersArea = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    TAmanCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    OthersCost = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    BenefitedFarmerMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedFarmerFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourMale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true),
                    BenefitedAgricultureLabourFemale = table.Column<decimal>(type: "decimal(10, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKharif2SurveyInfoes", x => x.SurveyKharif2Id);
                    table.ForeignKey(
                        name: "FK_TblKharif2SurveyInfoes_TblSurveyInfoes_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "TblSurveyInfoes",
                        principalColumn: "SurveyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LookUpCropInfoes_SeasonId",
                table: "LookUpCropInfoes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpDistricts_DivCode",
                table: "LookUpDistricts",
                column: "DivCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpEquipmentInfoes_EquipmentTypeId",
                table: "LookUpEquipmentInfoes",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpMauzas_DistCode",
                table: "LookUpMauzas",
                column: "DistCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpMauzas_UnionCode",
                table: "LookUpMauzas",
                column: "UnionCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpMauzas_UpazCode",
                table: "LookUpMauzas",
                column: "UpazCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpUnions_DistCode",
                table: "LookUpUnions",
                column: "DistCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpUnions_UpazCode",
                table: "LookUpUnions",
                column: "UpazCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpUpazilas_DistCode",
                table: "LookUpUpazilas",
                column: "DistCode");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpViewSubCategoryInfoes_CategoryId",
                table: "LookUpViewSubCategoryInfoes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LookUpViewSubSubCategoryInfoes_SubCategoryId",
                table: "LookUpViewSubSubCategoryInfoes",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TblKharif1SurveyInfoes_SurveyId",
                table: "TblKharif1SurveyInfoes",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblKharif2SurveyInfoes_SurveyId",
                table: "TblKharif2SurveyInfoes",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyDrugWellInfoes_AgencyCode",
                table: "TblOtherSurveyDrugWellInfoes",
                column: "AgencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyDrugWellInfoes_OtherSurveyId",
                table: "TblOtherSurveyDrugWellInfoes",
                column: "OtherSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyDrugWellInfoes_UnionCode",
                table: "TblOtherSurveyDrugWellInfoes",
                column: "UnionCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyInfoes_DistCode",
                table: "TblOtherSurveyInfoes",
                column: "DistCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyInfoes_EquipmentId",
                table: "TblOtherSurveyInfoes",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOtherSurveyInfoes_UpazCode",
                table: "TblOtherSurveyInfoes",
                column: "UpazCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_AgencyCode",
                table: "TblSurveyInfoes",
                column: "AgencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_DistCode",
                table: "TblSurveyInfoes",
                column: "DistCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_EmPowerSourceCode",
                table: "TblSurveyInfoes",
                column: "EmPowerSourceCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_EquipmentId",
                table: "TblSurveyInfoes",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_SwSourceCode",
                table: "TblSurveyInfoes",
                column: "SwSourceCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_UnionCode",
                table: "TblSurveyInfoes",
                column: "UnionCode");

            migrationBuilder.CreateIndex(
                name: "IX_TblSurveyInfoes_UpazCode",
                table: "TblSurveyInfoes",
                column: "UpazCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LookUpCropInfoes");

            migrationBuilder.DropTable(
                name: "LookUpMauzas");

            migrationBuilder.DropTable(
                name: "LookUpViewSubSubCategoryInfoes");

            migrationBuilder.DropTable(
                name: "TblKharif1SurveyInfoes");

            migrationBuilder.DropTable(
                name: "TblKharif2SurveyInfoes");

            migrationBuilder.DropTable(
                name: "TblOtherSurveyDrugWellInfoes");

            migrationBuilder.DropTable(
                name: "LookUpSeasonInfoes");

            migrationBuilder.DropTable(
                name: "LookUpViewSubCategoryInfoes");

            migrationBuilder.DropTable(
                name: "TblSurveyInfoes");

            migrationBuilder.DropTable(
                name: "TblOtherSurveyInfoes");

            migrationBuilder.DropTable(
                name: "LookUpViewCategoryInfoes");

            migrationBuilder.DropTable(
                name: "LookUpAgencies");

            migrationBuilder.DropTable(
                name: "LookUpMotorPowerSources");

            migrationBuilder.DropTable(
                name: "LookUpSurfaceWaterSources");

            migrationBuilder.DropTable(
                name: "LookUpUnions");

            migrationBuilder.DropTable(
                name: "LookUpEquipmentInfoes");

            migrationBuilder.DropTable(
                name: "LookUpUpazilas");

            migrationBuilder.DropTable(
                name: "LookUpEquipmentTypeInfoes");

            migrationBuilder.DropTable(
                name: "LookUpDistricts");

            migrationBuilder.DropTable(
                name: "LookUpDivisions");
        }
    }
}

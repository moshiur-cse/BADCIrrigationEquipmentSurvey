using Microsoft.EntityFrameworkCore.Migrations;

namespace BADCIrrigationEquipmentSurvey.DbContexts.Migrations.BadcDb
{
    public partial class survey_combine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AusAreaKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AusCostKh1",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedAgricultureLabourFemaleKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedAgricultureLabourFemaleKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedAgricultureLabourMaleKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedAgricultureLabourMaleKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedFarmerFemaleKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedFarmerFemaleKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedFarmerMaleKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BenefitedFarmerMaleKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JuteAreaKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JuteCostKh1",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OthersAreaKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OthersAreaKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OthersCostKh1",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OthersCostKh2",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TAmanAreaKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TAmanCostKh2",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalOperatingHourKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalOperatingHourKh2",
                table: "TblSurveyInfoes",
                type: "decimal(10, 0)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UseInKharif2Season",
                table: "TblSurveyInfoes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "VegAreaKh1",
                table: "TblSurveyInfoes",
                type: "decimal(10, 2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "VegCostKh1",
                table: "TblSurveyInfoes",
                type: "decimal(12, 2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AusAreaKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "AusCostKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedAgricultureLabourFemaleKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedAgricultureLabourFemaleKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedAgricultureLabourMaleKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedAgricultureLabourMaleKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedFarmerFemaleKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedFarmerFemaleKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedFarmerMaleKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "BenefitedFarmerMaleKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "JuteAreaKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "JuteCostKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "OthersAreaKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "OthersAreaKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "OthersCostKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "OthersCostKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "TAmanAreaKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "TAmanCostKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "TotalOperatingHourKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "TotalOperatingHourKh2",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "UseInKharif2Season",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "VegAreaKh1",
                table: "TblSurveyInfoes");

            migrationBuilder.DropColumn(
                name: "VegCostKh1",
                table: "TblSurveyInfoes");
        }
    }
}

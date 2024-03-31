using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurbarSalesApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenerateListDataId",
                table: "UpazillaSalesCentre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CtgType",
                table: "GenerateListData",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenerateListDataId",
                table: "DistrictSalesCentre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenerateListDataId",
                table: "UpazillaSalesCentre");

            migrationBuilder.DropColumn(
                name: "CtgType",
                table: "GenerateListData");

            migrationBuilder.DropColumn(
                name: "GenerateListDataId",
                table: "DistrictSalesCentre");
        }
    }
}

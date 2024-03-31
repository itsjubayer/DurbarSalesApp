using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurbarSalesApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenerateListDataId",
                table: "UpazillaSalesCentre");

            migrationBuilder.DropColumn(
                name: "GenerateListDataId",
                table: "DistrictSalesCentre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenerateListDataId",
                table: "UpazillaSalesCentre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenerateListDataId",
                table: "DistrictSalesCentre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

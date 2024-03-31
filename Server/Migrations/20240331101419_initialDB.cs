using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DurbarSalesApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegionalOffices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionalOfficeName = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegionalStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionalStoreName = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenerateListData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionalOfficeId = table.Column<int>(type: "int", nullable: false),
                    RegionalStoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerateListData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenerateListData_RegionalOffices_RegionalOfficeId",
                        column: x => x.RegionalOfficeId,
                        principalTable: "RegionalOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerateListData_RegionalStores_RegionalStoreId",
                        column: x => x.RegionalStoreId,
                        principalTable: "RegionalStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistrictSalesCentre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RegionalOfficeId = table.Column<int>(type: "int", nullable: false),
                    RegionalStoreId = table.Column<int>(type: "int", nullable: false),
                    CtgType = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    GenerateListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictSalesCentre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistrictSalesCentre_GenerateListData_GenerateListId",
                        column: x => x.GenerateListId,
                        principalTable: "GenerateListData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DistrictSalesCentre_RegionalOffices_RegionalOfficeId",
                        column: x => x.RegionalOfficeId,
                        principalTable: "RegionalOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistrictSalesCentre_RegionalStores_RegionalStoreId",
                        column: x => x.RegionalStoreId,
                        principalTable: "RegionalStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UpazillaSalesCentre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpazillaName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    RegionalOfficeId = table.Column<int>(type: "int", nullable: false),
                    RegionalStoreId = table.Column<int>(type: "int", nullable: false),
                    CtgType = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    GenerateListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpazillaSalesCentre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpazillaSalesCentre_GenerateListData_GenerateListId",
                        column: x => x.GenerateListId,
                        principalTable: "GenerateListData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UpazillaSalesCentre_RegionalOffices_RegionalOfficeId",
                        column: x => x.RegionalOfficeId,
                        principalTable: "RegionalOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpazillaSalesCentre_RegionalStores_RegionalStoreId",
                        column: x => x.RegionalStoreId,
                        principalTable: "RegionalStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistrictSalesCentre_GenerateListId",
                table: "DistrictSalesCentre",
                column: "GenerateListId");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictSalesCentre_RegionalOfficeId",
                table: "DistrictSalesCentre",
                column: "RegionalOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_DistrictSalesCentre_RegionalStoreId",
                table: "DistrictSalesCentre",
                column: "RegionalStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerateListData_RegionalOfficeId",
                table: "GenerateListData",
                column: "RegionalOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerateListData_RegionalStoreId",
                table: "GenerateListData",
                column: "RegionalStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UpazillaSalesCentre_GenerateListId",
                table: "UpazillaSalesCentre",
                column: "GenerateListId");

            migrationBuilder.CreateIndex(
                name: "IX_UpazillaSalesCentre_RegionalOfficeId",
                table: "UpazillaSalesCentre",
                column: "RegionalOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_UpazillaSalesCentre_RegionalStoreId",
                table: "UpazillaSalesCentre",
                column: "RegionalStoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistrictSalesCentre");

            migrationBuilder.DropTable(
                name: "UpazillaSalesCentre");

            migrationBuilder.DropTable(
                name: "GenerateListData");

            migrationBuilder.DropTable(
                name: "RegionalOffices");

            migrationBuilder.DropTable(
                name: "RegionalStores");
        }
    }
}

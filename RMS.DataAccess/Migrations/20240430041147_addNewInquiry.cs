using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addNewInquiry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionEntries_MaterialMasterOverviews_MaterialId",
                table: "ConsumptionEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsumptionEntries_Plants_PlantCustomerId",
                table: "ConsumptionEntries");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionEntries_MaterialId",
                table: "ConsumptionEntries");

            migrationBuilder.DropIndex(
                name: "IX_ConsumptionEntries_PlantCustomerId",
                table: "ConsumptionEntries");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "ConsumptionEntries");

            migrationBuilder.DropColumn(
                name: "PlantCustomerId",
                table: "ConsumptionEntries");

            migrationBuilder.CreateTable(
                name: "NewInquiry",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<int>(type: "int", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UOM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedDelivery = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewInquiry", x => x.No);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewInquiry");

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "ConsumptionEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantCustomerId",
                table: "ConsumptionEntries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionEntries_MaterialId",
                table: "ConsumptionEntries",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionEntries_PlantCustomerId",
                table: "ConsumptionEntries",
                column: "PlantCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionEntries_MaterialMasterOverviews_MaterialId",
                table: "ConsumptionEntries",
                column: "MaterialId",
                principalTable: "MaterialMasterOverviews",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsumptionEntries_Plants_PlantCustomerId",
                table: "ConsumptionEntries",
                column: "PlantCustomerId",
                principalTable: "Plants",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

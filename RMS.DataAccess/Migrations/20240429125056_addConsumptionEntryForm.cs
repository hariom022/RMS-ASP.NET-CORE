using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addConsumptionEntryForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumptionEntries",
                columns: table => new
                {
                    ConsumptionEntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantCustomerId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyConsumed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateOfConsumption = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaterialDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnrestrictedStock = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionEntries", x => x.ConsumptionEntryId);
                    table.ForeignKey(
                        name: "FK_ConsumptionEntries_MaterialMasterOverviews_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "MaterialMasterOverviews",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumptionEntries_Plants_PlantCustomerId",
                        column: x => x.PlantCustomerId,
                        principalTable: "Plants",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionEntries_MaterialId",
                table: "ConsumptionEntries",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumptionEntries_PlantCustomerId",
                table: "ConsumptionEntries",
                column: "PlantCustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumptionEntries");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addInquires : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<int>(type: "int", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MaterialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitOfMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedDelivery = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.No);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inquiries");
        }
    }
}

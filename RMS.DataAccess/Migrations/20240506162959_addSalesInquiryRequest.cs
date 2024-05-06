using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSalesInquiryRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "salesInquiryRequestDTOs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HF_Cust = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefernceDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInquiryRequestDTOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesInquiryItemsDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderQuantity = table.Column<int>(type: "int", nullable: false),
                    InquiryId = table.Column<int>(type: "int", nullable: false),
                    SalesInquiryRequestDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInquiryItemsDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInquiryItemsDTO_salesInquiryRequestDTOs_SalesInquiryRequestDTOId",
                        column: x => x.SalesInquiryRequestDTOId,
                        principalTable: "salesInquiryRequestDTOs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesInquiryItemsDTO_SalesInquiryRequestDTOId",
                table: "SalesInquiryItemsDTO",
                column: "SalesInquiryRequestDTOId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInquiryItemsDTO");

            migrationBuilder.DropTable(
                name: "salesInquiryRequestDTOs");
        }
    }
}

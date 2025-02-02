﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addGoodReceiptOverviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsReceiptOverviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<int>(type: "int", nullable: false),
                    QuotationNo = table.Column<string>(name: "Quotation No", type: "varchar(50)", nullable: false),
                    SalesNo = table.Column<string>(name: "Sales No", type: "varchar(20)", nullable: false),
                    OBDNo = table.Column<string>(name: "OBD No", type: "varchar(20)", nullable: false),
                    GoodReceipt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceiptOverviews", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsReceiptOverviews");
        }
    }
}

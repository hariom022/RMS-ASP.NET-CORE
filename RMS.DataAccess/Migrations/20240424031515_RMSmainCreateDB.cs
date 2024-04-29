using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RMSmainCreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryUpdateOverviews",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductCode0 = table.Column<string>(name: "Product Code", type: "varchar(50)", nullable: false),
                    Uom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenStock = table.Column<int>(type: "int", nullable: false),
                    Consumption = table.Column<int>(type: "int", nullable: false),
                    Plant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryUpdateOverviews", x => x.ProductCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryUpdateOverviews");
        }
    }
}

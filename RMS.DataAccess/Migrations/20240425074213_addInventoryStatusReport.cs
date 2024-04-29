using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addInventoryStatusReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryStatusReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(name: "Item Name", type: "varchar(50)", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false),
                    MinimumQuantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryStatusReports", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryStatusReports");
        }
    }
}

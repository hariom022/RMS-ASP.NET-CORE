using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProofOfDelivery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProofOfDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNo = table.Column<int>(type: "int", nullable: false),
                    QuotationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OBDNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodReceipt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PODNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProofOfDelivery", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProofOfDelivery");
        }
    }
}

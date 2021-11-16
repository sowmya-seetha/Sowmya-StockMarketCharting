using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.Admin.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ComapnyTurnover = table.Column<int>(type: "int", nullable: false),
                    CompanyCEO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyBOD = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StockExchangeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Sectorname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}

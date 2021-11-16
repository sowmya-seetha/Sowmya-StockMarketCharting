using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.Account.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminLogin",
                columns: table => new
                {
                    AdminEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLogin", x => x.AdminEmail);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    mobilenum = table.Column<int>(type: "int", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserEmail);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLogin");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

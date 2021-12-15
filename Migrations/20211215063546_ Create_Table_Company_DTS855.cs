using Microsoft.EntityFrameworkCore.Migrations;

namespace DuThaiSon855.Migrations
{
    public partial class Create_Table_Company_DTS855 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company_DTS855s",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_DTS855s", x => x.CompanyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company_DTS855s");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DuThaiSon855.Migrations
{
    public partial class Create_Table_DTS0855 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTS0855s",
                columns: table => new
                {
                    DTSID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DTSName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DTSGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTS0855s", x => x.DTSID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTS0855s");
        }
    }
}

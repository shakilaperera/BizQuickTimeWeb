using Microsoft.EntityFrameworkCore.Migrations;

namespace BizQuickTime.Web.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    InvoicingCompanyId = table.Column<string>(nullable: true),
                    CompanyId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubProject",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubProjectID = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CalcType1 = table.Column<string>(maxLength: 5, nullable: false),
                    CalcType2 = table.Column<string>(nullable: true),
                    CalcType3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubProject", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "SubProject");
        }
    }
}

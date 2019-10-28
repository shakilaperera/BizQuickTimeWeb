using Microsoft.EntityFrameworkCore.Migrations;

namespace BizQuickTime.Web.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<string>(maxLength: 15, nullable: false),
                    ActivityName = table.Column<string>(maxLength: 100, nullable: false),
                    CalcType1 = table.Column<string>(maxLength: 5, nullable: false),
                    CalcType2 = table.Column<string>(nullable: true),
                    CalcType3 = table.Column<string>(nullable: true),
                    EstimationQty = table.Column<int>(nullable: false),
                    EstimationUnit = table.Column<string>(maxLength: 10, nullable: true),
                    EstimatedValue = table.Column<decimal>(nullable: false),
                    CappedValue = table.Column<decimal>(nullable: false),
                    PurchaseOrder = table.Column<string>(nullable: true),
                    PurchaseOrderQty = table.Column<int>(nullable: false),
                    POGrossAmount = table.Column<decimal>(nullable: false),
                    ShortId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

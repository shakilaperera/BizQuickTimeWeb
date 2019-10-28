using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizQuickTime.Web.Migrations
{
    public partial class CreateIdentitySchema1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Currency = table.Column<string>(nullable: false),
                    ContactName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    VatNumber = table.Column<string>(nullable: true),
                    VatPercentage = table.Column<int>(nullable: false),
                    CompanyRegNo = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CompanyLogo = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Currency = table.Column<string>(maxLength: 5, nullable: false),
                    CompanyID = table.Column<string>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Company_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AllowedUser",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    SubProjectID = table.Column<string>(nullable: false),
                    Expenses = table.Column<bool>(nullable: false),
                    SubProjectID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedUser", x => new { x.UserID, x.SubProjectID });
                    table.ForeignKey(
                        name: "FK_AllowedUser_SubProject_SubProjectID1",
                        column: x => x.SubProjectID1,
                        principalTable: "SubProject",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AllowedUser_ApplicationUser_UserID",
                        column: x => x.UserID,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceRatesPerUser",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    Expenses = table.Column<bool>(nullable: false),
                    DailyRate = table.Column<decimal>(nullable: false),
                    HourlyRate = table.Column<decimal>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceRatesPerUser", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_InvoiceRatesPerUser_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllowedUser_SubProjectID1",
                table: "AllowedUser",
                column: "SubProjectID1");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_CompanyID1",
                table: "ApplicationUser",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceRatesPerUser_ApplicationUserId",
                table: "InvoiceRatesPerUser",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowedUser");

            migrationBuilder.DropTable(
                name: "InvoiceRatesPerUser");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class ExpectedRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExpectedRateId",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(nullable: true),
                    PaymentPeriod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ExpectedRateId",
                table: "Employee",
                column: "ExpectedRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Rate_ExpectedRateId",
                table: "Employee",
                column: "ExpectedRateId",
                principalTable: "Rate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Rate_ExpectedRateId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ExpectedRateId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ExpectedRateId",
                table: "Employee");
        }
    }
}

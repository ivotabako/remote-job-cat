using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class EmployeeRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Rate_ExpectedRateId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ExpectedRateId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ExpectedRateId",
                table: "Employee");

            migrationBuilder.AddColumn<Guid>(
                name: "RateId",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RateId",
                table: "Employee",
                column: "RateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Rate_RateId",
                table: "Employee",
                column: "RateId",
                principalTable: "Rate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Rate_RateId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_RateId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RateId",
                table: "Employee");

            migrationBuilder.AddColumn<Guid>(
                name: "ExpectedRateId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}

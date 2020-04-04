using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class EployeeMoreProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApprovedCount",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkedInProfileUrl",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RejectedCount",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortSelfIntroduction",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InternalRecommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RecommendedEmployee = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RecommendatorEmployee = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalRecommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalRecommendation_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendation_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InternalRecommendation_EmployeeId",
                table: "InternalRecommendation",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendation_EmployeeId",
                table: "Recommendation",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternalRecommendation");

            migrationBuilder.DropTable(
                name: "Recommendation");

            migrationBuilder.DropColumn(
                name: "ApprovedCount",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LinkedInProfileUrl",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RejectedCount",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ShortSelfIntroduction",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Employee");
        }
    }
}

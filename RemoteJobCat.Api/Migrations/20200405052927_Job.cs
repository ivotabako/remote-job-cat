using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class Job : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsPermanent = table.Column<bool>(nullable: false),
                    FixedRateId = table.Column<Guid>(nullable: true),
                    EmployerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Rate_FixedRateId",
                        column: x => x.FixedRateId,
                        principalTable: "Rate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Job_FixedRateId",
                table: "Job",
                column: "FixedRateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}

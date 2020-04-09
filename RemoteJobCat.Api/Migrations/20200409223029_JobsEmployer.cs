using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class JobsEmployer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Job_JobId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Job_JobId1",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Job_JobId2",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId1",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId2",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId1",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId2",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobId1",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_JobId2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployerId1",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EmployerId2",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ApprovedCount",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobId2",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RejectedCount",
                table: "Employee");

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Job",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRecruitmentInProgress",
                table: "Job",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "EmployeeJob",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    JobId = table.Column<Guid>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsRejected = table.Column<bool>(nullable: false),
                    IsPendingApproval = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJob", x => new { x.JobId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeJob_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeJob_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJob_EmployeeId",
                table: "EmployeeJob",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeJob");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "IsRecruitmentInProgress",
                table: "Job");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployerId1",
                table: "Job",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployerId2",
                table: "Job",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedCount",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId1",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId2",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RejectedCount",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId1",
                table: "Job",
                column: "EmployerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId2",
                table: "Job",
                column: "EmployerId2");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobId",
                table: "Employee",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobId1",
                table: "Employee",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobId2",
                table: "Employee",
                column: "JobId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Job_JobId",
                table: "Employee",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Job_JobId1",
                table: "Employee",
                column: "JobId1",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Job_JobId2",
                table: "Employee",
                column: "JobId2",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Employer_EmployerId1",
                table: "Job",
                column: "EmployerId1",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Employer_EmployerId2",
                table: "Job",
                column: "EmployerId2",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

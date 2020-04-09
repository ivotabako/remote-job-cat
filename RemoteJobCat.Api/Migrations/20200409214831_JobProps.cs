using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RemoteJobCat.Api.Migrations
{
    public partial class JobProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternalRecommendation_Employee_EmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Employer_EmployerId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_InternalRecommendation_EmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropColumn(
                name: "RecommendatorEmployee",
                table: "InternalRecommendation");

            migrationBuilder.DropColumn(
                name: "RecommendedEmployee",
                table: "InternalRecommendation");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployerId",
                table: "Report",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                table: "Report",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployerId",
                table: "Job",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployerId1",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployerId2",
                table: "Job",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecommendatorEmployeeId",
                table: "InternalRecommendation",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecommendedEmployeeId",
                table: "InternalRecommendation",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId1",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "JobId2",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Report_EmployeeId",
                table: "Report",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId",
                table: "Job",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId1",
                table: "Job",
                column: "EmployerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId2",
                table: "Job",
                column: "EmployerId2");

            migrationBuilder.CreateIndex(
                name: "IX_InternalRecommendation_RecommendatorEmployeeId",
                table: "InternalRecommendation",
                column: "RecommendatorEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalRecommendation_RecommendedEmployeeId",
                table: "InternalRecommendation",
                column: "RecommendedEmployeeId");

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
                name: "FK_InternalRecommendation_Employee_RecommendatorEmployeeId",
                table: "InternalRecommendation",
                column: "RecommendatorEmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InternalRecommendation_Employee_RecommendedEmployeeId",
                table: "InternalRecommendation",
                column: "RecommendedEmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job",
                column: "EmployerId",
                principalTable: "Employer",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Employee_EmployeeId",
                table: "Report",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Employer_EmployerId",
                table: "Report",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_InternalRecommendation_Employee_RecommendatorEmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_InternalRecommendation_Employee_RecommendedEmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId1",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId2",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Employee_EmployeeId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Employer_EmployerId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Report_EmployeeId",
                table: "Report");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId1",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId2",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_InternalRecommendation_RecommendatorEmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropIndex(
                name: "IX_InternalRecommendation_RecommendedEmployeeId",
                table: "InternalRecommendation");

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
                name: "RecommendatorEmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropColumn(
                name: "RecommendedEmployeeId",
                table: "InternalRecommendation");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JobId2",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployerId",
                table: "Report",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                table: "Report",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployerId",
                table: "Job",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "InternalRecommendation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RecommendatorEmployee",
                table: "InternalRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RecommendedEmployee",
                table: "InternalRecommendation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_InternalRecommendation_EmployeeId",
                table: "InternalRecommendation",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternalRecommendation_Employee_EmployeeId",
                table: "InternalRecommendation",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Employer_EmployerId",
                table: "Report",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

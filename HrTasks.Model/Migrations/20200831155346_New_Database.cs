using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrTasks.Model.Migrations
{
    public partial class New_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsManger",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "EmployeeLogs");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EmployeeLogs",
                newName: "DayDate");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "LogIn",
                table: "EmployeeLogs",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "LogOut",
                table: "EmployeeLogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogIn",
                table: "EmployeeLogs");

            migrationBuilder.DropColumn(
                name: "LogOut",
                table: "EmployeeLogs");

            migrationBuilder.RenameColumn(
                name: "DayDate",
                table: "EmployeeLogs",
                newName: "StartDate");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsManger",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "EmployeeLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentAr = table.Column<string>(nullable: true),
                    DepartmentEn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

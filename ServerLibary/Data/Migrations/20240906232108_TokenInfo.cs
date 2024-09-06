using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerLibary.Data.Migrations
{
    /// <inheritdoc />
    public partial class TokenInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_branches_BranchId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_generalDepartments_GeneralDepartmentId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_towns_TownId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_towns",
                table: "towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_systemRoles",
                table: "systemRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_generalDepartments",
                table: "generalDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_branches",
                table: "branches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_applicationUsers",
                table: "applicationUsers");

            migrationBuilder.RenameTable(
                name: "userRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "towns",
                newName: "Towns");

            migrationBuilder.RenameTable(
                name: "systemRoles",
                newName: "SystemRoles");

            migrationBuilder.RenameTable(
                name: "generalDepartments",
                newName: "GeneralDepartments");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "branches",
                newName: "Branches");

            migrationBuilder.RenameTable(
                name: "applicationUsers",
                newName: "ApplicationUsers");

            migrationBuilder.RenameIndex(
                name: "IX_employees_TownId",
                table: "Employees",
                newName: "IX_Employees_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_GeneralDepartmentId",
                table: "Employees",
                newName: "IX_Employees_GeneralDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_employees_BranchId",
                table: "Employees",
                newName: "IX_Employees_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemRoles",
                table: "SystemRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralDepartments",
                table: "GeneralDepartments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RefreshTokenInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokenInfos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_BranchId",
                table: "Employees",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_GeneralDepartments_GeneralDepartmentId",
                table: "Employees",
                column: "GeneralDepartmentId",
                principalTable: "GeneralDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Towns_TownId",
                table: "Employees",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_BranchId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_GeneralDepartments_GeneralDepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Towns_TownId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "RefreshTokenInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemRoles",
                table: "SystemRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralDepartments",
                table: "GeneralDepartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "userRoles");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "towns");

            migrationBuilder.RenameTable(
                name: "SystemRoles",
                newName: "systemRoles");

            migrationBuilder.RenameTable(
                name: "GeneralDepartments",
                newName: "generalDepartments");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "employees");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "Branches",
                newName: "branches");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "applicationUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_TownId",
                table: "employees",
                newName: "IX_employees_TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_GeneralDepartmentId",
                table: "employees",
                newName: "IX_employees_GeneralDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "employees",
                newName: "IX_employees_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_BranchId",
                table: "employees",
                newName: "IX_employees_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_towns",
                table: "towns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_systemRoles",
                table: "systemRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_generalDepartments",
                table: "generalDepartments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_branches",
                table: "branches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_applicationUsers",
                table: "applicationUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_branches_BranchId",
                table: "employees",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentId",
                table: "employees",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_generalDepartments_GeneralDepartmentId",
                table: "employees",
                column: "GeneralDepartmentId",
                principalTable: "generalDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_towns_TownId",
                table: "employees",
                column: "TownId",
                principalTable: "towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

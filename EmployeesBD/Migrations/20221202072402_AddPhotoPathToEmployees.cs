using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesBD.Migrations
{
    public partial class AddPhotoPathToEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photoPath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photoPath",
                table: "Employees");
        }
    }
}

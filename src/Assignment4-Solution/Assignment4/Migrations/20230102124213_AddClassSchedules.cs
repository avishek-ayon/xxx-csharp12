using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment4.Migrations
{
    public partial class AddClassSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalClasses",
                table: "Courses",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalClasses",
                table: "Courses");
        }
    }
}

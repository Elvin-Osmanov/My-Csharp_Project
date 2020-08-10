using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class ManagerPropMistakeCovered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialitity",
                table: "Managers");

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "Managers",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "Managers");

            migrationBuilder.AddColumn<string>(
                name: "Specialitity",
                table: "Managers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }
    }
}

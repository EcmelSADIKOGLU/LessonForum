using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonForum.DataAccessLayer.Migrations
{
    public partial class Deleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "SubCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Categories");
        }
    }
}

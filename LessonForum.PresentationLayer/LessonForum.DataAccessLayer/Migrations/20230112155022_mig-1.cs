using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonForum.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lessonNotes_AspNetUsers_AppUserId",
                table: "lessonNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_lessonNotes_subCategories_SubCategoryID",
                table: "lessonNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lessonNotes",
                table: "lessonNotes");

            migrationBuilder.RenameTable(
                name: "lessonNotes",
                newName: "LessonNotes");

            migrationBuilder.RenameIndex(
                name: "IX_lessonNotes_SubCategoryID",
                table: "LessonNotes",
                newName: "IX_LessonNotes_SubCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_lessonNotes_AppUserId",
                table: "LessonNotes",
                newName: "IX_LessonNotes_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonNotes",
                table: "LessonNotes",
                column: "LessonNotesID");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonNotes_AspNetUsers_AppUserId",
                table: "LessonNotes",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonNotes_subCategories_SubCategoryID",
                table: "LessonNotes",
                column: "SubCategoryID",
                principalTable: "subCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonNotes_AspNetUsers_AppUserId",
                table: "LessonNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonNotes_subCategories_SubCategoryID",
                table: "LessonNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonNotes",
                table: "LessonNotes");

            migrationBuilder.RenameTable(
                name: "LessonNotes",
                newName: "lessonNotes");

            migrationBuilder.RenameIndex(
                name: "IX_LessonNotes_SubCategoryID",
                table: "lessonNotes",
                newName: "IX_lessonNotes_SubCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_LessonNotes_AppUserId",
                table: "lessonNotes",
                newName: "IX_lessonNotes_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lessonNotes",
                table: "lessonNotes",
                column: "LessonNotesID");

            migrationBuilder.AddForeignKey(
                name: "FK_lessonNotes_AspNetUsers_AppUserId",
                table: "lessonNotes",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_lessonNotes_subCategories_SubCategoryID",
                table: "lessonNotes",
                column: "SubCategoryID",
                principalTable: "subCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

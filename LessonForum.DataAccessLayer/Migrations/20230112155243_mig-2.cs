using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonForum.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonNotes_subCategories_SubCategoryID",
                table: "LessonNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_subCategories_AspNetUsers_AppUserId",
                table: "subCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_subCategories_Categories_CategoryID",
                table: "subCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subCategories",
                table: "subCategories");

            migrationBuilder.RenameTable(
                name: "subCategories",
                newName: "SubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_subCategories_CategoryID",
                table: "SubCategories",
                newName: "IX_SubCategories_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_subCategories_AppUserId",
                table: "SubCategories",
                newName: "IX_SubCategories_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "SubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonNotes_SubCategories_SubCategoryID",
                table: "LessonNotes",
                column: "SubCategoryID",
                principalTable: "SubCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_AspNetUsers_AppUserId",
                table: "SubCategories",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryID",
                table: "SubCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonNotes_SubCategories_SubCategoryID",
                table: "LessonNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_AspNetUsers_AppUserId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryID",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "subCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_CategoryID",
                table: "subCategories",
                newName: "IX_subCategories_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_AppUserId",
                table: "subCategories",
                newName: "IX_subCategories_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subCategories",
                table: "subCategories",
                column: "SubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonNotes_subCategories_SubCategoryID",
                table: "LessonNotes",
                column: "SubCategoryID",
                principalTable: "subCategories",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subCategories_AspNetUsers_AppUserId",
                table: "subCategories",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_subCategories_Categories_CategoryID",
                table: "subCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

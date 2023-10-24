using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pop_Andreea_Georgiana_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Dropdown : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_BookID",
                table: "Author",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Book_BookID",
                table: "Author",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Book_BookID",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_BookID",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "Author");
        }
    }
}

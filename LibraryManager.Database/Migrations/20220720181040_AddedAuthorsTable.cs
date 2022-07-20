using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Database.Migrations
{
    public partial class AddedAuthorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AuthorEntity_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorEntity",
                table: "AuthorEntity");

            migrationBuilder.RenameTable(
                name: "AuthorEntity",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "AuthorEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorEntity",
                table: "AuthorEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AuthorEntity_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "AuthorEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

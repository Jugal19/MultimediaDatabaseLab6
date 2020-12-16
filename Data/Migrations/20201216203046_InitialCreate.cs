using Microsoft.EntityFrameworkCore.Migrations;

namespace MultimediaDatabaseLab6.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    readerName = table.Column<string>(nullable: true),
                    bookName = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    author = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookID = table.Column<int>(nullable: false),
                    watcherName = table.Column<string>(nullable: true),
                    movieName = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    basedOnBooks = table.Column<string>(nullable: true),
                    genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_Books_bookID",
                        column: x => x.bookID,
                        principalTable: "Books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_bookID",
                table: "Movies",
                column: "bookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

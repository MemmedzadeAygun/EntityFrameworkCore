using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTasks1.Migrations
{
    /// <inheritdoc />
    public partial class migration_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MoviesImdbDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MoviesImdbDetails_MovieId",
                table: "MoviesImdbDetails",
                column: "MovieId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesImdbDetails_Movies_MovieId",
                table: "MoviesImdbDetails",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesImdbDetails_Movies_MovieId",
                table: "MoviesImdbDetails");

            migrationBuilder.DropIndex(
                name: "IX_MoviesImdbDetails_MovieId",
                table: "MoviesImdbDetails");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MoviesImdbDetails");
        }
    }
}

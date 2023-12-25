using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecommendationSystemApi.Migrations
{
    /// <inheritdoc />
    public partial class updatemodel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CreditsCrew",
                newName: "DbId");

            migrationBuilder.AddColumn<int>(
                name: "MovieDbId",
                table: "MovieLinks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SpokenLanguages_MovieId",
                table: "SpokenLanguages",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingsSmall_MovieId",
                table: "RatingsSmall",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCountries_MovieId",
                table: "ProductionCountries",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionCompanies_MovieId",
                table: "ProductionCompanies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieLinksSmall_MovieId",
                table: "MovieLinksSmall",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieLinks_MovieDbId",
                table: "MovieLinks",
                column: "MovieDbId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieId",
                table: "Genres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpandedKeywords_MovieId",
                table: "ExpandedKeywords",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpandedKeywords_MoviesMetadata_MovieId",
                table: "ExpandedKeywords",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_MoviesMetadata_MovieId",
                table: "Genres",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLinks_MoviesMetadata_MovieDbId",
                table: "MovieLinks",
                column: "MovieDbId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLinksSmall_MoviesMetadata_MovieId",
                table: "MovieLinksSmall",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCompanies_MoviesMetadata_MovieId",
                table: "ProductionCompanies",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCountries_MoviesMetadata_MovieId",
                table: "ProductionCountries",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_MoviesMetadata_MovieId",
                table: "Ratings",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingsSmall_MoviesMetadata_MovieId",
                table: "RatingsSmall",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpokenLanguages_MoviesMetadata_MovieId",
                table: "SpokenLanguages",
                column: "MovieId",
                principalTable: "MoviesMetadata",
                principalColumn: "DbId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpandedKeywords_MoviesMetadata_MovieId",
                table: "ExpandedKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_MoviesMetadata_MovieId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieLinks_MoviesMetadata_MovieDbId",
                table: "MovieLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieLinksSmall_MoviesMetadata_MovieId",
                table: "MovieLinksSmall");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCompanies_MoviesMetadata_MovieId",
                table: "ProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCountries_MoviesMetadata_MovieId",
                table: "ProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_MoviesMetadata_MovieId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_RatingsSmall_MoviesMetadata_MovieId",
                table: "RatingsSmall");

            migrationBuilder.DropForeignKey(
                name: "FK_SpokenLanguages_MoviesMetadata_MovieId",
                table: "SpokenLanguages");

            migrationBuilder.DropIndex(
                name: "IX_SpokenLanguages_MovieId",
                table: "SpokenLanguages");

            migrationBuilder.DropIndex(
                name: "IX_RatingsSmall_MovieId",
                table: "RatingsSmall");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_ProductionCountries_MovieId",
                table: "ProductionCountries");

            migrationBuilder.DropIndex(
                name: "IX_ProductionCompanies_MovieId",
                table: "ProductionCompanies");

            migrationBuilder.DropIndex(
                name: "IX_MovieLinksSmall_MovieId",
                table: "MovieLinksSmall");

            migrationBuilder.DropIndex(
                name: "IX_MovieLinks_MovieDbId",
                table: "MovieLinks");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_ExpandedKeywords_MovieId",
                table: "ExpandedKeywords");

            migrationBuilder.DropColumn(
                name: "MovieDbId",
                table: "MovieLinks");

            migrationBuilder.RenameColumn(
                name: "DbId",
                table: "CreditsCrew",
                newName: "Id");
        }
    }
}

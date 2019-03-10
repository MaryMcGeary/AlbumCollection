using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedTempSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumImageLocation", "AlbumName", "ArtistName" },
                values: new object[] { 1, "Somewhere out there", "Some Album", "Not Me" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "SongName" },
                values: new object[] { 1, "Yay!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);
        }
    }
}

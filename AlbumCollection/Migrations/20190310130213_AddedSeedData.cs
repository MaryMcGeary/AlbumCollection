using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumCollection.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                columns: new[] { "AlbumImageLocation", "AlbumName", "ArtistName" },
                values: new object[] { "Img/TheFaithTones.jpg", "Jesus Use Me", "The Faith Tones" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumImageLocation", "AlbumName", "ArtistName" },
                values: new object[,]
                {
                    { 2, "Img/LeonardNimoy.jpg", "Mr. Spock's Music From Outer Space", "Leonard Nimoy" },
                    { 3, "Img/AlanMills.jpg", "Old McDonald Had a Farm", "Alan Mills and the Four Shipmates" }
                });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                column: "SongName",
                value: "Exposed");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "SongName" },
                values: new object[,]
                {
                    { 2, "It's Different Now" },
                    { 3, "Music to Watch Space Girls By" },
                    { 4, "Twinkle, Twinkle Little Earth" },
                    { 5, "I Know an Old Lady" },
                    { 6, "Froggie Went A-Courtin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                columns: new[] { "AlbumImageLocation", "AlbumName", "ArtistName" },
                values: new object[] { "Somewhere out there", "Some Album", "Not Me" });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1,
                column: "SongName",
                value: "Yay!");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SCOWebApp.Migrations
{
    public partial class ChangedSeedDataDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Beach camping near SLO");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                column: "ShortDescription",
                value: "Overnight backpacking to hot springs");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7,
                column: "ShortDescription",
                value: "2 day camping at Lodgepole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Beach camping near San Luis Obispo");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4,
                column: "ShortDescription",
                value: "One night adventure backpacking hot spring to hot spring");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7,
                column: "ShortDescription",
                value: "2 day camping at Lodgepole Campground");
        }
    }
}

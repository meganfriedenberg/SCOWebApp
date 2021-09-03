using Microsoft.EntityFrameworkCore.Migrations;

namespace SCOWebApp.Migrations
{
    public partial class NotesAddedOnTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Trips",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Trips");
        }
    }
}

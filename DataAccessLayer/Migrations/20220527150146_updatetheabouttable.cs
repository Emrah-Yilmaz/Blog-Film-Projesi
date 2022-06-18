using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class updatetheabouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OurAddress",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OurEmailAddress",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OurLocation",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OurPhoneNumber",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OurAddress",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OurEmailAddress",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OurLocation",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "OurPhoneNumber",
                table: "Abouts");
        }
    }
}

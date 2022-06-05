using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TietoCalorieApp.Migrations
{
    public partial class Newest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarbsCount",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatsCount",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProteinCount",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarbsCount",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "FatsCount",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "ProteinCount",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dishes");
        }
    }
}

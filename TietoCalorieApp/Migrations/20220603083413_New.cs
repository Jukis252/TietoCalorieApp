using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TietoCalorieApp.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarbsCount",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatsCount",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProteinCount",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarbsCount",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FatsCount",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "ProteinCount",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Foods");
        }
    }
}

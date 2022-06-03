using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TietoCalorieApp.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalorieCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    CalorieCount = table.Column<int>(type: "int", nullable: false),
                    CarbsCount = table.Column<int>(type: "int", nullable: false),
                    ProteinCount = table.Column<int>(type: "int", nullable: false),
                    FatsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalorieCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CalorieCount", "CarbsCount", "FatsCount", "Name", "ProteinCount", "Weight" },
                values: new object[,]
                {
                    { 1, 16, 9, 0, "Tomato", 4, 100 },
                    { 2, 47, 13, 0, "Orange", 1, 100 },
                    { 3, 15, 3, 0, "Cucumber", 4, 100 }
                });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "CalorieCount", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Carbohydrates" },
                    { 2, 4, "Protein" },
                    { 3, 9, "Fats" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Nutrients");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class Initializing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city_population = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weather_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weather_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wind_speed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wind_degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wind_direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    presure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.id);
                    table.ForeignKey(
                        name: "FK_Weather_City_cityId",
                        column: x => x.cityId,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weather_cityId",
                table: "Weather",
                column: "cityId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheater_Cities_cityId",
                table: "Wheater");

            migrationBuilder.RenameColumn(
                name: "wind_speed",
                table: "Wheater",
                newName: "Wind_Speed");

            migrationBuilder.RenameColumn(
                name: "wind_direction",
                table: "Wheater",
                newName: "Wind_Direction");

            migrationBuilder.RenameColumn(
                name: "wind_degree",
                table: "Wheater",
                newName: "Wind_Degree");

            migrationBuilder.RenameColumn(
                name: "weather_time",
                table: "Wheater",
                newName: "Weather_Time");

            migrationBuilder.RenameColumn(
                name: "weather_description",
                table: "Wheater",
                newName: "Weather_Description");

            migrationBuilder.RenameColumn(
                name: "temperature",
                table: "Wheater",
                newName: "Temperature");

            migrationBuilder.RenameColumn(
                name: "presure",
                table: "Wheater",
                newName: "Presure");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "Wheater",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Wheater",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Wheater_cityId",
                table: "Wheater",
                newName: "IX_Wheater_CityId");

            migrationBuilder.RenameColumn(
                name: "city_population",
                table: "Cities",
                newName: "City_Population");

            migrationBuilder.RenameColumn(
                name: "city_name",
                table: "Cities",
                newName: "City_Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cities",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheater_Cities_CityId",
                table: "Wheater",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheater_Cities_CityId",
                table: "Wheater");

            migrationBuilder.RenameColumn(
                name: "Wind_Speed",
                table: "Wheater",
                newName: "wind_speed");

            migrationBuilder.RenameColumn(
                name: "Wind_Direction",
                table: "Wheater",
                newName: "wind_direction");

            migrationBuilder.RenameColumn(
                name: "Wind_Degree",
                table: "Wheater",
                newName: "wind_degree");

            migrationBuilder.RenameColumn(
                name: "Weather_Time",
                table: "Wheater",
                newName: "weather_time");

            migrationBuilder.RenameColumn(
                name: "Weather_Description",
                table: "Wheater",
                newName: "weather_description");

            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "Wheater",
                newName: "temperature");

            migrationBuilder.RenameColumn(
                name: "Presure",
                table: "Wheater",
                newName: "presure");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Wheater",
                newName: "cityId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Wheater",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Wheater_CityId",
                table: "Wheater",
                newName: "IX_Wheater_cityId");

            migrationBuilder.RenameColumn(
                name: "City_Population",
                table: "Cities",
                newName: "city_population");

            migrationBuilder.RenameColumn(
                name: "City_Name",
                table: "Cities",
                newName: "city_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheater_Cities_cityId",
                table: "Wheater",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

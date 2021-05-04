using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class CitiesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_City_cityId",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Weather",
                newName: "Wheate");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_cityId",
                table: "Wheate",
                newName: "IX_Wheate_cityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wheate",
                table: "Wheate",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheate_Cities_cityId",
                table: "Wheate",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheate_Cities_cityId",
                table: "Wheate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wheate",
                table: "Wheate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Wheate",
                newName: "Weather");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Wheate_cityId",
                table: "Weather",
                newName: "IX_Weather_cityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_City_cityId",
                table: "Weather",
                column: "cityId",
                principalTable: "City",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

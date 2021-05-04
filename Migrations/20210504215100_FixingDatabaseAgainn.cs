using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingDatabaseAgainn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_CityId",
                table: "Weather");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Weather",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CityId",
                table: "Weather",
                column: "CityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_CityId",
                table: "Weather");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Weather",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CityId",
                table: "Weather",
                column: "CityId",
                unique: true,
                filter: "[CityId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

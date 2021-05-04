using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingDatabaseAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheater_Cities_CityId",
                table: "Wheater");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wheater",
                table: "Wheater");

            migrationBuilder.DropIndex(
                name: "IX_Wheater_CityId",
                table: "Wheater");

            migrationBuilder.RenameTable(
                name: "Wheater",
                newName: "Weather");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Weather",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Cities_CityId",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_CityId",
                table: "Weather");

            migrationBuilder.RenameTable(
                name: "Weather",
                newName: "Wheater");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Wheater",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wheater",
                table: "Wheater",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wheater_CityId",
                table: "Wheater",
                column: "CityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wheater_Cities_CityId",
                table: "Wheater",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

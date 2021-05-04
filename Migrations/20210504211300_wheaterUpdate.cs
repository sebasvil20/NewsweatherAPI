using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class wheaterUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheate_Cities_cityId",
                table: "Wheate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wheate",
                table: "Wheate");

            migrationBuilder.RenameTable(
                name: "Wheate",
                newName: "Wheater");

            migrationBuilder.RenameIndex(
                name: "IX_Wheate_cityId",
                table: "Wheater",
                newName: "IX_Wheater_cityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wheater",
                table: "Wheater",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheater_Cities_cityId",
                table: "Wheater",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheater_Cities_cityId",
                table: "Wheater");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wheater",
                table: "Wheater");

            migrationBuilder.RenameTable(
                name: "Wheater",
                newName: "Wheate");

            migrationBuilder.RenameIndex(
                name: "IX_Wheater_cityId",
                table: "Wheate",
                newName: "IX_Wheate_cityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wheate",
                table: "Wheate",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheate_Cities_cityId",
                table: "Wheate",
                column: "cityId",
                principalTable: "Cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

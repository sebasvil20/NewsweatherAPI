using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingHistorySchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "SearchHistory");

            migrationBuilder.AlterColumn<int>(
                name: "SearchHistoryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities",
                column: "SearchHistoryId",
                principalTable: "SearchHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "SearchHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SearchHistoryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities",
                column: "SearchHistoryId",
                principalTable: "SearchHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

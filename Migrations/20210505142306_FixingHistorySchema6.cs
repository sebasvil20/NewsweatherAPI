using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingHistorySchema6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_SearchHistoryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "SearchHistoryId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "SearchHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SearchHistory_CityId",
                table: "SearchHistory",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_SearchHistory_Cities_CityId",
                table: "SearchHistory",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SearchHistory_Cities_CityId",
                table: "SearchHistory");

            migrationBuilder.DropIndex(
                name: "IX_SearchHistory_CityId",
                table: "SearchHistory");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "SearchHistory");

            migrationBuilder.AddColumn<int>(
                name: "SearchHistoryId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_SearchHistoryId",
                table: "Cities",
                column: "SearchHistoryId");

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

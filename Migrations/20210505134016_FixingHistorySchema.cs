using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsweatherAPI.Migrations
{
    public partial class FixingHistorySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SearchHistoryId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SearchHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchHistory", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_SearchHistory_SearchHistoryId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "SearchHistory");

            migrationBuilder.DropIndex(
                name: "IX_Cities_SearchHistoryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "SearchHistoryId",
                table: "Cities");
        }
    }
}

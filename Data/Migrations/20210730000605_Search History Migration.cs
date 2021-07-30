using Microsoft.EntityFrameworkCore.Migrations;

namespace SearchEngine.Data.Migrations
{
    public partial class SearchHistoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Searches",
                columns: table => new
                {
                    SearchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchHistorySearchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searches", x => x.SearchId);
                    table.ForeignKey(
                        name: "FK_Searches_Searches_SearchHistorySearchId",
                        column: x => x.SearchHistorySearchId,
                        principalTable: "Searches",
                        principalColumn: "SearchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Searches_SearchHistorySearchId",
                table: "Searches",
                column: "SearchHistorySearchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Searches");
        }
    }
}

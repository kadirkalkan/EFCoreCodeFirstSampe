using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample.Migrations
{
    public partial class turler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KitapTur",
                columns: table => new
                {
                    KitaplarId = table.Column<int>(type: "int", nullable: false),
                    TurlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapTur", x => new { x.KitaplarId, x.TurlerId });
                    table.ForeignKey(
                        name: "FK_KitapTur_Kitaplar_KitaplarId",
                        column: x => x.KitaplarId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapTur_Turler_TurlerId",
                        column: x => x.TurlerId,
                        principalTable: "Turler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitapTur_TurlerId",
                table: "KitapTur",
                column: "TurlerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapTur");

            migrationBuilder.DropTable(
                name: "Turler");
        }
    }
}

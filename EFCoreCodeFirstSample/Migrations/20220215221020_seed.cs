using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstSample.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapTur");

            migrationBuilder.CreateTable(
                name: "KitapTurleri",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapTurleri", x => new { x.KitapId, x.TurId });
                    table.ForeignKey(
                        name: "FK_KitapTurleri_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapTurleri_Turler_TurId",
                        column: x => x.TurId,
                        principalTable: "Turler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Turler",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Fantezi" });

            migrationBuilder.InsertData(
                table: "Turler",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Macera" });

            migrationBuilder.CreateIndex(
                name: "IX_KitapTurleri_TurId",
                table: "KitapTurleri",
                column: "TurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapTurleri");

            migrationBuilder.DeleteData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turler",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}

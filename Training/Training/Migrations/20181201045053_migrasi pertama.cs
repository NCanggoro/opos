using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.Migrations
{
    public partial class migrasipertama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KategoriBarang",
                columns: table => new
                {
                    IdKategori = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaKategori = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriBarang", x => x.IdKategori);
                });

            migrationBuilder.CreateTable(
                name: "Barang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NamaBarang = table.Column<string>(nullable: true),
                    StokBarang = table.Column<int>(nullable: false),
                    HargaBarang = table.Column<int>(nullable: false),
                    IdKategori = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barang_KategoriBarang_IdKategori",
                        column: x => x.IdKategori,
                        principalTable: "KategoriBarang",
                        principalColumn: "IdKategori",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barang_IdKategori",
                table: "Barang",
                column: "IdKategori");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barang");

            migrationBuilder.DropTable(
                name: "KategoriBarang");
        }
    }
}

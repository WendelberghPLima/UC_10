using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uc_10_Wendel_Relacionamentos_Descricao_00004.Migrations
{
    /// <inheritdoc />
    public partial class tb_Marca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaID);
                });

            migrationBuilder.CreateTable(
                name: "Automovel",
                columns: table => new
                {
                    AutomovelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automovel", x => x.AutomovelID);
                    table.ForeignKey(
                        name: "FK_Automovel_Marca_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marca",
                        principalColumn: "MarcaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Automovel_MarcaID",
                table: "Automovel",
                column: "MarcaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automovel");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}

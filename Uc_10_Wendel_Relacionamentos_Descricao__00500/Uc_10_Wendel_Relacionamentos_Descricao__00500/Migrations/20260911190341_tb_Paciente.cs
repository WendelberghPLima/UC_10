using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uc_10_Wendel_Relacionamentos_Descricao__00500.Migrations
{
    /// <inheritdoc />
    public partial class tb_Paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CRM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoId);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "TipoConsulta",
                columns: table => new
                {
                    TipoConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoConsulta", x => x.TipoConsultaId);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    TipoConsultaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_TipoConsulta_TipoConsultaId",
                        column: x => x.TipoConsultaId,
                        principalTable: "TipoConsulta",
                        principalColumn: "TipoConsultaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_TipoConsultaId",
                table: "Consulta",
                column: "TipoConsultaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "TipoConsulta");
        }
    }
}

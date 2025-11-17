using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoMateriaAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Alunos_AlunoId",
                table: "Materias");

            migrationBuilder.DropIndex(
                name: "IX_Materias_AlunoId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Materias");

            migrationBuilder.CreateTable(
                name: "MateriaAlunos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlunoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MateriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaAlunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MateriaAlunos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaAlunos_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaAlunos_AlunoId",
                table: "MateriaAlunos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaAlunos_MateriaId",
                table: "MateriaAlunos",
                column: "MateriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MateriaAlunos");

            migrationBuilder.AddColumn<Guid>(
                name: "AlunoId",
                table: "Materias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_AlunoId",
                table: "Materias",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Alunos_AlunoId",
                table: "Materias",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");
        }
    }
}

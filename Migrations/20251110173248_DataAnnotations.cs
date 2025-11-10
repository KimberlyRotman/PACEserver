using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_ProfessorId",
                table: "Materias");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "Materias",
                newName: "IdProfessor");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_ProfessorId",
                table: "Materias",
                newName: "IX_Materias_IdProfessor");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Tarefas",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_IdProfessor",
                table: "Materias",
                column: "IdProfessor",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_IdProfessor",
                table: "Materias");

            migrationBuilder.RenameColumn(
                name: "IdProfessor",
                table: "Materias",
                newName: "ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_IdProfessor",
                table: "Materias",
                newName: "IX_Materias_ProfessorId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_ProfessorId",
                table: "Materias",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

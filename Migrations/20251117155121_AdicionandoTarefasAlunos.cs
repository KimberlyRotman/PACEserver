using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTarefasAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Kambam",
                table: "TarefasAlunos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "Enviado",
                table: "TarefasAlunos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql($@"
                INSERT INTO TarefasAlunos (Id, TarefaId, AlunoId, DataCadastro)
                SELECT 
                    NEWID(),
                    t.Id,
                    ma.AlunoId,
                    GETUTCDATE()
                FROM MateriaAlunos ma
                INNER JOIN Tarefas t ON t.MateriaId = ma.MateriaId;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TarefasAlunos");
        }
    }
}

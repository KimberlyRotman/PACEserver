using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
        VALUES ('{Guid.NewGuid()}', 'João Silva', 'joao@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
        VALUES ('{Guid.NewGuid()}', 'Maria Souza', 'maria@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
        VALUES ('{Guid.NewGuid()}', 'Pedro Santos', 'pedro@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
        VALUES ('{Guid.NewGuid()}', 'Ana Costa', 'ana@example.com', 1, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
        VALUES ('{Guid.NewGuid()}', 'Lucas Almeida', 'lucas@example.com', 0, GETUTCDATE())");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }
    }
}

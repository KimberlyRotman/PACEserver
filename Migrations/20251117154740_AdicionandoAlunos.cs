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
                VALUES ('4F14E9EB-2FC5-4476-9BF2-2ACCF59E4BB4', 'João Silva', 'joao@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
                VALUES ('B48FA829-6DC0-4DE9-96E0-147B90E997A3', 'Maria Souza', 'maria@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
                VALUES ('A7E3B617-EB6C-498D-9A74-162CB19D5578', 'Pedro Santos', 'pedro@example.com', 0, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
                VALUES ('8C65E1BB-7D75-4A78-B345-89A0BCF3CE6B', 'Ana Costa', 'ana@example.com', 1, GETUTCDATE())");

            migrationBuilder.Sql($@"INSERT INTO Alunos (Id, Nome, Email, Admin, DataCriacao)
                VALUES ('00F4945F-6D3E-405A-91AD-F870E716BA22', 'Lucas Almeida', 'lucas@example.com', 0, GETUTCDATE())");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }

    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoMaterias : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Estatística', '1', '2382B847-0913-47E3-9D62-87B031618CC3', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Projeto de Redes', '2', '3A2B7934-FEAD-40A7-8E75-8933F1293EC3', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Objetos 3D', '3', 'F045364B-CAE4-4175-AE2C-A91D888387D6', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Projeto de Sistemas Distribuídos', '4', '3A2B7934-FEAD-40A7-8E75-8933F1293EC3', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Desenvolvimento Web', '5', '37199FA4-F96B-45D0-85C1-C463AA75C965', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Interação-Humano Computador', '6', '364CE134-3EA7-457C-A38B-CA54F20061E7', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Processamento de Imagem', '7', '364CE134-3EA7-457C-A38B-CA54F20061E7', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Prática de Extensão', '8', '364CE134-3EA7-457C-A38B-CA54F20061E7', GETUTCDATE())");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Materias");
        }
    }
}

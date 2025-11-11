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
                VALUES ('{Guid.NewGuid()}', 'Estatística', '1', '08597405-B9F7-497F-8D67-2F110E6FE7AE', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Projeto de Redes', '2', 'ED9754EC-7725-4CB9-BB5D-E53C55E85957', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Objetos 3D', '3', '14FC1EE7-12BD-43AD-BC87-A02CD05CCDAF', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Projeto de Sistemas Distribuídos', '4', 'ED9754EC-7725-4CB9-BB5D-E53C55E85957', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Desenvolvimento Web', '5', 'B0394524-F926-4429-8DC5-302F1951392B', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Interação-Humano Computador', '6', 'ED81BB93-6651-45AF-B4EE-9552C0D699DD', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Processamento de Imagem', '7', 'ED81BB93-6651-45AF-B4EE-9552C0D699DD', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('{Guid.NewGuid()}', 'Prática de Extensão', '8', 'ED81BB93-6651-45AF-B4EE-9552C0D699DD', GETUTCDATE())");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

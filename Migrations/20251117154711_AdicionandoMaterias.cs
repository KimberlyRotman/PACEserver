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
                VALUES ('2B176E10-891F-4A13-9A5C-E03E8DA79D03', 'Estatística', '1', 'D585594B-A37E-46F9-9FC4-F0F0EB43DB91', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('B8E5754F-5F40-4F06-BD6A-791C460546CD', 'Projeto de Redes', '2', '2F156942-C1AF-47FB-AAF7-CE04E39BACFF', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('32019303-3C8B-4926-B645-7CD2E5C64276', 'Objetos 3D', '3', '0BD4555D-CD57-4EE0-95BC-1283BCDC2AC0', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('BB2057CB-4B6B-4AD0-9C03-9838E67F1773', 'Projeto de Sistemas Distribuídos', '4', '2F156942-C1AF-47FB-AAF7-CE04E39BACFF', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('6EFC2D99-A3A9-4DB1-8F74-21CB1D8BE1FE', 'Desenvolvimento Web', '5', '8225EC35-661F-4EFB-BFE1-16E16EF6E77E', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('7C74DEBF-3C04-48D4-9F99-135A309A760B', 'Interação-Humano Computador', '6', '1FB82B88-8BBF-41D8-8C8D-07A59529F9F6', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('6A001792-E912-4AEB-BAC7-B4BEB0E2E8CD', 'Processamento de Imagem', '7', '1FB82B88-8BBF-41D8-8C8D-07A59529F9F6', GETUTCDATE())");

            migrationBuilder.Sql($@" INSERT INTO Materias (Id, Nome, Codigo, ProfessorId, DataCriacao)
                VALUES ('5EED54C0-4F1B-4C01-8F46-0943BF43D30F', 'Prática de Extensão', '8', '1FB82B88-8BBF-41D8-8C8D-07A59529F9F6', GETUTCDATE())");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Materias");
        }

    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            // Estatística
            migrationBuilder.Sql(@"
                INSERT INTO Tarefas (
                    Id, Titulo, Descricao, MaximoIntegrantes, Tipo, Apresentacao,
                    DataApresentacao, DataEntrega, DataCriacao, PlataformaId, MateriaId
                ) VALUES (
                    'A1001001-0000-4000-9000-AAA000AAA001',
                    'Lista 1',
                    'Lista de Atividades para prova',
                    1,
                    2,
                    0,
                    NULL,
                    '2025-03-01',
                    GETUTCDATE(),
                    '5013EC0B-24A6-4D7E-A92B-10F1AA8BCA03',
                    '2B176E10-891F-4A13-9A5C-E03E8DA79D03'
                )
            ");

            // Desenvolvimento Web
            migrationBuilder.Sql(@"
                INSERT INTO Tarefas (
                    Id, Titulo, Descricao, MaximoIntegrantes, Tipo, Apresentacao,
                    DataApresentacao, DataEntrega, DataCriacao, PlataformaId, MateriaId
                ) VALUES (
                    'A1001001-0000-4000-9000-AAA000AAA002',
                    'Trabalho 1',
                    'Site pessoal em Node',
                    1,
                    2,
                    1,
                    '2025-05-02',
                    '2025-04-02',
                    GETUTCDATE(),
                    '732EE43F-8CB9-4E93-84FD-859C2C0DAAF9',
                    '6EFC2D99-A3A9-4DB1-8F74-21CB1D8BE1FE'
                )
            ");

            // IHC
            migrationBuilder.Sql(@"
                INSERT INTO Tarefas (
                    Id, Titulo, Descricao, MaximoIntegrantes, Tipo, Apresentacao,
                    DataApresentacao, DataEntrega, DataCriacao, PlataformaId, MateriaId
                ) VALUES (
                    'A1001001-0000-4000-9000-AAA000AAA003',
                    'Projeto Figma',
                    'Fazer um protótipo para site de venda de carro no Figma',
                    2,
                    2,
                    1,
                    '2025-05-04',
                    '2025-06-03',
                    GETUTCDATE(),
                    'AB69DF30-1090-4A00-B643-0842C9BC5AEF',
                    '7C74DEBF-3C04-48D4-9F99-135A309A760B'
                )
            ");

            // Redes
            migrationBuilder.Sql(@"
                INSERT INTO Tarefas (
                    Id, Titulo, Descricao, MaximoIntegrantes, Tipo, Apresentacao,
                    DataApresentacao, DataEntrega, DataCriacao, PlataformaId, MateriaId
                ) VALUES (
                    'A1001001-0000-4000-9000-AAA000AAA004',
                    'Robo Simples',
                    'Fazer Robo com mão',
                    3,
                    2,
                    0,
                    NULL,
                    '2025-04-20',
                    GETUTCDATE(),
                    '732EE43F-8CB9-4E93-84FD-859C2C0DAAF9',
                    '32019303-3C8B-4926-B645-7CD2E5C64276'
                )
            ");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Tarefas");

        }
    }
}

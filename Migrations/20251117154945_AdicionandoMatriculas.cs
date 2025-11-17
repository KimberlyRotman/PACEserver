using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoMatriculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO MateriaAlunos (Id, AlunoId, MateriaId) VALUES
                (NEWID(), '4F14E9EB-2FC5-4476-9BF2-2ACCF59E4BB4', '2B176E10-891F-4A13-9A5C-E03E8DA79D03'), -- João - Estatística
                (NEWID(), '4F14E9EB-2FC5-4476-9BF2-2ACCF59E4BB4', '6EFC2D99-A3A9-4DB1-8F74-21CB1D8BE1FE'), -- João - Desenvolvimento Web

                (NEWID(), 'A7E3B617-EB6C-498D-9A74-162CB19D5578', '32019303-3C8B-4926-B645-7CD2E5C64276'), -- Pedro - Objetos 3D
                (NEWID(), 'A7E3B617-EB6C-498D-9A74-162CB19D5578', '7C74DEBF-3C04-48D4-9F99-135A309A760B'), -- Pedro - IHC

                (NEWID(), '00F4945F-6D3E-405A-91AD-F870E716BA22', 'BB2057CB-4B6B-4AD0-9C03-9838E67F1773'), -- Lucas - Sistemas Distribuídos
                (NEWID(), '00F4945F-6D3E-405A-91AD-F870E716BA22', '6A001792-E912-4AEB-BAC7-B4BEB0E2E8CD'), -- Lucas - Processamento de Imagem

                (NEWID(), 'B48FA829-6DC0-4DE9-96E0-147B90E997A3', '5EED54C0-4F1B-4C01-8F46-0943BF43D30F'), -- Maria - Extensão
                (NEWID(), 'B48FA829-6DC0-4DE9-96E0-147B90E997A3', 'B8E5754F-5F40-4F06-BD6A-791C460546CD'), -- Maria - Redes

                (NEWID(), '8C65E1BB-7D75-4A78-B345-89A0BCF3CE6B', '6EFC2D99-A3A9-4DB1-8F74-21CB1D8BE1FE'), -- Ana - Desenvolvimento Web
                (NEWID(), '8C65E1BB-7D75-4A78-B345-89A0BCF3CE6B', '7C74DEBF-3C04-48D4-9F99-135A309A760B')  -- Ana - IHC
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DELETE FROM MateriaAlunos 
        ");
        }

    }
}

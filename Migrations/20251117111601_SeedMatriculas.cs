using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class SeedMatriculas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO MateriaAlunos (Id, AlunoId, MateriaId) VALUES
                (NEWID(), '955ECBFD-4E41-4073-BBF1-122909343E0F', '56DE030B-EB76-4A46-A8DF-648483AE6975'), -- João - Estatística
                (NEWID(), '955ECBFD-4E41-4073-BBF1-122909343E0F', 'A5888907-AEC0-4DD7-B5B9-EA96CADE10FD'), -- João - Desenvolvimento Web

                (NEWID(), '753E4545-E5FF-4AB3-9AC4-1306CA7E6199', 'F08107C9-82C0-4539-B6AE-72987601F105'), -- Pedro - Objetos 3D
                (NEWID(), '753E4545-E5FF-4AB3-9AC4-1306CA7E6199', 'CFB66097-0BF8-4BC0-A947-E020C777F94B'), -- Pedro - IHC

                (NEWID(), '2CD3CF01-752E-42BB-8DC6-61FC0CD39452', 'DBFD7EEC-0397-4ED6-9061-BA9E10B54F9A'), -- Lucas - Sistemas Distribuídos
                (NEWID(), '2CD3CF01-752E-42BB-8DC6-61FC0CD39452', '689A9211-88C4-4E9D-8C57-E8145DBADF8F'), -- Lucas - Processamento de Imagem

                (NEWID(), '03C03500-DE49-46BF-B2FA-78CE9508A31C', 'BA27FFB7-DC0D-4E41-BA06-9CA0C3BE09E1'), -- Maria - Extensão
                (NEWID(), '03C03500-DE49-46BF-B2FA-78CE9508A31C', 'C75D45C5-7C97-4061-A1C0-994678616BF4'), -- Maria - Redes

                (NEWID(), '9EB2283C-D6FF-4463-A699-8E5911063655', 'A5888907-AEC0-4DD7-B5B9-EA96CADE10FD'), -- Ana - Desenvolvimento Web
                (NEWID(), '9EB2283C-D6FF-4463-A699-8E5911063655', 'CFB66097-0BF8-4BC0-A947-E020C777F94B')  -- Ana - IHC
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DELETE FROM MateriaAlunos 
            WHERE AlunoId IN (
                '955ECBFD-4E41-4073-BBF1-122909343E0F',
                '753E4545-E5FF-4AB3-9AC4-1306CA7E6199',
                '2CD3CF01-752E-42BB-8DC6-61FC0CD39452',
                '03C03500-DE49-46BF-B2FA-78CE9508A31C',
                '9EB2283C-D6FF-4463-A699-8E5911063655'
            );
        ");
        }
    }
}

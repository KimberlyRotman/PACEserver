using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoProfessorPlataforma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('8225EC35-661F-4EFB-BFE1-16E16EF6E77E', 'João Paulo Orlando', 'joao.orlando@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('0BD4555D-CD57-4EE0-95BC-1283BCDC2AC0', 'Marlon de Oliveira Vaz', 'marlon.vaz@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('D585594B-A37E-46F9-9FC4-F0F0EB43DB91', 'Thiago André Guimarães', 'thiago.guimaraes@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('2F156942-C1AF-47FB-AAF7-CE04E39BACFF', 'Gabriel Vinicius Canzi Candido', 'gabriel.candido@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('73AA1B51-5763-430E-8660-D34E7D7F4B29', 'Lauriana Paludo', 'lauriana.paludo@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('5495F918-CFD4-4628-81DD-8D7B37F2CDE3', 'Marcos Aurélio Pchek Laureano', 'marcos.laureano@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('616FD993-FA64-4DB4-895A-7BE4844F524B', 'Izaque Esteves da Silva', 'izaque.esteves@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('43E8E3F4-C9D9-447B-A23D-D7BF51066E44', 'Guilherme Werneck de Oliveira', 'guilherme.oliveira@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('CDC033C3-0C1D-4BAA-B2CD-D98C179DCD4D', 'Eliana Maria dos Santos', 'eliana.santos@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('3EC93959-D55E-4F33-8908-1F13C1087B97', 'Eduardo Tieppo', 'eduardo.tieppo@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('3B6528E1-435A-4F6A-B913-9498905C8C42', 'Atila de Paiva Teles', 'atila.teles@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('AA1A8A05-7322-4E12-9DEF-D9FCF4911AE0', 'Ana Maria de Fátima Leme Tarini', 'ana.tarini@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('7B896737-68AA-41EA-AAFB-F3DAE4ABF112', 'Álvaro Rogério Cantieri', 'alvaro.cantieri@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('F272C11B-8516-46B3-A8D2-845A5C5BF6C1', 'Aleffer Rocha', 'aleffer.rocha@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('97C2B94A-BC0B-4341-ABA1-CB0F86BBF949', 'William Simão de Deus', 'william.deus@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('1FB82B88-8BBF-41D8-8C8D-07A59529F9F6', 'Provisório', 'Provisorio')");

            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('732EE43F-8CB9-4E93-84FD-859C2C0DAAF9', 'Suap', 'https://suap.ifpr.edu.br/accounts/login/?next=/')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('F14B8A2C-A8A4-450C-BBBB-ED0B804BEE37', 'Google Classroom', 'https://classroom.google.com/')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('AB69DF30-1090-4A00-B643-0842C9BC5AEF', 'Email', 'https://mail.google.com/mail/u/0/?pli=1#inbox')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('5013EC0B-24A6-4D7E-A92B-10F1AA8BCA03', 'Presencial', 'none')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Professores");
            migrationBuilder.Sql("DELETE FROM Plataformas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoProfessoresEMaterias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'João Paulo Orlando', 'joao.orlando@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Marlon de Oliveira Vaz', 'marlon.vaz@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Thiago André Guimarães', 'thiago.guimaraes@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Gabriel Vinicius Canzi Candido', 'gabriel.candido@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Lauriana Paludo', 'lauriana.paludo@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Marcos Aurélio Pchek Laureano', 'marcos.laureano@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Izaque Esteves da Silva', 'izaque.esteves@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Guilherme Werneck de Oliveira', 'guilherme.oliveira@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Eliana Maria dos Santos', 'eliana.santos@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Eduardo Tieppo', 'eduardo.tieppo@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Atila de Paiva Teles', 'atila.teles@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Ana Maria de Fátima Leme Tarini', 'ana.tarini@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Álvaro Rogério Cantieri', 'alvaro.cantieri@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Aleffer Rocha', 'aleffer.rocha@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'William Simão de Deus', 'william.deus@ifpr.edu.br')");
            migrationBuilder.Sql($@"INSERT INTO Professores (Id, Nome, Email)
                VALUES ('{Guid.NewGuid()}', 'Provisório', 'Provisorio')");

            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('{Guid.NewGuid()}', 'Suap', 'https://suap.ifpr.edu.br/accounts/login/?next=/')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('{Guid.NewGuid()}', 'Google Classroom', 'https://classroom.google.com/')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('{Guid.NewGuid()}', 'Email', 'https://mail.google.com/mail/u/0/?pli=1#inbox')");
            migrationBuilder.Sql($@"INSERT INTO Plataformas (Id, Nome, Link)
                VALUES ('{Guid.NewGuid()}', 'Presencial', 'none')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Professores");
            migrationBuilder.Sql("DELETE FROM Plataformas");
        }
    }
}

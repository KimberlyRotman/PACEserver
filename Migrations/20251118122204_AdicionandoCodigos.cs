using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCodigos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "CodigoSequence",
                startValue: 1000L,
                incrementBy: 1);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Professores",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR CodigoSequence");

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Equipes",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR CodigoSequence");

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR CodigoSequence");

        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Equipes");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Alunos");
        }
    }
}

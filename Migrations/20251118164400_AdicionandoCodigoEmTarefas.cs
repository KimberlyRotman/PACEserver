using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PACEserver.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCodigoEmTarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "Tarefas",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR CodigoSequence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Tarefas");
        }
    }
}

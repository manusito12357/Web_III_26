using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wa_registroestudiantes.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCIEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ci",
                table: "Estudiantes",
                type: "int",
                maxLength: 8,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ci",
                table: "Estudiantes");
        }
    }
}

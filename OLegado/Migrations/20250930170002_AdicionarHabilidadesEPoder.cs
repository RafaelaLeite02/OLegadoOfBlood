using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLegado.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarHabilidadesEPoder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Habilidades",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NivelPoder",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Personalidade",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Habilidades",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "NivelPoder",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Personalidade",
                table: "Personagens");
        }
    }
}

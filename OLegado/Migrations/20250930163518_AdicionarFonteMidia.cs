using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLegado.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarFonteMidia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FonteMidia",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Personagens",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "FonteMidia",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Personagens");
        }
    }
}

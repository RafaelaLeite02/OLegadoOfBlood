using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLegado.Migrations
{
    /// <inheritdoc />
    public partial class Volta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Personagens",
                newName: "FotoURL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FotoURL",
                table: "Personagens",
                newName: "Foto");
        }
    }
}

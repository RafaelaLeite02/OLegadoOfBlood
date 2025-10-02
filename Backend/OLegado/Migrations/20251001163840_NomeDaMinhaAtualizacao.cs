using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLegado.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMinhaAtualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FotoURL",
                table: "Personagens",
                newName: "Foto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Personagens",
                newName: "FotoURL");
        }
    }
}

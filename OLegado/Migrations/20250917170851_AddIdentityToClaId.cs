using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OLegado.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityToClaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TipoCriaturas",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TipoCriaturas",
                newName: "Name");
        }
    }
}

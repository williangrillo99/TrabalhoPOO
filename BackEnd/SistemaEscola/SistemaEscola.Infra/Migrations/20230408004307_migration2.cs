using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEscola.Infra.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Professores_professoresId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_professoresId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "professoresId",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "professoresId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_professoresId",
                table: "Usuarios",
                column: "professoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Professores_professoresId",
                table: "Usuarios",
                column: "professoresId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

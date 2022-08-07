using Microsoft.EntityFrameworkCore.Migrations;

namespace app_babybay.Migrations
{
    public partial class V04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteira_Usuarios_UsuarioId",
                table: "Carteira");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carteira",
                table: "Carteira");

            migrationBuilder.RenameTable(
                name: "Carteira",
                newName: "Carteiras");

            migrationBuilder.RenameIndex(
                name: "IX_Carteira_UsuarioId",
                table: "Carteiras",
                newName: "IX_Carteiras_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carteiras",
                table: "Carteiras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carteiras_Usuarios_UsuarioId",
                table: "Carteiras",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carteiras_Usuarios_UsuarioId",
                table: "Carteiras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carteiras",
                table: "Carteiras");

            migrationBuilder.RenameTable(
                name: "Carteiras",
                newName: "Carteira");

            migrationBuilder.RenameIndex(
                name: "IX_Carteiras_UsuarioId",
                table: "Carteira",
                newName: "IX_Carteira_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carteira",
                table: "Carteira",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carteira_Usuarios_UsuarioId",
                table: "Carteira",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

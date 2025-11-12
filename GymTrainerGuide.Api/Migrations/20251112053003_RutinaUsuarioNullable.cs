using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainerGuide.Api.Migrations
{
    /// <inheritdoc />
    public partial class RutinaUsuarioNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Usuarios_UsuarioId",
                table: "Rutinas");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Rutinas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Usuarios_UsuarioId",
                table: "Rutinas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rutinas_Usuarios_UsuarioId",
                table: "Rutinas");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Rutinas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutinas_Usuarios_UsuarioId",
                table: "Rutinas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

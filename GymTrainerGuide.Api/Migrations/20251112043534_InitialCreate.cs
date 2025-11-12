using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainerGuide.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dificultad",
                table: "Rutinas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Musculo",
                table: "Rutinas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dificultad",
                table: "Rutinas");

            migrationBuilder.DropColumn(
                name: "Musculo",
                table: "Rutinas");
        }
    }
}

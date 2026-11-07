using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookVerse.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPrestatario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombrePrestatario",
                table: "Prestamos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefonoPrestatario",
                table: "Prestamos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombrePrestatario",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "TelefonoPrestatario",
                table: "Prestamos");
        }
    }
}

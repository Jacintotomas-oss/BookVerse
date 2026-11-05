using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookVerse.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            return;

            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    ID_Autor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Pais = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Autores__9626AD269DB38905", x => x.ID_Autor);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__02AA078559290476", x => x.ID_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    ID_Editorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Pais = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Editoria__BCB52C7889F45926", x => x.ID_Editorial);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: false),
                    Dui = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Contrasena = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Empleado__74056223C13843DD", x => x.Id_Empleado);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    ID_Series = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ID_Autor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Series__0843011BA2F6BBF1", x => x.ID_Series);
                    table.ForeignKey(
                        name: "FK__Series__ID_Autor__5070F446",
                        column: x => x.ID_Autor,
                        principalTable: "Autores",
                        principalColumn: "ID_Autor");
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    ID_Libro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ID_Series = table.Column<int>(type: "int", nullable: true),
                    ID_Categoria = table.Column<int>(type: "int", nullable: true),
                    ID_Autor = table.Column<int>(type: "int", nullable: true),
                    ID_Editorial = table.Column<int>(type: "int", nullable: true),
                    Numero_Serie = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Libros__B1E7FA10BEED634D", x => x.ID_Libro);
                    table.ForeignKey(
                        name: "FK__Libros__ID_Autor__5535A963",
                        column: x => x.ID_Autor,
                        principalTable: "Autores",
                        principalColumn: "ID_Autor");
                    table.ForeignKey(
                        name: "FK__Libros__ID_Categ__5441852A",
                        column: x => x.ID_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "ID_Categoria");
                    table.ForeignKey(
                        name: "FK__Libros__ID_Edito__5629CD9C",
                        column: x => x.ID_Editorial,
                        principalTable: "Editorial",
                        principalColumn: "ID_Editorial");
                    table.ForeignKey(
                        name: "FK__Libros__ID_Serie__534D60F1",
                        column: x => x.ID_Series,
                        principalTable: "Series",
                        principalColumn: "ID_Series");
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    ID_Prestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Libro = table.Column<int>(type: "int", nullable: true),
                    Fecha_Prestamo = table.Column<DateOnly>(type: "date", nullable: false),
                    Fecha_Devolucion = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prestamo__FE17DB17ADAAEBAB", x => x.ID_Prestamo);
                    table.ForeignKey(
                        name: "FK__Prestamos__ID_Li__5AEE82B9",
                        column: x => x.ID_Libro,
                        principalTable: "Libros",
                        principalColumn: "ID_Libro");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Empleado__E3237CF73AC55A33",
                table: "Empleado",
                column: "Usuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ID_Autor",
                table: "Libros",
                column: "ID_Autor");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ID_Categoria",
                table: "Libros",
                column: "ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ID_Editorial",
                table: "Libros",
                column: "ID_Editorial");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ID_Series",
                table: "Libros",
                column: "ID_Series");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_ID_Libro",
                table: "Prestamos",
                column: "ID_Libro");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ID_Autor",
                table: "Series",
                column: "ID_Autor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Editorial");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Autores");
        }
    }
}

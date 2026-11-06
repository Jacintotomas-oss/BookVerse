using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using BookVerse.Models;
using BookVerse.Services;

namespace BookVerse.Data
{
    public static class DbInitializer
    {
        public static void Inicializar()
        {
            using var context = new LibreriaContext();

            // Crea la base de datos y todas las tablas si no existen
            context.Database.EnsureCreated();

            // Si context.Database.EnsureCreated() no crea tablas en bases vacías preexistentes,
            // asegura la creación con IRelationalDatabaseCreator.
            var creator = context.Database.GetService<IDatabaseCreator>() as IRelationalDatabaseCreator;
            if (creator != null && !creator.HasTables())
            {
                creator.CreateTables();
            }

            // Si la tabla Empleados está vacía (!context.Empleados.Any()), inserta el usuario administrador por defecto
            if (!context.Empleados.Any())
            {
                var admin = new Empleado
                {
                    Nombre = "Administrador",
                    Usuario = "admin",
                    Contrasena = Seguridad.HashPassword("admin123"),
                    Email = "admin@bookverse.com",
                    Telefono = "7000-0000",
                    Dui = "00000000-0"
                };

                context.Empleados.Add(admin);
                context.SaveChanges();
            }

            // Si la tabla Autores está vacía (!context.Autores.Any()), inserta autores, editoriales, categorías, series y libros
            if (!context.Autores.Any())
            {
                // 10 Autores
                var autorGabo = new Autore { Nombre = "Gabriel García Márquez", Pais = "Colombia" };
                var autorCervantes = new Autore { Nombre = "Miguel de Cervantes", Pais = "España" };
                var autorAllende = new Autore { Nombre = "Isabel Allende", Pais = "Chile" };
                var autorBorges = new Autore { Nombre = "Jorge Luis Borges", Pais = "Argentina" };
                var autorVargasLlosa = new Autore { Nombre = "Mario Vargas Llosa", Pais = "Perú" };
                var autorCortazar = new Autore { Nombre = "Julio Cortázar", Pais = "Argentina" };
                var autorAusten = new Autore { Nombre = "Jane Austen", Pais = "Reino Unido" };
                var autorOrwell = new Autore { Nombre = "George Orwell", Pais = "Reino Unido" };
                var autorKing = new Autore { Nombre = "Stephen King", Pais = "Estados Unidos" };
                var autorRowling = new Autore { Nombre = "J.K. Rowling", Pais = "Reino Unido" };

                context.Autores.AddRange(
                    autorGabo, autorCervantes, autorAllende, autorBorges, autorVargasLlosa,
                    autorCortazar, autorAusten, autorOrwell, autorKing, autorRowling
                );

                // 4 Editoriales
                var editorialPlaneta = new Editorial { Nombre = "Editorial Planeta", Pais = "España" };
                var editorialPenguin = new Editorial { Nombre = "Penguin Random House", Pais = "Reino Unido" };
                var editorialAlfaguara = new Editorial { Nombre = "Alfaguara", Pais = "España" };
                var editorialAnagrama = new Editorial { Nombre = "Anagrama", Pais = "España" };

                context.Editorials.AddRange(editorialPlaneta, editorialPenguin, editorialAlfaguara, editorialAnagrama);

                // 5 Categorías
                var catNovela = new Categoria { NombreCategoria = "Novela" };
                var catFiccion = new Categoria { NombreCategoria = "Ficción" };
                var catClasicos = new Categoria { NombreCategoria = "Clásicos" };
                var catFantasia = new Categoria { NombreCategoria = "Fantasía" };
                var catTerror = new Categoria { NombreCategoria = "Terror" };

                context.Categorias.AddRange(catNovela, catFiccion, catClasicos, catFantasia, catTerror);

                // 2 Series
                var serieHarryPotter = new Series { Nombre = "Saga Harry Potter", IdAutorNavigation = autorRowling };
                var serieIndependiente = new Series { Nombre = "Independiente" };

                context.Series.AddRange(serieHarryPotter, serieIndependiente);

                // 10 Libros con stock real, asignando sus respectivas relaciones y descripciones
                var libros = new List<Libro>
                {
                    new Libro
                    {
                        Titulo = "Cien años de soledad",
                        Descripcion = "Obra cumbre del realismo mágico sobre la saga de la familia Buendía en el mítico pueblo de Macondo.",
                        Stock = 15,
                        IdAutorNavigation = autorGabo,
                        IdEditorialNavigation = editorialPlaneta,
                        IdCategoriaNavigation = catNovela,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "Don Quijote de la Mancha",
                        Descripcion = "Las célebres aventuras del ingenioso hidalgo Don Quijote y su fiel escudero Sancho Panza.",
                        Stock = 10,
                        IdAutorNavigation = autorCervantes,
                        IdEditorialNavigation = editorialAlfaguara,
                        IdCategoriaNavigation = catClasicos,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "La casa de los espíritus",
                        Descripcion = "Crónica familiar que entreteje cuatro generaciones de la familia Trueba entre amores y convulsión social.",
                        Stock = 12,
                        IdAutorNavigation = autorAllende,
                        IdEditorialNavigation = editorialPenguin,
                        IdCategoriaNavigation = catNovela,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "Ficciones",
                        Descripcion = "Colección de relatos laberínticos y filosóficos que exploran el infinito, los espejos y el tiempo.",
                        Stock = 8,
                        IdAutorNavigation = autorBorges,
                        IdEditorialNavigation = editorialAnagrama,
                        IdCategoriaNavigation = catFiccion,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "La ciudad y los perros",
                        Descripcion = "Retrato crudo de la disciplina castrense y la violencia juvenil dentro del Colegio Militar Leoncio Prado.",
                        Stock = 14,
                        IdAutorNavigation = autorVargasLlosa,
                        IdEditorialNavigation = editorialAlfaguara,
                        IdCategoriaNavigation = catNovela,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "Rayuela",
                        Descripcion = "Novela innovadora y vanguardista que desafía la estructura tradicional de lectura a través de Horacio Oliveira.",
                        Stock = 9,
                        IdAutorNavigation = autorCortazar,
                        IdEditorialNavigation = editorialAlfaguara,
                        IdCategoriaNavigation = catNovela,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "Orgullo y prejuicio",
                        Descripcion = "Clásico romance que explora las relaciones humanas, los prejuicios de clase y el matrimonio en la Inglaterra del siglo XIX.",
                        Stock = 20,
                        IdAutorNavigation = autorAusten,
                        IdEditorialNavigation = editorialPenguin,
                        IdCategoriaNavigation = catClasicos,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "1984",
                        Descripcion = "Novela distópica sobre un régimen totalitario omnipresente encabezado por la figura del Gran Hermano.",
                        Stock = 25,
                        IdAutorNavigation = autorOrwell,
                        IdEditorialNavigation = editorialPlaneta,
                        IdCategoriaNavigation = catFiccion,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "El resplandor",
                        Descripcion = "Inquietante historia de terror psicológico sobre el aislamiento y fuerzas sobrenaturales en el Hotel Overlook.",
                        Stock = 18,
                        IdAutorNavigation = autorKing,
                        IdEditorialNavigation = editorialPenguin,
                        IdCategoriaNavigation = catTerror,
                        IdSeriesNavigation = serieIndependiente,
                        NumeroSerie = null
                    },
                    new Libro
                    {
                        Titulo = "Harry Potter y la piedra filosofal",
                        Descripcion = "Primer libro de la saga mágica en el que Harry descubre su verdadera identidad y asiste a Hogwarts.",
                        Stock = 30,
                        IdAutorNavigation = autorRowling,
                        IdEditorialNavigation = editorialPlaneta,
                        IdCategoriaNavigation = catFantasia,
                        IdSeriesNavigation = serieHarryPotter,
                        NumeroSerie = 1
                    }
                };

                context.Libros.AddRange(libros);
                context.SaveChanges();
            }
        }
    }
}

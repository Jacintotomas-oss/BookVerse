using System;
using System.Collections.Generic;
using BookVerse.Models;
using Microsoft.EntityFrameworkCore;

namespace BookVerse.Data;

public partial class LibreriaContext : DbContext
{
    public LibreriaContext()
    {
    }

    public LibreriaContext(DbContextOptions<LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Editorial> Editorials { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-8TB9QBU;Database=Libreria;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autores__9626AD269DB38905");

            entity.Property(e => e.IdAutor).HasColumnName("ID_Autor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__02AA078559290476");

            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Editorial>(entity =>
        {
            entity.HasKey(e => e.IdEditorial).HasName("PK__Editoria__BCB52C7889F45926");

            entity.ToTable("Editorial");

            entity.Property(e => e.IdEditorial).HasColumnName("ID_Editorial");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__74056223C13843DD");

            entity.ToTable("Empleado");

            entity.HasIndex(e => e.Usuario, "UQ__Empleado__E3237CF73AC55A33").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dui)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("PK__Libros__B1E7FA10BEED634D");

            entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");
            entity.Property(e => e.IdAutor).HasColumnName("ID_Autor");
            entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");
            entity.Property(e => e.IdEditorial).HasColumnName("ID_Editorial");
            entity.Property(e => e.IdSeries).HasColumnName("ID_Series");
            entity.Property(e => e.NumeroSerie).HasColumnName("Numero_Serie");
            
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .HasConstraintName("FK__Libros__ID_Autor__5535A963");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Libros__ID_Categ__5441852A");

            entity.HasOne(d => d.IdEditorialNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdEditorial)
                .HasConstraintName("FK__Libros__ID_Edito__5629CD9C");

            entity.HasOne(d => d.IdSeriesNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdSeries)
                .HasConstraintName("FK__Libros__ID_Serie__534D60F1");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.IdPrestamo).HasName("PK__Prestamo__FE17DB17ADAAEBAB");

            entity.Property(e => e.IdPrestamo).HasColumnName("ID_Prestamo");
            entity.Property(e => e.FechaDevolucion).HasColumnName("Fecha_Devolucion");
            entity.Property(e => e.FechaPrestamo).HasColumnName("Fecha_Prestamo");
            entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

            entity.HasOne(d => d.IdLibroNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdLibro)
                .HasConstraintName("FK__Prestamos__ID_Li__5AEE82B9");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.HasKey(e => e.IdSeries).HasName("PK__Series__0843011BA2F6BBF1");

            entity.Property(e => e.IdSeries).HasColumnName("ID_Series");
            entity.Property(e => e.IdAutor).HasColumnName("ID_Autor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Series)
                .HasForeignKey(d => d.IdAutor)
                .HasConstraintName("FK__Series__ID_Autor__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

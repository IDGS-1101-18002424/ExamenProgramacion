using Microsoft.EntityFrameworkCore;
using SistemaNoticias.Models;

/*
 *      DbContext SistemaNoticias
 * 
 * Fehca inicial: 24/10/2024
 * Realizado por: Roberto Ortiz
 * Contacto: roberto.ortizrodriguez99@gmail.com
 * 
 * Fecha de modificación: 24/10/2024
 * Modifico: [Nombre y contacto]
 */

namespace SistemaNoticias.Data
{
    public class SistemaNoticiasContext : DbContext
    {
        public SistemaNoticiasContext(DbContextOptions<SistemaNoticiasContext> options) : base(options)
        {
        }

        public DbSet<Personal> Personals { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<RespuestaComentario> RespuestaComentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personal>().ToTable("Personal");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Nota>().ToTable("Nota");
            modelBuilder.Entity<Comentario>().ToTable("Comentario");
            modelBuilder.Entity<RespuestaComentario>().ToTable("RespuestaComentario");

            modelBuilder.Entity<Personal>()
                .HasKey(p => p.IdPersonal);

            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.IdUsuario);

            modelBuilder.Entity<Nota>()
                .HasKey(n => n.IdNota);

            modelBuilder.Entity<Comentario>()
                .HasKey(c => c.IdComentario);

            modelBuilder.Entity<RespuestaComentario>()
                .HasKey(rc => rc.IdRespuesta);

            // Configurar las relaciones
            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Personal)
                .WithMany()
                .HasForeignKey(n => n.IdPersonal)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Nota)
                .WithMany()
                .HasForeignKey(c => c.IdNota)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.IdUsuario)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RespuestaComentario>()
                .HasOne(rc => rc.Comentario)
                .WithMany()
                .HasForeignKey(rc => rc.IdComentario)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RespuestaComentario>()
                .HasOne(rc => rc.Usuario)
                .WithMany()
                .HasForeignKey(rc => rc.IdUsuario)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}


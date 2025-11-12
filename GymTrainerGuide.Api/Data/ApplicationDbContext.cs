using GymTrainerGuide.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GymTrainerGuide.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<NivelExperiencia> NivelExperiencia { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Ejercicio> Ejercicios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        public DbSet<RutinaEjercicio> RutinaEjercicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rutina>()
                 .HasOne(r => r.Usuario)
    .WithMany(u => u.Rutinas)
    .HasForeignKey(r => r.UsuarioId)
    .OnDelete(DeleteBehavior.SetNull); // cambia de Restrict a SetNull

            modelBuilder.Entity<Ejercicio>()
                .HasOne(e => e.Equipo)
                .WithMany(eq => eq.Ejercicios)
                .HasForeignKey(e => e.EquipoId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}

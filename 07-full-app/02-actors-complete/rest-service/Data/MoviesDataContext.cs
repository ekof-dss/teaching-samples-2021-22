using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

using project.Models;

namespace project.Data
{
    public class MoviesDataContext : DbContext
    {
        public MoviesDataContext(DbContextOptions<MoviesDataContext> options,
            IConfiguration config) : base(options)
        {
        }
        public DbSet<Actor> Actors { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasColumnName("CountryId")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Name)
                    .HasColumnName("CountryName")
                    .HasMaxLength(255)
                    .IsRequired();
                entity.Property(e => e.Code)
                    .HasColumnName("CountryCode")
                    .HasMaxLength(50)
                    .IsRequired();
            });
            modelBuilder.Entity<Country>().ToTable("Country");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasColumnName("ActorId")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsRequired();
                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsRequired();
                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("BirthDate");
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Actors)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Actor_Country");
            });
            modelBuilder.Entity<Actor>().ToTable("Actor");
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QA.Models;

public partial class AspsolutionsContext : DbContext
{
    public AspsolutionsContext()
    {
    }

    public AspsolutionsContext(DbContextOptions<AspsolutionsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Registerlog> Registerlogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Registerlog>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__REGISTER__7B9E7F35A3AAADA6");

            entity.ToTable("REGISTERLOG");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("USERID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

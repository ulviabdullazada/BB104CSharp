using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Entities;

public partial class PizzaMizzaConsoleContext : DbContext
{
    public PizzaMizzaConsoleContext()
    {
    }

    public PizzaMizzaConsoleContext(DbContextOptions<PizzaMizzaConsoleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<PizzaIngredient> PizzaIngredients { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PizzaMizzaConsole;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredie__3214EC07EF6CC7B2");

            entity.Property(e => e.Name).HasMaxLength(32);
        });

        modelBuilder.Entity<PizzaIngredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PizzaIng__3214EC072DAF2CA3");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.PizzaIngredients)
                .HasForeignKey(d => d.IngredientId)
                .HasConstraintName("FK__PizzaIngr__Ingre__3B75D760");

            entity.HasOne(d => d.Product).WithMany(p => p.PizzaIngredients)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__PizzaIngr__Produ__3A81B327");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC0715817FFE");

            entity.Property(e => e.Name).HasMaxLength(64);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07CAA1CB86");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4031D8BD7").IsUnique();

            entity.Property(e => e.Password).HasMaxLength(32);
            entity.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

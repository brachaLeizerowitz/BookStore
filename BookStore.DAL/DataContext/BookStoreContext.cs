using System;
using System.Collections.Generic;
using BookStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.DataContext;

public partial class BookStoreContext : DbContext
{
    public BookStoreContext()
    {
    }

    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

  /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OI99LUA;Database=BookStore;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
  */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Upc).HasName("PK__Books__C5B16F68401C3C4D");

            entity.Property(e => e.Upc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UPC");
            entity.Property(e => e.Author).HasMaxLength(100);
            entity.Property(e => e.Img).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

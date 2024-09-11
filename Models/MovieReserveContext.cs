using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookMyMovie.Models;

public partial class MovieReserveContext : DbContext
{
    public MovieReserveContext()
    {
    }

    public MovieReserveContext(DbContextOptions<MovieReserveContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    public virtual DbSet<Theater> Theaters { get; set; }

    public virtual DbSet<TheaterMovie> TheaterMovies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MovieReserve;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Admin");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK_Bookings");

            entity.ToTable("Booking");

            entity.Property(e => e.TheaterMovieId).HasColumnName("Theater_MovieId");

            entity.HasOne(d => d.Cust).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustId)
                .HasConstraintName("FK_Booking_Customer");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movie");

            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Screen>(entity =>
        {
            entity.ToTable("Screen");

            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Theater>(entity =>
        {
            entity.ToTable("Theater");

            entity.Property(e => e.Location).IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TheaterMovie>(entity =>
        {
            entity.HasKey(e => e.TheaterMovieId).HasName("PK_Table_1");

            entity.ToTable("Theater_Movie");

            entity.Property(e => e.TheaterMovieId).HasColumnName("Theater_MovieId");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ScreenId).HasColumnName("Screen_Id");
            entity.Property(e => e.ShowDownTime).HasColumnType("datetime");
            entity.Property(e => e.ShowOnTime).HasColumnType("datetime");
            entity.Property(e => e.ShowType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Booking).WithMany(p => p.TheaterMovies)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK_Theater_Movie_Booking1");

            entity.HasOne(d => d.Movie).WithMany(p => p.TheaterMovies)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK_Theater_Movie_Movie1");

            entity.HasOne(d => d.Screen).WithMany(p => p.TheaterMovies)
                .HasForeignKey(d => d.ScreenId)
                .HasConstraintName("FK_Theater_Movie_Theater_Screen");

            entity.HasOne(d => d.Theater).WithMany(p => p.TheaterMovies)
                .HasForeignKey(d => d.TheaterId)
                .HasConstraintName("FK_Theater_Movie_Theater1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

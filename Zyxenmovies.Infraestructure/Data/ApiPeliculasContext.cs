using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Zyxenmovies.Infraestructure.Data;
using Zyxenmovies.Domain.entities;

#nullable disable

namespace Zyxenmovies.Infraestructure.Data
{
    public partial class ApiPeliculasContext : DbContext
    {
        public ApiPeliculasContext()
        {
        }

        public ApiPeliculasContext(DbContextOptions<ApiPeliculasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Picture> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ApiPeliculas.mssql.somee.com;Initial Catalog=ApiPeliculas;Persist Security Info=False;User ID=Zyxen_prodby_SQLLogin_1;Password=irddtso565");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasKey(e => e.IdPicture);

                entity.ToTable("Picture");

                entity.Property(e => e.IdPicture).HasColumnName("idPicture");

                entity.Property(e => e.DirectorPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("directorPicture");

                entity.Property(e => e.GenrePicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genrePicture");

                entity.Property(e => e.PublicationPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("publicationPicture");

                entity.Property(e => e.PuntuationPicture).HasColumnName("puntuationPicture");

                entity.Property(e => e.RatingPicture).HasColumnName("ratingPicture");

                entity.Property(e => e.TitlePicture)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titlePicture");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

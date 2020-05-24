using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamenRest.Models
{
    public partial class codigos_postalesContext : DbContext
    {
        public codigos_postalesContext()
        {
        }

        public codigos_postalesContext(DbContextOptions<codigos_postalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CodigosPostales> CodigosPostales { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=1LBH002062;Initial Catalog=codigos_postales;integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodigosPostales>(entity =>
            {
                entity.HasKey(e => e.IdPostal)
                    .HasName("PK__codigos___E7D259D44C0321F9");

                entity.ToTable("codigos_postales");

                entity.Property(e => e.IdPostal).HasColumnName("id_postal");

                entity.Property(e => e.AsentamientoPostal)
                    .IsRequired()
                    .HasColumnName("asentamiento_postal")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadPostal)
                    .IsRequired()
                    .HasColumnName("ciudad_postal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoPostal)
                    .IsRequired()
                    .HasColumnName("estado_postal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioPostal)
                    .IsRequired()
                    .HasColumnName("municipio_postal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAsentamientoPostal)
                    .IsRequired()
                    .HasColumnName("tipo_asentamiento_postal")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaPostal)
                    .HasColumnName("zona_postal")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.EmailUser)
                    .IsRequired()
                    .HasColumnName("email_user")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FachaSistemaUser)
                    .IsRequired()
                    .HasColumnName("facha_sistema_user")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreCompletoUser)
                    .HasColumnName("nombre_completo_user")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUser)
                    .IsRequired()
                    .HasColumnName("nombre_user")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PassUser)
                    .IsRequired()
                    .HasColumnName("pass_user")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrivilegioUser)
                    .HasColumnName("Privilegio_user")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

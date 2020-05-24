﻿// <auto-generated />
using ExamenRest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamenRest.Migrations
{
    [DbContext(typeof(codigos_postalesContext))]
    partial class codigos_postalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamenRest.Models.CodigosPostales", b =>
                {
                    b.Property<int>("IdPostal")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_postal")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AsentamientoPostal")
                        .IsRequired()
                        .HasColumnName("asentamiento_postal")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("CiudadPostal")
                        .IsRequired()
                        .HasColumnName("ciudad_postal")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnName("codigo_postal")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("EstadoPostal")
                        .IsRequired()
                        .HasColumnName("estado_postal")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("MunicipioPostal")
                        .IsRequired()
                        .HasColumnName("municipio_postal")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("TipoAsentamientoPostal")
                        .IsRequired()
                        .HasColumnName("tipo_asentamiento_postal")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("ZonaPostal")
                        .HasColumnName("zona_postal")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdPostal")
                        .HasName("PK__codigos___E7D259D44C0321F9");

                    b.ToTable("codigos_postales");
                });

            modelBuilder.Entity("ExamenRest.Models.Users", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_user")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailUser")
                        .IsRequired()
                        .HasColumnName("email_user")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("FachaSistemaUser")
                        .IsRequired()
                        .HasColumnName("facha_sistema_user")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("NombreCompletoUser")
                        .HasColumnName("nombre_completo_user")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("NombreUser")
                        .IsRequired()
                        .HasColumnName("nombre_user")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("PassUser")
                        .IsRequired()
                        .HasColumnName("pass_user")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("PrivilegioUser")
                        .HasColumnName("Privilegio_user")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Mantenimientos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mantenimientos.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200328112320_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mantenimientos.Models.Asignatura", b =>
                {
                    b.Property<int>("AsignaturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AsignaturaID");

                    b.ToTable("Asignatura");
                });

            modelBuilder.Entity("Mantenimientos.Models.AsignaturaEstudiante", b =>
                {
                    b.Property<int>("AsignaturaEstudianteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaID")
                        .HasColumnType("int");

                    b.Property<int>("EstudiantesID")
                        .HasColumnType("int");

                    b.HasKey("AsignaturaEstudianteID");

                    b.HasIndex("AsignaturaID");

                    b.HasIndex("EstudiantesID");

                    b.ToTable("AsignaturaEstudiantes");
                });

            modelBuilder.Entity("Mantenimientos.Models.AsignaturaProfesores", b =>
                {
                    b.Property<int>("asignaturaProfesoresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsignaturaID")
                        .HasColumnType("int");

                    b.Property<int>("ProfesoresID")
                        .HasColumnType("int");

                    b.HasKey("asignaturaProfesoresID");

                    b.HasIndex("AsignaturaID");

                    b.HasIndex("ProfesoresID");

                    b.ToTable("AsignaturaProfesores");
                });

            modelBuilder.Entity("Mantenimientos.Models.Estudiantes", b =>
                {
                    b.Property<int>("EstudiantesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("EstudiantesID");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Mantenimientos.Models.Profesores", b =>
                {
                    b.Property<int>("ProfesoresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfesoresID");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Mantenimientos.Models.AsignaturaEstudiante", b =>
                {
                    b.HasOne("Mantenimientos.Models.Asignatura", "Asignatura")
                        .WithMany("AsignaturaEstudiantes")
                        .HasForeignKey("AsignaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mantenimientos.Models.Estudiantes", "Estudiantes")
                        .WithMany("AsignaturaEstudiantes")
                        .HasForeignKey("EstudiantesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mantenimientos.Models.AsignaturaProfesores", b =>
                {
                    b.HasOne("Mantenimientos.Models.Asignatura", "Asignatura")
                        .WithMany("AsignaturaProfesores")
                        .HasForeignKey("AsignaturaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mantenimientos.Models.Profesores", "Profesores")
                        .WithMany("AsignaturaProfesores")
                        .HasForeignKey("ProfesoresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
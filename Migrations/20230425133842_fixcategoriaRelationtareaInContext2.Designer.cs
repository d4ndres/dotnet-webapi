﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_learn_entity_framework_core.Context;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20230425133842_fixcategoriaRelationtareaInContext2")]
    partial class fixcategoriaRelationtareaInContext2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_02_learn_entity_framework_core.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("766970ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                            Description = "Sacar al perro, ir de compras y salvar el mundo",
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("266970ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                            Description = "Cortar pelo",
                            Nombre = "Actividades personales",
                            Peso = 10
                        });
                });

            modelBuilder.Entity("_02_learn_entity_framework_core.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                            CategoriaId = new Guid("766970ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                            FechaCreacion = new DateTime(2023, 4, 25, 8, 38, 42, 181, DateTimeKind.Local).AddTicks(7612),
                            PrioridadTarea = 1,
                            Titulo = "Pago de servicios"
                        },
                        new
                        {
                            TareaId = new Guid("762370ac-6a58-4c4d-b9b3-f9ccfd976e92"),
                            CategoriaId = new Guid("766970ac-6a58-4c4d-b9b3-f9ccfd976e94"),
                            FechaCreacion = new DateTime(2023, 4, 25, 8, 38, 42, 181, DateTimeKind.Local).AddTicks(7630),
                            PrioridadTarea = 0,
                            Titulo = "Ver pelicula"
                        });
                });

            modelBuilder.Entity("_02_learn_entity_framework_core.Models.Tarea", b =>
                {
                    b.HasOne("_02_learn_entity_framework_core.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("_02_learn_entity_framework_core.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}

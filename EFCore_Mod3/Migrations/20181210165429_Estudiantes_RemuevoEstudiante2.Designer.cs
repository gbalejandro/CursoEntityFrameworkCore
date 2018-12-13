﻿// <auto-generated />
using System;
using EFCore_Mod3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore_Mod3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181210165429_Estudiantes_RemuevoEstudiante2")]
    partial class Estudiantes_RemuevoEstudiante2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore_Mod3.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstaBorrado");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new { Id = 25, EstaBorrado = false, FechaNacimiento = new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Nombre = "Data Seed" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
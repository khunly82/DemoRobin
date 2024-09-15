﻿// <auto-generated />
using System;
using DemoRobin.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoRobin.DAL.Migrations
{
    [DbContext(typeof(PokedexContext))]
    [Migration("20240915143019_AddFirstData")]
    partial class AddFirstData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoRobin.Domain.Entities.Pokemon", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EvolutionFinale")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Poids")
                        .HasColumnType("int");

                    b.Property<int>("Taille")
                        .HasColumnType("int");

                    b.Property<int>("Type1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Type2Id")
                        .HasColumnType("int");

                    b.HasKey("Numero");

                    b.HasIndex("Type1Id");

                    b.HasIndex("Type2Id");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            Numero = 1,
                            DateCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EvolutionFinale = false,
                            Nom = "Bulbizarre",
                            Poids = 20,
                            Taille = 70,
                            Type1Id = 1
                        },
                        new
                        {
                            Numero = 2,
                            DateCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EvolutionFinale = false,
                            Nom = "Herbizarre",
                            Poids = 50,
                            Taille = 80,
                            Type1Id = 1
                        },
                        new
                        {
                            Numero = 3,
                            DateCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EvolutionFinale = true,
                            Nom = "Florizarre",
                            Poids = 100,
                            Taille = 2,
                            Type1Id = 1
                        });
                });

            modelBuilder.Entity("DemoRobin.Domain.Entities.PokemonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Plante"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Feu"
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Eau"
                        });
                });

            modelBuilder.Entity("DemoRobin.Domain.Entities.Pokemon", b =>
                {
                    b.HasOne("DemoRobin.Domain.Entities.PokemonType", "Type1")
                        .WithMany()
                        .HasForeignKey("Type1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoRobin.Domain.Entities.PokemonType", "Type2")
                        .WithMany()
                        .HasForeignKey("Type2Id");

                    b.Navigation("Type1");

                    b.Navigation("Type2");
                });
#pragma warning restore 612, 618
        }
    }
}

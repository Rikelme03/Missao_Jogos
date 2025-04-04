﻿// <auto-generated />
using System;
using Api_Jogo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Jogo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250403170910_Db_Jogos")]
    partial class Db_Jogos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Jogo.Domains.Jogos", b =>
                {
                    b.Property<Guid>("JogosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeJogo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("JogosId");

                    b.HasIndex("NomeJogo")
                        .IsUnique();

                    b.ToTable("Jogos");
                });

            modelBuilder.Entity("Api_Jogo.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JogosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("JogosId");

                    b.HasIndex("NomeUsuario")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Api_Jogo.Domains.Usuarios", b =>
                {
                    b.HasOne("Api_Jogo.Domains.Jogos", "Jogos")
                        .WithMany()
                        .HasForeignKey("JogosId");

                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}

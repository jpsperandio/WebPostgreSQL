﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebPostgreSQL.Models;

#nullable disable

namespace WebPostgreSQL.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebPostgreSQL.Models.Competidores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Altura")
                        .HasColumnType("double precision")
                        .HasColumnName("Altura");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<double>("Peso")
                        .HasColumnType("double precision")
                        .HasColumnName("Peso");

                    b.Property<char>("Sexo")
                        .HasColumnType("character(1)")
                        .HasColumnName("Sexo");

                    b.Property<double>("TemperaturaMediaCorpo")
                        .HasColumnType("double precision")
                        .HasColumnName("TemperaturaMediaCorpo");

                    b.HasKey("Id");

                    b.ToTable("Competidores");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.HistoricoCorrida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetidorId")
                        .HasColumnType("integer")
                        .HasColumnName("CompetidorId");

                    b.Property<DateTime>("DataCorrida")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataCorrida");

                    b.Property<int>("PistaCorridaId")
                        .HasColumnType("integer")
                        .HasColumnName("PistaCorridaId");

                    b.Property<decimal>("TempoGasto")
                        .HasColumnType("numeric")
                        .HasColumnName("TempoGasto");

                    b.HasKey("Id");

                    b.ToTable("Histórico de corridas");
                });

            modelBuilder.Entity("WebPostgreSQL.Models.PistaCorrida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("PistaCorrida");
                });
#pragma warning restore 612, 618
        }
    }
}
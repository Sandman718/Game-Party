﻿// <auto-generated />
using System;
using DL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DL.Migrations
{
    [DbContext(typeof(PRDBContext))]
    partial class PRDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.AboutPlayer", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("ID"));

                    b.Property<string>("FavoriteGames")
                        .HasColumnType("text");

                    b.Property<string>("GameLibrary")
                        .HasColumnType("text");

                    b.Property<int?>("GamesLost")
                        .HasColumnType("integer");

                    b.Property<int?>("GamesWon")
                        .HasColumnType("integer");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("AboutPlayer");
                });

            modelBuilder.Entity("Models.Game", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("ID"));

                    b.Property<string>("GameName")
                        .HasColumnType("text");

                    b.Property<int?>("PlayerCount")
                        .HasColumnType("integer");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("PlayerID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Models.Player", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("ID"));

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int?>("RoomID")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("RoomID");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Models.Room", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("ID"));

                    b.Property<int?>("PlayerCount")
                        .HasColumnType("integer");

                    b.Property<int?>("RoomCode")
                        .HasColumnType("integer");

                    b.Property<string>("RoomName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Models.AboutPlayer", b =>
                {
                    b.HasOne("Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Models.Game", b =>
                {
                    b.HasOne("Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Models.Player", b =>
                {
                    b.HasOne("Models.Room", null)
                        .WithMany("Players")
                        .HasForeignKey("RoomID");
                });

            modelBuilder.Entity("Models.Room", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
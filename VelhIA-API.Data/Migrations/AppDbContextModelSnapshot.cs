﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VelhIA_API.Data.Context;

namespace VelhIA_API.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Board", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MatchId")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("Board");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Column", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("I")
                        .HasColumnType("int");

                    b.Property<int>("J")
                        .HasColumnType("int");

                    b.Property<string>("LineId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Column");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Line", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<string>("BoardId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Match", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.MatchPlayer", b =>
                {
                    b.Property<string>("MatchId")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("PlayerId")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MatchId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Match_Player");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Player", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<int?>("AlgorithmType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Piece")
                        .HasColumnType("longtext");

                    b.Property<bool>("StartPlaying")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.PlayerMove", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<string>("ColumnId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PlayerId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Move");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Result", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastMoveId")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("MatchId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<TimeSpan>("MatchTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("Moves")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("LastMoveId");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("Result");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Victory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LoserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("ResultId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WinnerId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.HasIndex("LoserId");

                    b.HasIndex("ResultId")
                        .IsUnique();

                    b.HasIndex("WinnerId");

                    b.ToTable("Victory");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Board", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Match", "Match")
                        .WithOne("Board")
                        .HasForeignKey("VelhIA_API.Domain.Entities.Board", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Match");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Column", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Line", "Line")
                        .WithMany("Columns")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Line");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Line", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Board", "Board")
                        .WithMany("Lines")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.MatchPlayer", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Match", "Match")
                        .WithMany("Players")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VelhIA_API.Domain.Entities.Player", "Player")
                        .WithMany("Matches")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.PlayerMove", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Column", "Column")
                        .WithMany()
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VelhIA_API.Domain.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Column");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Result", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.PlayerMove", "LastMove")
                        .WithMany()
                        .HasForeignKey("LastMoveId");

                    b.HasOne("VelhIA_API.Domain.Entities.Match", "Match")
                        .WithOne("Result")
                        .HasForeignKey("VelhIA_API.Domain.Entities.Result", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LastMove");

                    b.Navigation("Match");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Victory", b =>
                {
                    b.HasOne("VelhIA_API.Domain.Entities.Player", "Loser")
                        .WithMany()
                        .HasForeignKey("LoserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VelhIA_API.Domain.Entities.Result", "Result")
                        .WithOne("Victory")
                        .HasForeignKey("VelhIA_API.Domain.Entities.Victory", "ResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VelhIA_API.Domain.Entities.Player", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loser");

                    b.Navigation("Result");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Board", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Line", b =>
                {
                    b.Navigation("Columns");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Match", b =>
                {
                    b.Navigation("Board");

                    b.Navigation("Players");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Player", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("VelhIA_API.Domain.Entities.Result", b =>
                {
                    b.Navigation("Victory");
                });
#pragma warning restore 612, 618
        }
    }
}

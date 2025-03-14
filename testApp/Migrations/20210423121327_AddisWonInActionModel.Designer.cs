﻿// <auto-generated />
using System;
using ARPG.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ARPG.Migrations
{
    [DbContext(typeof(ARPGContext))]
    [Migration("20210423121327_AddisWonInActionModel")]
    partial class AddisWonInActionModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ARPG.Models.Action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ActionNumber")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("HPGains")
                        .HasColumnType("int");

                    b.Property<int>("SuccessorCode1")
                        .HasColumnType("int");

                    b.Property<int>("SuccessorCode2")
                        .HasColumnType("int");

                    b.Property<string>("SuccessorMessage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuccessorMessage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isWon")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("ARPG.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("ARPG.Models.Action", b =>
                {
                    b.HasOne("ARPG.Models.Book", "book")
                        .WithMany("Actions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

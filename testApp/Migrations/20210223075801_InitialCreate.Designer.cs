﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ARPG.Models.Data;

namespace ARPG.Migrations
{
    [DbContext(typeof(ARPGContext))]
    [Migration("20210223075801_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
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

                    b.Property<int>("SuccessorCode1")
                        .HasColumnType("int");

                    b.Property<int>("SuccessorCode2")
                        .HasColumnType("int");

                    b.Property<string>("SuccessorMessage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuccessorMessage2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Action");
                });
#pragma warning restore 612, 618
        }
    }
}

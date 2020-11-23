﻿// <auto-generated />
using System;
using BlazorApp4s.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp4s.Migrations
{
    [DbContext(typeof(BlazorApp4sContext))]
    partial class BlazorApp4sContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorApp4s.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PastureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PastureId");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("BlazorApp4s.Models.Operator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Operator");
                });

            modelBuilder.Entity("BlazorApp4s.Models.Pasture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperatorId");

                    b.ToTable("Pasture");
                });

            modelBuilder.Entity("BlazorApp4s.Models.Field", b =>
                {
                    b.HasOne("BlazorApp4s.Models.Pasture", null)
                        .WithMany("Fields")
                        .HasForeignKey("PastureId");
                });

            modelBuilder.Entity("BlazorApp4s.Models.Pasture", b =>
                {
                    b.HasOne("BlazorApp4s.Models.Operator", null)
                        .WithMany("Pastures")
                        .HasForeignKey("OperatorId");
                });
#pragma warning restore 612, 618
        }
    }
}
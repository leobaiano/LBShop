﻿// <auto-generated />
using LBShop.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LBShop.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20221104202118_SeedProductDataTableOnDB")]
    partial class SeedProductDataTableOnDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LBShop.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "Canecas",
                            Description = "Descrição",
                            ImageURL = "Imagem URL",
                            Name = "Caneca 5",
                            Price = "9,70"
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "Canecas",
                            Description = "Descrição",
                            ImageURL = "Imagem URL",
                            Name = "Caneca 5",
                            Price = "9,70"
                        },
                        new
                        {
                            Id = 21L,
                            CategoryName = "Canecas",
                            Description = "Descrição",
                            ImageURL = "Imagem URL",
                            Name = "Caneca 5",
                            Price = "9,70"
                        },
                        new
                        {
                            Id = 31L,
                            CategoryName = "Canecas",
                            Description = "Descrição",
                            ImageURL = "Imagem URL",
                            Name = "Caneca 5",
                            Price = "9,70"
                        },
                        new
                        {
                            Id = 41L,
                            CategoryName = "Canecas",
                            Description = "Descrição",
                            ImageURL = "Imagem URL",
                            Name = "Caneca 5",
                            Price = "9,70"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

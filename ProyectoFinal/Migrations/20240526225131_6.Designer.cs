﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal.Data;

#nullable disable

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(ProyectoFinalDbContext))]
    [Migration("20240526225131_6")]
    partial class _6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoFinal.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.Property<int?>("proveedorid")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("proveedorid");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Proveedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Cel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Venta", b =>
                {
                    b.Property<int>("nroVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("nroVenta"), 1L, 1);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("clienteid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("productoid")
                        .HasColumnType("int");

                    b.HasKey("nroVenta");

                    b.HasIndex("clienteid");

                    b.HasIndex("productoid");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Producto", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Proveedor", "proveedor")
                        .WithMany()
                        .HasForeignKey("proveedorid");

                    b.Navigation("proveedor");
                });

            modelBuilder.Entity("ProyectoFinal.Models.Venta", b =>
                {
                    b.HasOne("ProyectoFinal.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid");

                    b.HasOne("ProyectoFinal.Models.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("productoid");

                    b.Navigation("cliente");

                    b.Navigation("producto");
                });
#pragma warning restore 612, 618
        }
    }
}

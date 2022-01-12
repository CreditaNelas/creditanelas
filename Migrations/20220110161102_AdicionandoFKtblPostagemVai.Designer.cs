﻿// <auto-generated />
using System;
using CreditaNelas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CreditaNelas.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220110161102_AdicionandoFKtblPostagemVai")]
    partial class AdicionandoFKtblPostagemVai
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreditaNelas.Models.Postagem", b =>
                {
                    b.Property<int>("Id_Postagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Postagem");

                    b.HasIndex("UsuarioId_Usuario");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("CreditaNelas.Models.Usuario", b =>
                {
                    b.Property<int>("Id_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmacaoSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_Usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CreditaNelas.Models.Postagem", b =>
                {
                    b.HasOne("CreditaNelas.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId_Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

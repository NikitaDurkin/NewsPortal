﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsPortal.Identity.Database;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NewsPortal.Identity.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190819083736_docker")]
    partial class docker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("NewsPortal.Identity.Database.Models.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Guid");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("a1ef9b02-68db-4243-8f16-2076e4405a7c"),
                            Login = "nikita@mail.ru",
                            Password = "AQAAAAEAACcQAAAAEJxEsUZQ+rchi0uw9yWqspojc+jO3LdrqedWsVfYyTzLkwclGZx50nLRXKevZ9Rddg=="
                        },
                        new
                        {
                            Guid = new Guid("08e9c9df-9f7b-41dd-8f58-cf574eba4e23"),
                            Login = "ivan@mail.ru",
                            Password = "AQAAAAEAACcQAAAAEDmRadqhukJsfrnj7CHqeEGo2lMvf83/8p/V05al3vLdwScUYLY4s43OMTZ/m9WbRg=="
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
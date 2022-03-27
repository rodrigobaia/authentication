﻿// <auto-generated />
using System;
using Authentication.Domain.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Authentication.Domain.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Authentication.Domain.ApplicationId", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Id");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Active");

                    b.Property<DateTime>("CreatedIn")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreatedIn");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApplicationIds", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dc35e706-ba1f-452b-8e8a-23bc998477f3",
                            Active = true,
                            CreatedIn = new DateTime(2022, 3, 27, 20, 26, 47, 342, DateTimeKind.Local).AddTicks(6054),
                            Name = "FICHAPJ"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

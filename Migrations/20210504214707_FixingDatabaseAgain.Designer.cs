﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsweatherAPI.Data;

namespace NewsweatherAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210504214707_FixingDatabaseAgain")]
    partial class FixingDatabaseAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsweatherAPI.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City_Population")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("NewsweatherAPI.Models.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Presure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weather_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weather_Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wind_Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wind_Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wind_Speed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId")
                        .IsUnique()
                        .HasFilter("[CityId] IS NOT NULL");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("NewsweatherAPI.Models.Weather", b =>
                {
                    b.HasOne("NewsweatherAPI.Models.City", "City")
                        .WithOne("Weather")
                        .HasForeignKey("NewsweatherAPI.Models.Weather", "CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("NewsweatherAPI.Models.City", b =>
                {
                    b.Navigation("Weather");
                });
#pragma warning restore 612, 618
        }
    }
}

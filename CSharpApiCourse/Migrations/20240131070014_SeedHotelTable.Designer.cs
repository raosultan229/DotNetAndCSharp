﻿// <auto-generated />
using System;
using CSharpApiCourse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpApiCourse.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240131070014_SeedHotelTable")]
    partial class SeedHotelTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSharpApiCourse.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                            ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                            IsAvailable = true,
                            Name = "Serena hotel",
                            Occupancy = 5,
                            Rate = 20000.0,
                            Rooms = 5,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "PC Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                            ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                            IsAvailable = true,
                            Name = "PC hotel",
                            Occupancy = 5,
                            Rate = 10000.0,
                            Rooms = 5,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nova Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                            ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                            IsAvailable = false,
                            Name = "Nova hotel",
                            Occupancy = 5,
                            Rate = 20000.0,
                            Rooms = 3,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                            ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                            IsAvailable = true,
                            Name = "Royal hotel",
                            Occupancy = 5,
                            Rate = 50000.0,
                            Rooms = 3,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                            ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                            IsAvailable = false,
                            Name = "Palace hotel",
                            Occupancy = 5,
                            Rate = 70000.0,
                            Rooms = 6,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

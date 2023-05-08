﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo_rest_api.Context;

#nullable disable

namespace demo_rest_api.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("demo_rest_api.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Actors")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Awards")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Metascore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Plot")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasMaxLength(2048)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rated")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Released")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Response")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RuntimeMinutes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Writer")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("imdbID")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double?>("imdbRating")
                        .HasColumnType("REAL");

                    b.Property<int?>("imdbVotes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("demo_rest_api.Entities.FilmImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FilmId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(2048)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmImages");
                });

            modelBuilder.Entity("demo_rest_api.Entities.FilmImage", b =>
                {
                    b.HasOne("demo_rest_api.Entities.Film", null)
                        .WithMany("Images")
                        .HasForeignKey("FilmId");
                });

            modelBuilder.Entity("demo_rest_api.Entities.Film", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}

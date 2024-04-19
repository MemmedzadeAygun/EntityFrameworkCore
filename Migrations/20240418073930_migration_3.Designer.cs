﻿// <auto-generated />
using System;
using EfCoreTasks1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreTasks1.Migrations
{
    [DbContext(typeof(StoredContext))]
    [Migration("20240418073930_migration_3")]
    partial class migration_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreTasks1.Classes.Directors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.MovieSubtitle", b =>
                {
                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.Property<int>("SubtitlesId")
                        .HasColumnType("int");

                    b.HasKey("MoviesId", "SubtitlesId");

                    b.HasIndex("SubtitlesId");

                    b.ToTable("MovieSubtitle");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MovieReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.MoviesImdbDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ImdbPoint")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MoviesImdbDetails");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Subtitles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubtitleLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subtitles");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.MovieSubtitle", b =>
                {
                    b.HasOne("EfCoreTasks1.Classes.Movies", "Movies")
                        .WithMany("MovieSubtitles")
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreTasks1.Classes.Subtitles", "Subtitles")
                        .WithMany("MovieSubtitles")
                        .HasForeignKey("SubtitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movies");

                    b.Navigation("Subtitles");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Movies", b =>
                {
                    b.HasOne("EfCoreTasks1.Classes.Directors", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.MoviesImdbDetail", b =>
                {
                    b.HasOne("EfCoreTasks1.Classes.Movies", "Movie")
                        .WithOne("MoviesImdbDetails")
                        .HasForeignKey("EfCoreTasks1.Classes.MoviesImdbDetail", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Directors", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Movies", b =>
                {
                    b.Navigation("MovieSubtitles");

                    b.Navigation("MoviesImdbDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("EfCoreTasks1.Classes.Subtitles", b =>
                {
                    b.Navigation("MovieSubtitles");
                });
#pragma warning restore 612, 618
        }
    }
}

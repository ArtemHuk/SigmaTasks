﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task15;

namespace Task15.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220107160335_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Task15.Models.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Task15.Models.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Task15.Models.City", b =>
                {
                    b.HasOne("Task15.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Task15.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}

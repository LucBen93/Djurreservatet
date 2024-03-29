﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(AnimalSanctumContext))]
    partial class AnimalSanctumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("WebApi.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Time")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}

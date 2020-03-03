﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WedProj.Models;

namespace WedProj.Migrations
{
    [DbContext(typeof(WedContext))]
    partial class WedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WedProj.Models.Assoc", b =>
                {
                    b.Property<int>("AssocId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventWedId");

                    b.Property<int?>("PersonUserId");

                    b.Property<int>("UId");

                    b.Property<int>("WId");

                    b.HasKey("AssocId");

                    b.HasIndex("EventWedId");

                    b.HasIndex("PersonUserId");

                    b.ToTable("Assocs");
                });

            modelBuilder.Entity("WedProj.Models.RegUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WedProj.Models.Wedding", b =>
                {
                    b.Property<int>("WedId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatorId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Wedder_One")
                        .IsRequired();

                    b.Property<string>("Wedder_Two")
                        .IsRequired();

                    b.Property<string>("WeddingAddress")
                        .IsRequired();

                    b.Property<DateTime>("WeddingDate");

                    b.HasKey("WedId");

                    b.ToTable("Weddings");
                });

            modelBuilder.Entity("WedProj.Models.Assoc", b =>
                {
                    b.HasOne("WedProj.Models.Wedding", "Event")
                        .WithMany("Guests")
                        .HasForeignKey("EventWedId");

                    b.HasOne("WedProj.Models.RegUser", "Person")
                        .WithMany("Events")
                        .HasForeignKey("PersonUserId");
                });
#pragma warning restore 612, 618
        }
    }
}

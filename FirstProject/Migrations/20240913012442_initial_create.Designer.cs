﻿// <auto-generated />
using FirstProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstProject.Migrations
{
    [DbContext(typeof(ContextClass))]
    [Migration("20240913012442_initial_create")]
    partial class initial_create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "A collection of written or printed works",
                            Name = "Books"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Books for writing notes",
                            Name = "NoteBooks"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Writing instruments made of graphite",
                            Name = "Pencils"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 9,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 10,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 11,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        },
                        new
                        {
                            CategoryId = 12,
                            Description = "Various coloring materials",
                            Name = "Colors"
                        });
                });

            modelBuilder.Entity("FirstProject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "qq",
                            ImagePath = "books1.jpg",
                            Price = 1,
                            Quantity = 1,
                            Title = "Books"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "rr",
                            ImagePath = "books2.jpg",
                            Price = 2,
                            Quantity = 1,
                            Title = "Books"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Description = "rr",
                            ImagePath = "story.jpg",
                            Price = 3,
                            Quantity = 1,
                            Title = "Story"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4,
                            Description = "rr",
                            ImagePath = "paper1.jpg",
                            Price = 4,
                            Quantity = 1,
                            Title = "Paper"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 5,
                            Description = "rr",
                            ImagePath = "pince.jpg",
                            Price = 5,
                            Quantity = 2,
                            Title = "Pince"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 6,
                            Description = "rr",
                            ImagePath = "paper2.jpg",
                            Price = 6,
                            Quantity = 2,
                            Title = "Paper"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 7,
                            Description = "rr",
                            ImagePath = "color.jpg",
                            Price = 7,
                            Quantity = 2,
                            Title = "Color"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 8,
                            Description = "rr",
                            ImagePath = "books3.jpg",
                            Price = 8,
                            Quantity = 2,
                            Title = "Books"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 9,
                            Description = "rr",
                            ImagePath = "paper3.jpg",
                            Price = 9,
                            Quantity = 2,
                            Title = "Paper"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 10,
                            Description = "rr",
                            ImagePath = "highl.jpg",
                            Price = 10,
                            Quantity = 3,
                            Title = "Highl"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 11,
                            Description = "rr",
                            ImagePath = "note.jpg",
                            Price = 11,
                            Quantity = 3,
                            Title = "Note"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 12,
                            Description = "rr",
                            ImagePath = "paper4.jpg",
                            Price = 12,
                            Quantity = 3,
                            Title = "Paper"
                        });
                });

            modelBuilder.Entity("FirstProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FirstProject.Models.Product", b =>
                {
                    b.HasOne("FirstProject.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FirstProject.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
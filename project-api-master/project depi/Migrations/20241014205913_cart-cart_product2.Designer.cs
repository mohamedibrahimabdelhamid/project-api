﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_depi.Data_Layer;

#nullable disable

namespace project_depi.Migrations
{
    [DbContext(typeof(AppContextDB))]
    [Migration("20241014205913_cart-cart_product2")]
    partial class cartcart_product2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("project_depi.Data_Layer.Models.Brand", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("_id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Cart", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cartOwner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("numOfCartItemt")
                        .HasColumnType("int");

                    b.Property<decimal>("totalCartPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("_id");

                    b.HasIndex("cartOwner");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Cart_Product", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("_id");

                    b.HasIndex("cartId");

                    b.HasIndex("productId");

                    b.ToTable("Cart_Product");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Category", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Product", b =>
                {
                    b.Property<Guid>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("availableColors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("barndId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("priceAfterDiscount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("ratingsAverage")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("ratingsQuantity")
                        .HasColumnType("int");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sold")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("_id");

                    b.HasIndex("barndId");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.SubCategory", b =>
                {
                    b.Property<Guid>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("categoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("productId");

                    b.HasIndex("categoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.User", b =>
                {
                    b.Property<Guid>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Cart", b =>
                {
                    b.HasOne("project_depi.Data_Layer.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("cartOwner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Cart_Product", b =>
                {
                    b.HasOne("project_depi.Data_Layer.Models.Cart", "Cart")
                        .WithMany("Cart_Products")
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_depi.Data_Layer.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Product", b =>
                {
                    b.HasOne("project_depi.Data_Layer.Models.Brand", "Brand")
                        .WithMany("products")
                        .HasForeignKey("barndId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_depi.Data_Layer.Models.Category", "Category")
                        .WithMany("products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.SubCategory", b =>
                {
                    b.HasOne("project_depi.Data_Layer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_depi.Data_Layer.Models.Product", "Product")
                        .WithMany("subCategories")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Brand", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Cart", b =>
                {
                    b.Navigation("Cart_Products");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("project_depi.Data_Layer.Models.Product", b =>
                {
                    b.Navigation("subCategories");
                });
#pragma warning restore 612, 618
        }
    }
}

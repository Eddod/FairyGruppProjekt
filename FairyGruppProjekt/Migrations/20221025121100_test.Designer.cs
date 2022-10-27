﻿// <auto-generated />
using System;
using FairyGruppProjekt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FairyGruppProjekt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221025121100_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FairyGruppProjekt.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Product"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Product"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Product"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Product"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Product"
                        });
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Amount = 0,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateProduct-small.jpg",
                            ImageUrl = "\\Images\\chocolateProduct.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Product",
                            Price = 4.95m
                        },
                        new
                        {
                            ProductId = 2,
                            Amount = 0,
                            CategoryId = 1,
                            Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateProduct2-small.jpg",
                            ImageUrl = "\\Images\\chocolateProduct2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Chocolate Product",
                            Price = 3.95m
                        },
                        new
                        {
                            ProductId = 3,
                            Amount = 0,
                            CategoryId = 1,
                            Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateProduct3-small.jpg",
                            ImageUrl = "\\Images\\chocolateProduct3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Chocolate Product",
                            Price = 5.75m
                        },
                        new
                        {
                            ProductId = 4,
                            Amount = 0,
                            CategoryId = 2,
                            Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitProduct-small.jpg",
                            ImageUrl = "\\Images\\fruitProduct.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Product",
                            Price = 3.95m
                        },
                        new
                        {
                            ProductId = 5,
                            Amount = 0,
                            CategoryId = 2,
                            Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitProduct2-small.jpg",
                            ImageUrl = "\\Images\\fruitProduct2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Product",
                            Price = 7.00m
                        },
                        new
                        {
                            ProductId = 6,
                            Amount = 0,
                            CategoryId = 2,
                            Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\fruitProduct3-small.jpg",
                            ImageUrl = "\\Images\\fruitProduct3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Fruit Product",
                            Price = 11.25m
                        },
                        new
                        {
                            ProductId = 7,
                            Amount = 0,
                            CategoryId = 3,
                            Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyProduct-small.jpg",
                            ImageUrl = "\\Images\\gummyProduct.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Product",
                            Price = 3.95m
                        },
                        new
                        {
                            ProductId = 8,
                            Amount = 0,
                            CategoryId = 3,
                            Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyProduct2-small.jpg",
                            ImageUrl = "\\Images\\gummyProduct2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Another Assorted Gummy Product",
                            Price = 1.95m
                        },
                        new
                        {
                            ProductId = 9,
                            Amount = 0,
                            CategoryId = 3,
                            Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\gummyProduct3-small.jpg",
                            ImageUrl = "\\Images\\gummyProduct3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gummy Product",
                            Price = 13.95m
                        },
                        new
                        {
                            ProductId = 10,
                            Amount = 0,
                            CategoryId = 4,
                            Description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenProduct-small.jpg",
                            ImageUrl = "\\Images\\halloweenProduct.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Halloween Product",
                            Price = 1.95m
                        },
                        new
                        {
                            ProductId = 11,
                            Amount = 0,
                            CategoryId = 4,
                            Description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenProduct2-small.jpg",
                            ImageUrl = "\\Images\\halloweenProduct2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Product",
                            Price = 12.95m
                        },
                        new
                        {
                            ProductId = 12,
                            Amount = 0,
                            CategoryId = 4,
                            Description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\halloweenProduct3-small.jpg",
                            ImageUrl = "\\Images\\halloweenProduct3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Halloween Product",
                            Price = 21.95m
                        },
                        new
                        {
                            ProductId = 13,
                            Amount = 0,
                            CategoryId = 5,
                            Description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardProduct-small.jpg",
                            ImageUrl = "\\Images\\hardProduct.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Hard Product",
                            Price = 6.95m
                        },
                        new
                        {
                            ProductId = 14,
                            Amount = 0,
                            CategoryId = 5,
                            Description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardProduct2-small.jpg",
                            ImageUrl = "\\Images\\hardProduct2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Hard Product",
                            Price = 2.95m
                        },
                        new
                        {
                            ProductId = 15,
                            Amount = 0,
                            CategoryId = 5,
                            Description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                            ImageThumbnailUrl = "\\Images\\thumbnails\\hardProduct3-small.jpg",
                            ImageUrl = "\\Images\\hardProduct3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Best Hard Product",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemsId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemsId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.OrderDetail", b =>
                {
                    b.HasOne("FairyGruppProjekt.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairyGruppProjekt.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.Product", b =>
                {
                    b.HasOne("FairyGruppProjekt.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("FairyGruppProjekt.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FairyGruppProjekt.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

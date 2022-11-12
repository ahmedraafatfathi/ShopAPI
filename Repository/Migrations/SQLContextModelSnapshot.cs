﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(SQLContext))]
    partial class SQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MSG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserInfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(5366),
                            Name = "TV",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(5392)
                        },
                        new
                        {
                            Id = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6214),
                            Name = "Laptop",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6230)
                        },
                        new
                        {
                            Id = new Guid("f00829d3-db27-4fde-8bb3-75bf418d82fe"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6269),
                            Name = "Sound System",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(6271)
                        });
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubmitted")
                        .HasColumnType("bit");

                    b.Property<int>("MaxDeliveryDays")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableQty")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                            AvailableQty = 4000,
                            CategoryId = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(7670),
                            Desc = "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver",
                            Name = "HP 255 G8 Laptop - Ryzen 5 3500U, 8 GB RAM, 1 TB HDD, AMD Radeon Vega 8 Graphics, 15.6-Inch HD, DOS - Asteroid silver",
                            Price = 11100f,
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 240, DateTimeKind.Local).AddTicks(7685)
                        },
                        new
                        {
                            Id = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                            AvailableQty = 4000,
                            CategoryId = new Guid("759c950d-4eff-4315-9c5a-f95f1eb68778"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2303),
                            Desc = "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite",
                            Name = "SAMSUNG Galaxy Tab S8 Ultra 14.6in - 256GB, 12GB RAM, 5G, WiFi - Graphite",
                            Price = 32000f,
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2328)
                        },
                        new
                        {
                            Id = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                            AvailableQty = 4000,
                            CategoryId = new Guid("c8ef64a5-65d1-45cd-b240-30f61a777508"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2457),
                            Desc = "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription",
                            Name = "75 inch Samsung TV Tournament Subscription package + free TOD inclusive one month package with 1 subscription",
                            Price = 24000f,
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(2462)
                        });
                });

            modelBuilder.Entity("Entities.ProductDiscount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiscountQty")
                        .HasColumnType("int");

                    b.Property<float>("DiscountValue")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDiscounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13db5c7d-5e59-42e7-b273-928705693929"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(3974),
                            DiscountQty = 2,
                            DiscountValue = 5f,
                            ProductId = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(3984)
                        },
                        new
                        {
                            Id = new Guid("a0e9d928-3d97-4bab-8185-372139fc88dd"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6487),
                            DiscountQty = 3,
                            DiscountValue = 15f,
                            ProductId = new Guid("c9541fc0-cab7-4db8-b8cd-20e3228fa7d5"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6496)
                        },
                        new
                        {
                            Id = new Guid("ac91ea37-0ae6-4ba3-83b4-e7e12cfcc6e9"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6558),
                            DiscountQty = 2,
                            DiscountValue = 7f,
                            ProductId = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6561)
                        },
                        new
                        {
                            Id = new Guid("665401d2-99f8-4209-815d-369e7e41048d"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6571),
                            DiscountQty = 3,
                            DiscountValue = 20f,
                            ProductId = new Guid("39e44bcc-3b80-4bd7-9f76-dc23911b4a28"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6573)
                        },
                        new
                        {
                            Id = new Guid("56ada7dd-4176-46a3-8053-bec9741b6e80"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6702),
                            DiscountQty = 2,
                            DiscountValue = 10f,
                            ProductId = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6711)
                        },
                        new
                        {
                            Id = new Guid("c5709294-653a-41b5-8cb9-6259fb57856f"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6721),
                            DiscountQty = 3,
                            DiscountValue = 25f,
                            ProductId = new Guid("68b4070e-2254-47f6-91b3-66d059ac88b1"),
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 241, DateTimeKind.Local).AddTicks(6723)
                        });
                });

            modelBuilder.Entity("Entities.RegisterAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegisterAttempts");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoginType")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f26f330c-05c9-4b5d-9323-0a35aa0cdc8d"),
                            Active = true,
                            BirthDate = new DateTime(1990, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 239, DateTimeKind.Local).AddTicks(5508),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            Gender = 1,
                            IsBlocked = false,
                            LoginType = 3,
                            PhoneNumber = "01111111999",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 239, DateTimeKind.Local).AddTicks(5535),
                            UserName = "admin",
                            UserRoleId = new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f")
                        });
                });

            modelBuilder.Entity("Entities.UserPassword", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HashPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserPasswords");
                });

            modelBuilder.Entity("Entities.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad70cd85-c933-4e4c-9be5-82679530f79f"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 236, DateTimeKind.Local).AddTicks(794),
                            Role = "Admin",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(3373)
                        },
                        new
                        {
                            Id = new Guid("567b8222-bd08-4d84-95ce-3369c9ab0cf6"),
                            CreatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(4661),
                            Role = "Anonymous",
                            UpdatedDate = new DateTime(2022, 11, 11, 15, 53, 30, 237, DateTimeKind.Local).AddTicks(4678)
                        });
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.OrderDetails", b =>
                {
                    b.HasOne("Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.HasOne("Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.ProductDiscount", b =>
                {
                    b.HasOne("Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.RegisterAttempt", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.HasOne("Entities.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.UserPassword", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
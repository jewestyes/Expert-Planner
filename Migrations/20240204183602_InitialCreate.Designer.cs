﻿// <auto-generated />
using System;
using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpertPlanner.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240204183602_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("ExpertPlanner.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("ApplicationUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c6b7645a-d102-48d2-bb6e-640f53b5946f",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "dcedb391-41c6-4725-b9c9-66ef83d7c5be",
                            EmailConfirmed = false,
                            FirstName = "Вадим",
                            LastName = "Эдуардович",
                            LockoutEnabled = false,
                            MiddleName = "Дроздов",
                            PhoneNumberConfirmed = false,
                            Position = 2,
                            Role = 1,
                            SecurityStamp = "ebce0763-b56e-4e75-8b26-ec214078f28d",
                            TwoFactorEnabled = false,
                            UserName = "1"
                        },
                        new
                        {
                            Id = "80cf1849-630b-4009-b652-6c596084a66a",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "06a51f57-2289-4ade-9a60-318876676109",
                            EmailConfirmed = false,
                            FirstName = "Иван",
                            LastName = "Валерьевич",
                            LockoutEnabled = false,
                            MiddleName = "Кулаков",
                            PhoneNumberConfirmed = false,
                            Position = 3,
                            Role = 1,
                            SecurityStamp = "2260fb4d-f18e-479e-8e3b-cc7f185347bc",
                            TwoFactorEnabled = false,
                            UserName = "2"
                        },
                        new
                        {
                            Id = "0a97d310-eccc-4d36-97b3-ec17fcb2b6ff",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "fca46622-b08c-42a0-a3c9-45ee5b13487e",
                            EmailConfirmed = false,
                            FirstName = "Михаил",
                            LastName = "Аркадьевич",
                            LockoutEnabled = false,
                            MiddleName = "Киселев",
                            PhoneNumberConfirmed = false,
                            Position = 4,
                            Role = 1,
                            SecurityStamp = "9ba4e48b-8e71-4c22-aa64-c4c1f790bc0a",
                            TwoFactorEnabled = false,
                            UserName = "3"
                        },
                        new
                        {
                            Id = "b0678a7d-5659-4fa2-8d6c-19f1a5ec1f67",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "a5c4e34c-c30f-47ef-854d-06bd30e648c7",
                            EmailConfirmed = false,
                            FirstName = "Николай",
                            LastName = "Сергеевич",
                            LockoutEnabled = false,
                            MiddleName = "Самохин",
                            PhoneNumberConfirmed = false,
                            Position = 4,
                            Role = 1,
                            SecurityStamp = "a438b152-4027-4cc9-a11d-44c26d67c581",
                            TwoFactorEnabled = false,
                            UserName = "4"
                        },
                        new
                        {
                            Id = "09e13926-bfea-4b8d-a343-86957fde4c42",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "65edb681-06e1-4827-8ed1-14df375fbe74",
                            EmailConfirmed = false,
                            FirstName = "Даниил",
                            LastName = "Андреевич",
                            LockoutEnabled = false,
                            MiddleName = "Пашинцев",
                            PhoneNumberConfirmed = false,
                            Position = 3,
                            Role = 1,
                            SecurityStamp = "7577d212-a3a8-46c1-8bc3-ac41fa0e0559",
                            TwoFactorEnabled = false,
                            UserName = "5"
                        },
                        new
                        {
                            Id = "b65ae270-1def-4536-8858-8939a998b59e",
                            AccessFailedCount = 0,
                            City = "Екатеринбург",
                            ConcurrencyStamp = "33bb42b9-82ba-48aa-a06b-9fad075552d1",
                            EmailConfirmed = false,
                            FirstName = "Андрей",
                            LastName = "Александрович",
                            LockoutEnabled = false,
                            MiddleName = "Ветлугин",
                            PhoneNumberConfirmed = false,
                            Position = 2,
                            Role = 1,
                            SecurityStamp = "9ef823a6-6305-4cee-9c49-efcb274c4f22",
                            TwoFactorEnabled = false,
                            UserName = "6"
                        });
                });

            modelBuilder.Entity("ExpertPlanner.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("ExpertPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExpertPlanner.Models.ApplicationUser", null)
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

                    b.HasOne("ExpertPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExpertPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

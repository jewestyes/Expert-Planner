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
    [Migration("20240204191104_LoginUpdate")]
    partial class LoginUpdate
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
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
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
                            Id = "f6b93270-2275-48f3-8e03-119af3bda197",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "8af608a5-4ee4-4bae-951c-42f29d989885",
                            EmailConfirmed = false,
                            FirstName = "Вадим",
                            LastName = "Эдуардович",
                            LockoutEnabled = false,
                            MiddleName = "Дроздов",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEFVWxeh8Y2wIO9CAVywyInRD0fKkMHnRoEv5t3VsacdHZU2j+k0HSiDuWeshvDGLmA==",
                            PhoneNumberConfirmed = false,
                            Position = 2,
                            Role = 0,
                            SecurityStamp = "fa0a91fa-b816-4017-8c3e-c2a36b187c0b",
                            TwoFactorEnabled = false,
                            UserName = "1"
                        },
                        new
                        {
                            Id = "ea56599d-3d59-46ac-b1bc-f8fdd74c68c7",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "2d4928aa-f3f4-488b-be9a-4366a88e8a1d",
                            EmailConfirmed = false,
                            FirstName = "Иван",
                            LastName = "Валерьевич",
                            LockoutEnabled = false,
                            MiddleName = "Кулаков",
                            NormalizedUserName = "user1",
                            PasswordHash = "AQAAAAIAAYagAAAAEBBhlg+oANgcKwhlnKvLxg8DnzFMAAOSXoyFDfKXLqXu+9lGckTiVcP+PSR4LyxAOw==",
                            PhoneNumberConfirmed = false,
                            Position = 3,
                            Role = 1,
                            SecurityStamp = "942e0eec-4804-4f12-9de0-7ba8fe2b324a",
                            TwoFactorEnabled = false,
                            UserName = "2"
                        },
                        new
                        {
                            Id = "3459e235-e34e-41ea-8a56-f1017e0330e3",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "5b9a0640-5ed8-4c51-9d17-7e7b398d0c4e",
                            EmailConfirmed = false,
                            FirstName = "Михаил",
                            LastName = "Аркадьевич",
                            LockoutEnabled = false,
                            MiddleName = "Киселев",
                            NormalizedUserName = "user2",
                            PasswordHash = "AQAAAAIAAYagAAAAEMHmAeTWoW87TsQnE0KJL36mDRbZ+0Iixhy9bxHcAeDbHWt+VB44FKLdJf32IlJ94A==",
                            PhoneNumberConfirmed = false,
                            Position = 4,
                            Role = 1,
                            SecurityStamp = "d5623960-55c9-4c7c-be44-0d7e5771c6b9",
                            TwoFactorEnabled = false,
                            UserName = "3"
                        },
                        new
                        {
                            Id = "803cbbc8-429b-4539-87b4-b4bb1cb84d41",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "c119d663-6c9a-40b6-bcb8-bd3e403f9598",
                            EmailConfirmed = false,
                            FirstName = "Николай",
                            LastName = "Сергеевич",
                            LockoutEnabled = false,
                            MiddleName = "Самохин",
                            NormalizedUserName = "user3",
                            PasswordHash = "AQAAAAIAAYagAAAAEIOkX1LZzYO703XEcvSiDZGPN91rDIZxyB/1eQppCN/xAHxUOWydX75NwD+OFhY5Dw==",
                            PhoneNumberConfirmed = false,
                            Position = 4,
                            Role = 1,
                            SecurityStamp = "47c8dba3-9fc4-4908-8f03-5da8a6576e6b",
                            TwoFactorEnabled = false,
                            UserName = "4"
                        },
                        new
                        {
                            Id = "7f79eb6a-4c4e-45de-9f15-5cb82723de6b",
                            AccessFailedCount = 0,
                            City = "Москва",
                            ConcurrencyStamp = "b7ba012b-94a0-4705-966a-f042e06d65a2",
                            EmailConfirmed = false,
                            FirstName = "Даниил",
                            LastName = "Андреевич",
                            LockoutEnabled = false,
                            MiddleName = "Пашинцев",
                            NormalizedUserName = "user4",
                            PasswordHash = "AQAAAAIAAYagAAAAELFZnbWw0hFUNKrQWxfksore50Lu/63iTyO7/B8f2r5tRYtkQRbbVbxFinjxD/W22g==",
                            PhoneNumberConfirmed = false,
                            Position = 3,
                            Role = 1,
                            SecurityStamp = "b36ffc85-8a54-4cc6-a219-53c6691b3576",
                            TwoFactorEnabled = false,
                            UserName = "5"
                        },
                        new
                        {
                            Id = "850b88f1-7596-4a64-97d0-12384e7068fe",
                            AccessFailedCount = 0,
                            City = "Екатеринбург",
                            ConcurrencyStamp = "cac9af24-5c9c-4c05-b677-1d7a98831fa5",
                            EmailConfirmed = false,
                            FirstName = "Андрей",
                            LastName = "Александрович",
                            LockoutEnabled = false,
                            MiddleName = "Ветлугин",
                            NormalizedUserName = "user5",
                            PasswordHash = "AQAAAAIAAYagAAAAEMt5rK3btawSy8Inaeyo7wWFmd+sHrYiqHZALzjfj7VZxKNqsxFGFKyB2+KDBvx/mw==",
                            PhoneNumberConfirmed = false,
                            Position = 2,
                            Role = 1,
                            SecurityStamp = "f9318186-ff58-48f3-bbd9-a93e8dfda0ed",
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

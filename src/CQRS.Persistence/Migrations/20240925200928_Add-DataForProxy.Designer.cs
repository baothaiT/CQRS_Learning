﻿// <auto-generated />
using System;
using CQRS.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CQRS.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240925200928_Add-DataForProxy")]
    partial class AddDataForProxy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CQRS.Domain.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Proxy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserType")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Proxy");

                    b.HasIndex("UserType");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6f35afb-aaf2-4f3e-bd80-001ce15f26cb"),
                            CreateDate = new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7018),
                            Email = "User@example.com",
                            IsDelete = false,
                            IsStatus = true,
                            Password = "UserPass",
                            Proxy = new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"),
                            UserName = "User1",
                            UserType = new Guid("1a40e727-1895-4753-a892-6ebf162068b3")
                        },
                        new
                        {
                            Id = new Guid("94ee142d-675c-4c39-a71b-5d2fa86e5080"),
                            CreateDate = new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7028),
                            Email = "User@example.com",
                            IsDelete = false,
                            IsStatus = true,
                            Password = "UserPass",
                            Proxy = new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"),
                            UserName = "User2",
                            UserType = new Guid("85510140-e0fb-4151-aaed-f178eba5270c")
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("TypeName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AccountType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a40e727-1895-4753-a892-6ebf162068b3"),
                            IsDelete = false,
                            TypeName = 0
                        },
                        new
                        {
                            Id = new Guid("85510140-e0fb-4151-aaed-f178eba5270c"),
                            IsDelete = false,
                            TypeName = 1
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Logs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("User");

                    b.ToTable("Logs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1db53132-e23b-4356-b34e-fe28acc04e03"),
                            Code = 200,
                            CreateDate = new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7051),
                            IsDelete = false,
                            Message = "Message",
                            User = new Guid("d6f35afb-aaf2-4f3e-bd80-001ce15f26cb")
                        },
                        new
                        {
                            Id = new Guid("1fef23f3-ae9f-4462-9d06-9defedd76adb"),
                            Code = 200,
                            CreateDate = new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7053),
                            IsDelete = false,
                            Message = "Message",
                            User = new Guid("94ee142d-675c-4c39-a71b-5d2fa86e5080")
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Proxy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proxy");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"),
                            Ip = "192.168.1.1",
                            IsDelete = false,
                            Password = "proxyPass1",
                            Port = 8080,
                            User = "proxyUser1"
                        },
                        new
                        {
                            Id = new Guid("f847c6a3-03a6-428c-9130-e314e3b75e06"),
                            Ip = "192.168.1.2",
                            IsDelete = false,
                            Password = "proxyPass2",
                            Port = 8080,
                            User = "proxyUser2"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Account", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.Proxy", "Account_Proxy")
                        .WithMany("Logs_Account")
                        .HasForeignKey("Proxy");

                    b.HasOne("CQRS.Domain.Entities.AccountType", "AccountType")
                        .WithMany("AccountType_Accounts")
                        .HasForeignKey("UserType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");

                    b.Navigation("Account_Proxy");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Logs", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.Account", "Logs_Account")
                        .WithMany("Logs")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Logs_Account");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Account", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountType", b =>
                {
                    b.Navigation("AccountType_Accounts");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.Proxy", b =>
                {
                    b.Navigation("Logs_Account");
                });
#pragma warning restore 612, 618
        }
    }
}

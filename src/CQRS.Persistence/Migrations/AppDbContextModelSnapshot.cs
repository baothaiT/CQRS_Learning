﻿// <auto-generated />
using System;
using CQRS.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CQRS.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CQRS.Domain.Entities.AccountEntity", b =>
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

                    b.Property<Guid?>("UserType")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Proxy");

                    b.HasIndex("UserType");

                    b.ToTable("AccountTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6487),
                            Email = "User@example.com",
                            IsDelete = false,
                            IsStatus = true,
                            Password = "UserPass",
                            Proxy = new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"),
                            UserName = "User1",
                            UserType = new Guid("1e96c5a0-1524-4269-8c22-bcd4cc38c19f")
                        },
                        new
                        {
                            Id = new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6652),
                            Email = "User@example.com",
                            IsDelete = false,
                            IsStatus = true,
                            Password = "UserPass",
                            Proxy = new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"),
                            UserName = "User2",
                            UserType = new Guid("aa9e0449-1ba7-4551-b141-bc766096620c")
                        },
                        new
                        {
                            Id = new Guid("81dc9483-9d3c-49e1-9557-4b5a85d5497d"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6654),
                            Email = "User@example.com",
                            IsDelete = false,
                            IsStatus = true,
                            Password = "UserPass",
                            UserName = "User3",
                            UserType = new Guid("aa9e0449-1ba7-4551-b141-bc766096620c")
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("TypeName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AccountTypeTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e96c5a0-1524-4269-8c22-bcd4cc38c19f"),
                            IsDelete = false,
                            TypeName = 0
                        },
                        new
                        {
                            Id = new Guid("aa9e0449-1ba7-4551-b141-bc766096620c"),
                            IsDelete = false,
                            TypeName = 1
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInBrowserEntity", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrowserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("AccountId", "BrowserId");

                    b.HasIndex("BrowserId");

                    b.ToTable("AccountsInBrowserTable");

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"),
                            BrowserId = new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2"),
                            IsDelete = false
                        },
                        new
                        {
                            AccountId = new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"),
                            BrowserId = new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a"),
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInProjectEntity", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("AccountId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("AccountsInProjectTable");

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"),
                            ProjectId = new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"),
                            IsDelete = false
                        },
                        new
                        {
                            AccountId = new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"),
                            ProjectId = new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"),
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.BrowserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("HightScreen")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Scale")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("WithScreeen")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("XPosition")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("YPosition")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("BrowserTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6734),
                            HightScreen = 600m,
                            IsDelete = false,
                            IsStatus = false,
                            Name = "Name1",
                            Path = "Path",
                            Scale = 50m,
                            UserAgent = "",
                            WithScreeen = 400m,
                            XPosition = 160m,
                            YPosition = 50m
                        },
                        new
                        {
                            Id = new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6743),
                            HightScreen = 600m,
                            IsDelete = false,
                            IsStatus = false,
                            Name = "Name2",
                            Path = "Path",
                            Scale = 50m,
                            UserAgent = "",
                            WithScreeen = 400m,
                            XPosition = 160m,
                            YPosition = 50m
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.DevicesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("IsStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DevicesTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dff63ac0-810a-49a6-80bb-085986df2517"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(7004),
                            IsDelete = false,
                            IsStatus = 0,
                            Name = "Name1"
                        },
                        new
                        {
                            Id = new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(7005),
                            IsDelete = false,
                            IsStatus = 0,
                            Name = "Name1"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.LogsEntity", b =>
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

                    b.ToTable("LogsTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("938343d9-2e8d-4b8b-8274-27e2aa6c9452"),
                            Code = 200,
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6697),
                            IsDelete = false,
                            Message = "Message",
                            User = new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea")
                        },
                        new
                        {
                            Id = new Guid("e32d1f38-a88a-4d96-8982-e235c7d2d81b"),
                            Code = 200,
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6698),
                            IsDelete = false,
                            Message = "Message",
                            User = new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4")
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.PlanEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6930),
                            IsDelete = false,
                            Name = "Plan 1"
                        },
                        new
                        {
                            Id = new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6932),
                            IsDelete = false,
                            Name = "Plan 2"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.PlansInScheduleEntity", b =>
                {
                    b.Property<Guid>("ScheduleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("ScheduleId", "DeviceId", "PlanId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("PlanId");

                    b.ToTable("PlansInScheduleTable");

                    b.HasData(
                        new
                        {
                            ScheduleId = new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2"),
                            DeviceId = new Guid("dff63ac0-810a-49a6-80bb-085986df2517"),
                            PlanId = new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"),
                            IsDelete = false
                        },
                        new
                        {
                            ScheduleId = new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117"),
                            DeviceId = new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"),
                            PlanId = new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"),
                            IsDelete = false
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
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductsTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProjectEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProjectTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6809),
                            EndDate = new DateTime(2024, 10, 3, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6804),
                            IsDelete = false,
                            Name = "Project1",
                            StartDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6803)
                        },
                        new
                        {
                            Id = new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6812),
                            EndDate = new DateTime(2024, 10, 3, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6812),
                            IsDelete = false,
                            Name = "Project2",
                            StartDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6811)
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProxyEntity", b =>
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

                    b.ToTable("ProxyTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"),
                            Ip = "192.168.1.6",
                            IsDelete = false,
                            Password = "proxyPass1",
                            Port = 8080,
                            User = "proxyUser1"
                        },
                        new
                        {
                            Id = new Guid("36b22dd7-9f06-4343-8b40-3bbb1cd7d021"),
                            Ip = "192.168.1.7",
                            IsDelete = false,
                            Password = "proxyPass2",
                            Port = 8080,
                            User = "proxyUser2"
                        },
                        new
                        {
                            Id = new Guid("9d02baf8-5da7-4f24-8ea3-396cacbb9a0f"),
                            Ip = "192.168.1.8",
                            IsDelete = false,
                            Password = "proxyPass2",
                            Port = 8080,
                            User = "proxyUser2"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScheduleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("IsRun")
                        .HasColumnType("int");

                    b.Property<int>("IsStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScheduleTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6978),
                            DateTimeStart = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6977),
                            IsDelete = false,
                            IsRun = 0,
                            IsStatus = 0,
                            Name = "Name1"
                        },
                        new
                        {
                            Id = new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6981),
                            DateTimeStart = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6980),
                            IsDelete = false,
                            IsRun = 0,
                            IsStatus = 0,
                            Name = "Name1"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScriptTable");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6870),
                            IsDelete = false,
                            Name = "Script 1"
                        },
                        new
                        {
                            Id = new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"),
                            CreateDate = new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6871),
                            IsDelete = false,
                            Name = "Script 2"
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInPlanEntity", b =>
                {
                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ScriptsInPlan_PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ScriptsInPlan_ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlanId", "ScriptId");

                    b.HasIndex("ScriptsInPlan_PlanId");

                    b.HasIndex("ScriptsInPlan_ScriptId");

                    b.ToTable("ScriptsInPlanTable");

                    b.HasData(
                        new
                        {
                            PlanId = new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"),
                            ScriptId = new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"),
                            IsDelete = false
                        },
                        new
                        {
                            PlanId = new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"),
                            ScriptId = new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"),
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInProjectEntity", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId", "ScriptId");

                    b.HasIndex("ScriptId");

                    b.ToTable("ScriptsInProjectTable");

                    b.HasData(
                        new
                        {
                            ProjectId = new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"),
                            ScriptId = new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"),
                            IsDelete = false
                        },
                        new
                        {
                            ProjectId = new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"),
                            ScriptId = new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"),
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.ProxyEntity", "Account_Proxy")
                        .WithMany("Logs_Account")
                        .HasForeignKey("Proxy");

                    b.HasOne("CQRS.Domain.Entities.AccountTypeEntity", "AccountType")
                        .WithMany("AccountType_Accounts")
                        .HasForeignKey("UserType");

                    b.Navigation("AccountType");

                    b.Navigation("Account_Proxy");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInBrowserEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.AccountEntity", "AccountsInBrowser_Account")
                        .WithMany("Account_AccountsInBrowser")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CQRS.Domain.Entities.BrowserEntity", "AccountsInBrowser_Browser")
                        .WithMany("Browser_AccountsInBrowser")
                        .HasForeignKey("BrowserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountsInBrowser_Account");

                    b.Navigation("AccountsInBrowser_Browser");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInProjectEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.AccountEntity", "AccountsInProject_Account")
                        .WithMany("Account_AccountsInProject")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CQRS.Domain.Entities.ProjectEntity", "AccountsInProject_Project")
                        .WithMany("AccountsInProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountsInProject_Account");

                    b.Navigation("AccountsInProject_Project");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.LogsEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.AccountEntity", "Logs_Account")
                        .WithMany("Logs")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Logs_Account");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.PlansInScheduleEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.DevicesEntity", "PlansInSchedule_Device")
                        .WithMany("PlansInSchedules")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CQRS.Domain.Entities.PlanEntity", "PlansInSchedule_Plan")
                        .WithMany("PlansInSchedule")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CQRS.Domain.Entities.ScheduleEntity", "PlansInSchedule_Schedule")
                        .WithMany("PlansInSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlansInSchedule_Device");

                    b.Navigation("PlansInSchedule_Plan");

                    b.Navigation("PlansInSchedule_Schedule");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInPlanEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.PlanEntity", "ScriptsInPlan_Plan")
                        .WithMany("ScriptsInPlans")
                        .HasForeignKey("ScriptsInPlan_PlanId");

                    b.HasOne("CQRS.Domain.Entities.ScriptEntity", "ScriptsInPlan_Script")
                        .WithMany()
                        .HasForeignKey("ScriptsInPlan_ScriptId");

                    b.Navigation("ScriptsInPlan_Plan");

                    b.Navigation("ScriptsInPlan_Script");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInProjectEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.ProjectEntity", "ScriptsInProject_Project")
                        .WithMany("ScriptsInProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CQRS.Domain.Entities.ScriptEntity", "ScriptsInProject_Script")
                        .WithMany("ScriptsInProjects")
                        .HasForeignKey("ScriptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScriptsInProject_Project");

                    b.Navigation("ScriptsInProject_Script");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountEntity", b =>
                {
                    b.Navigation("Account_AccountsInBrowser");

                    b.Navigation("Account_AccountsInProject");

                    b.Navigation("Logs");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountTypeEntity", b =>
                {
                    b.Navigation("AccountType_Accounts");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.BrowserEntity", b =>
                {
                    b.Navigation("Browser_AccountsInBrowser");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.DevicesEntity", b =>
                {
                    b.Navigation("PlansInSchedules");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.PlanEntity", b =>
                {
                    b.Navigation("PlansInSchedule");

                    b.Navigation("ScriptsInPlans");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProjectEntity", b =>
                {
                    b.Navigation("AccountsInProject");

                    b.Navigation("ScriptsInProjects");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProxyEntity", b =>
                {
                    b.Navigation("Logs_Account");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScheduleEntity", b =>
                {
                    b.Navigation("PlansInSchedules");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptEntity", b =>
                {
                    b.Navigation("ScriptsInProjects");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CQRS.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CQRS.API.Migrations
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

                    b.Property<bool?>("IsMigration")
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
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<int>("TypeName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AccountTypeTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInBrowserEntity", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrowserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.HasKey("AccountId", "BrowserId");

                    b.HasIndex("BrowserId");

                    b.ToTable("AccountsInBrowserTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountsInProjectEntity", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.HasKey("AccountId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("AccountsInProjectTable");
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

                    b.Property<bool?>("IsMigration")
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<int>("IsStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DevicesTable");
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("User");

                    b.ToTable("LogsTable");
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlanTable");
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.HasKey("ScheduleId", "DeviceId", "PlanId");

                    b.HasIndex("DeviceId");

                    b.HasIndex("PlanId");

                    b.ToTable("PlansInScheduleTable");
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProjectTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ProxyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CheckLiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<int?>("IsStatus")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProxyTable");
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

                    b.Property<bool?>("IsMigration")
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

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ScriptTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInPlanEntity", b =>
                {
                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ScriptsInPlan_PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ScriptsInPlan_ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlanId", "ScriptId");

                    b.HasIndex("ScriptsInPlan_PlanId");

                    b.HasIndex("ScriptsInPlan_ScriptId");

                    b.ToTable("ScriptsInPlanTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.ScriptsInProjectEntity", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScriptId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsMigration")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId", "ScriptId");

                    b.HasIndex("ScriptId");

                    b.ToTable("ScriptsInProjectTable");
                });

            modelBuilder.Entity("CQRS.Domain.Entities.AccountEntity", b =>
                {
                    b.HasOne("CQRS.Domain.Entities.ProxyEntity", "Account_Proxy")
                        .WithMany("Proxy_Account")
                        .HasForeignKey("Proxy")
                        .OnDelete(DeleteBehavior.SetNull);

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
                    b.Navigation("Proxy_Account");
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

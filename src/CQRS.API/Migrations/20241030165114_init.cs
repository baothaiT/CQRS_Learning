using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypeTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypeTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrowserTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    XPosition = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    YPosition = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    WithScreeen = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    HightScreen = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    Scale = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrowserTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevicesTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProxyTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckLiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProxyTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRun = table.Column<int>(type: "int", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScriptTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proxy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserType = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountTable_AccountTypeTable_UserType",
                        column: x => x.UserType,
                        principalTable: "AccountTypeTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AccountTable_ProxyTable_Proxy",
                        column: x => x.Proxy,
                        principalTable: "ProxyTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PlansInScheduleTable",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansInScheduleTable", x => new { x.ScheduleId, x.DeviceId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_PlansInScheduleTable_DevicesTable_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "DevicesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInScheduleTable_PlanTable_PlanId",
                        column: x => x.PlanId,
                        principalTable: "PlanTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInScheduleTable_ScheduleTable_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "ScheduleTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInPlanTable",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptsInPlan_PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ScriptsInPlan_ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInPlanTable", x => new { x.PlanId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInPlanTable_PlanTable_ScriptsInPlan_PlanId",
                        column: x => x.ScriptsInPlan_PlanId,
                        principalTable: "PlanTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScriptsInPlanTable_ScriptTable_ScriptsInPlan_ScriptId",
                        column: x => x.ScriptsInPlan_ScriptId,
                        principalTable: "ScriptTable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInProjectTable",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInProjectTable", x => new { x.ProjectId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInProjectTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScriptsInProjectTable_ScriptTable_ScriptId",
                        column: x => x.ScriptId,
                        principalTable: "ScriptTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountsInBrowserTable",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrowserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsInBrowserTable", x => new { x.AccountId, x.BrowserId });
                    table.ForeignKey(
                        name: "FK_AccountsInBrowserTable_AccountTable_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsInBrowserTable_BrowserTable_BrowserId",
                        column: x => x.BrowserId,
                        principalTable: "BrowserTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountsInProjectTable",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsInProjectTable", x => new { x.AccountId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_AccountsInProjectTable_AccountTable_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsInProjectTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogsTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsMigration = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogsTable_AccountTable_User",
                        column: x => x.User,
                        principalTable: "AccountTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("2f7a710e-9dfd-4483-bf1e-a555c43da3dd"), false, true, 0 },
                    { new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("0264bd72-fc09-4758-8216-c5948751826e"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2451), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2464), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2700), false, true, 0, "Name1" },
                    { new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2698), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2624), false, true, "Plan 2" },
                    { new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2622), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 11, 4, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2513), false, true, "Project1", new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2513) },
                    { new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 11, 4, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2521), false, true, "Project2", new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2521) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("112ec4af-b26f-4cdc-8953-2f5ff466b9c9"), null, null, "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), null, null, "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" },
                    { new Guid("75bd90cb-add8-4b72-8d95-738edaa85d90"), null, null, "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2674), false, true, 0, 0, "Name1" },
                    { new Guid("d607cf84-46c1-459c-9bf9-969669e14714"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2677), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2575), false, true, "Script 1" },
                    { new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2577), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), false, true, null, null },
                    { new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2363), "User@example.com", false, true, true, "UserPass", new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), "User1", new Guid("2f7a710e-9dfd-4483-bf1e-a555c43da3dd") },
                    { new Guid("7a98ead2-e62a-4552-96f4-d31a9f668a8b"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2383), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6") },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2381), "User@example.com", false, true, true, "UserPass", new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), "User2", new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"), new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982"), false, true },
                    { new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"), new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("d607cf84-46c1-459c-9bf9-969669e14714"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), false, true },
                    { new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("0264bd72-fc09-4758-8216-c5948751826e"), false, true },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), false, true },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2cb5373f-6566-49b3-858a-c19ef9f8f0f5"), 200, new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2416), false, true, "Message", new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689") },
                    { new Guid("72aae3a6-d1fc-435d-8ca1-cbea0502fd0f"), 200, new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2414), false, true, "Message", new Guid("04aab300-11f3-4172-bada-9948a88d5722") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInBrowserTable_BrowserId",
                table: "AccountsInBrowserTable",
                column: "BrowserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInProjectTable_ProjectId",
                table: "AccountsInProjectTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTable_Proxy",
                table: "AccountTable",
                column: "Proxy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTable_UserType",
                table: "AccountTable",
                column: "UserType");

            migrationBuilder.CreateIndex(
                name: "IX_LogsTable_User",
                table: "LogsTable",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_PlansInScheduleTable_DeviceId",
                table: "PlansInScheduleTable",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlansInScheduleTable_PlanId",
                table: "PlansInScheduleTable",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInPlanTable_ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInPlanTable_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_ScriptId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInProjectTable_ScriptId",
                table: "ScriptsInProjectTable",
                column: "ScriptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsInBrowserTable");

            migrationBuilder.DropTable(
                name: "AccountsInProjectTable");

            migrationBuilder.DropTable(
                name: "LogsTable");

            migrationBuilder.DropTable(
                name: "PlansInScheduleTable");

            migrationBuilder.DropTable(
                name: "ProductsTable");

            migrationBuilder.DropTable(
                name: "ScriptsInPlanTable");

            migrationBuilder.DropTable(
                name: "ScriptsInProjectTable");

            migrationBuilder.DropTable(
                name: "BrowserTable");

            migrationBuilder.DropTable(
                name: "AccountTable");

            migrationBuilder.DropTable(
                name: "DevicesTable");

            migrationBuilder.DropTable(
                name: "ScheduleTable");

            migrationBuilder.DropTable(
                name: "PlanTable");

            migrationBuilder.DropTable(
                name: "ProjectTable");

            migrationBuilder.DropTable(
                name: "ScriptTable");

            migrationBuilder.DropTable(
                name: "AccountTypeTable");

            migrationBuilder.DropTable(
                name: "ProxyTable");
        }
    }
}

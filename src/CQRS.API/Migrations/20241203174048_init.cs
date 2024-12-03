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
                name: "HistoryOrderTradingTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Symbol_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol_Suffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Side = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillAndOrderPrice_Prefix = table.Column<double>(type: "float", nullable: false),
                    FillAndOrderPrice_Suffix = table.Column<double>(type: "float", nullable: false),
                    FilledAndTotal_Prefix_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Prefix_Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Suffix_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Suffix_Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndOrderValue_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: false),
                    IsResovlve = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOrderTradingTable", x => x.Id);
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
                    { new Guid("5030d0f9-d60f-42cd-87a6-fc634aae082f"), false, true, 1 },
                    { new Guid("8398682b-8626-42bc-9819-baa6096c4083"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("281b2ace-6db3-4e83-9cee-8456b8157169"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8334), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("5a73a12b-cb93-4f51-ab7c-de839e3f43f3"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8326), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("d834ffe6-87fc-4e70-8d5d-1de3cb791f75"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8585), false, true, 0, "Name1" },
                    { new Guid("db35d214-83b9-412a-aa90-3ac156838dd5"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8584), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "IsResovlve", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[,]
                {
                    { new Guid("781fec36-3aec-4051-bde3-dd331498a0f7"), 0.080000000000000002, 0.38100000000000001, 0.38100000000000001, "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8644), "SELL", "DOGE", "USDT" },
                    { new Guid("c6b15d2f-559e-4dd0-9374-98565aa99ca9"), 0.080000000000000002, 0.38100000000000001, 0.38100000000000001, "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8637), "BUY", "DOGE", "USDT" },
                    { new Guid("e7b700da-edbf-41dc-a0bd-736944c4e11e"), 0.080000000000000002, 0.38100000000000001, 0.38100000000000001, "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8642), "SELL", "DOGE", "USDT" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("765198d3-e070-46d4-bf31-f7479965d6e1"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8492), false, true, "Plan 2" },
                    { new Guid("f118c9fc-d6e3-4a04-9f8b-7de8259a0c8f"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8489), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("63eb1dfa-cd70-40b2-8dbc-b077c841e0b9"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 12, 9, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8387), false, true, "Project1", new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8386) },
                    { new Guid("fa9e8849-c5c0-4b33-95df-aebcaaae3e35"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 12, 9, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8395), false, true, "Project2", new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8395) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("474b1972-b192-41a8-a429-090633c6bd53"), null, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(7991), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("691bf9d1-7812-4e11-b86a-df52b4e01ef8"), null, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(7973), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" },
                    { new Guid("fc176167-9291-447d-8b68-4c5faea2096c"), null, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(7989), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("76fb091b-a281-441e-85d0-2ddfb8bd3cdc"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8558), false, true, 0, 0, "Name1" },
                    { new Guid("d73c8cf3-e3da-451b-92d0-3c3f00554984"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8561), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("321f0b02-5829-4cb9-a0ac-e8a9cb8b0414"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8443), false, true, "Script 1" },
                    { new Guid("3a81f0ad-1a55-466d-bef9-a6e1df44ac5c"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8444), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("765198d3-e070-46d4-bf31-f7479965d6e1"), new Guid("3a81f0ad-1a55-466d-bef9-a6e1df44ac5c"), false, true, null, null },
                    { new Guid("f118c9fc-d6e3-4a04-9f8b-7de8259a0c8f"), new Guid("321f0b02-5829-4cb9-a0ac-e8a9cb8b0414"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("06f297da-2abc-4c0b-a84b-186ba6df3674"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8266), "User@example.com", false, true, true, "UserPass", new Guid("691bf9d1-7812-4e11-b86a-df52b4e01ef8"), "User1", new Guid("8398682b-8626-42bc-9819-baa6096c4083") },
                    { new Guid("7712d7bd-96ff-465d-bb19-25a7bd824b1d"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8271), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("5030d0f9-d60f-42cd-87a6-fc634aae082f") },
                    { new Guid("e32b0529-3ef6-47bd-838f-c9e81e578342"), new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8269), "User@example.com", false, true, true, "UserPass", new Guid("691bf9d1-7812-4e11-b86a-df52b4e01ef8"), "User2", new Guid("5030d0f9-d60f-42cd-87a6-fc634aae082f") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("db35d214-83b9-412a-aa90-3ac156838dd5"), new Guid("f118c9fc-d6e3-4a04-9f8b-7de8259a0c8f"), new Guid("76fb091b-a281-441e-85d0-2ddfb8bd3cdc"), false, true },
                    { new Guid("d834ffe6-87fc-4e70-8d5d-1de3cb791f75"), new Guid("765198d3-e070-46d4-bf31-f7479965d6e1"), new Guid("d73c8cf3-e3da-451b-92d0-3c3f00554984"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("63eb1dfa-cd70-40b2-8dbc-b077c841e0b9"), new Guid("321f0b02-5829-4cb9-a0ac-e8a9cb8b0414"), false, true },
                    { new Guid("fa9e8849-c5c0-4b33-95df-aebcaaae3e35"), new Guid("3a81f0ad-1a55-466d-bef9-a6e1df44ac5c"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("06f297da-2abc-4c0b-a84b-186ba6df3674"), new Guid("5a73a12b-cb93-4f51-ab7c-de839e3f43f3"), false, true },
                    { new Guid("e32b0529-3ef6-47bd-838f-c9e81e578342"), new Guid("281b2ace-6db3-4e83-9cee-8456b8157169"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("06f297da-2abc-4c0b-a84b-186ba6df3674"), new Guid("63eb1dfa-cd70-40b2-8dbc-b077c841e0b9"), false, true },
                    { new Guid("e32b0529-3ef6-47bd-838f-c9e81e578342"), new Guid("fa9e8849-c5c0-4b33-95df-aebcaaae3e35"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("483266e9-35cc-413c-b66d-21e33b23a576"), 200, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8300), false, true, "Message", new Guid("e32b0529-3ef6-47bd-838f-c9e81e578342") },
                    { new Guid("c056ada4-6602-4f4c-9b69-12a64a1bd211"), 200, new DateTime(2024, 12, 4, 0, 40, 45, 488, DateTimeKind.Local).AddTicks(8297), false, true, "Message", new Guid("06f297da-2abc-4c0b-a84b-186ba6df3674") }
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
                name: "HistoryOrderTradingTable");

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

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
                    FillAndOrderPrice_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillAndOrderPrice_Suffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("25b46b15-94a9-4a54-8302-f2a4af9a4c13"), false, true, 1 },
                    { new Guid("3e1ba1dc-4331-4412-b749-92cfb7717e7a"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("376f7d25-23c9-484c-8178-5d24b690edcd"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1814), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("5cf109ee-6071-42ef-ae0f-1972c411ad7a"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1805), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("5facf2fb-1859-4dae-b14e-65d070b4b921"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2073), false, true, 0, "Name1" },
                    { new Guid("ff64a691-885c-4d27-936c-cb0cae4b32ae"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2074), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "IsResovlve", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[,]
                {
                    { new Guid("184ead55-0b79-4697-a667-4613409c7607"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2142), "SELL", "DOGE", "USDT" },
                    { new Guid("9e0c85f5-4608-44e6-9dbc-3d8ff0a288d2"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2132), "BUY", "DOGE", "USDT" },
                    { new Guid("dc551311-3ad2-4ed4-a443-38aba6fd6be7"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2139), "SELL", "DOGE", "USDT" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("b0d89e34-cdae-4ac3-96c2-2083fbea3dcd"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2001), false, true, "Plan 2" },
                    { new Guid("e145c218-9d0b-4204-89a6-45e0f3c0d1da"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1999), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("1bdf7d56-7c5c-4c66-946a-6333e58f380d"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1881), new DateTime(2024, 12, 8, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1876), false, true, "Project1", new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1875) },
                    { new Guid("d631c471-80c5-4785-97fd-402b8bb651a6"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 12, 8, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1884), false, true, "Project2", new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1884) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("d69faa9f-a081-457d-9f12-1e69bb2497e1"), null, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1426), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" },
                    { new Guid("d79de5dd-56a1-465a-b123-b39b989c26d3"), null, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1443), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("fa1322fb-e3fa-41ea-a200-3480ef3c460f"), null, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1440), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("2318f928-098d-4296-a5cb-22f4f4fd49c4"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2049), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2049), false, true, 0, 0, "Name1" },
                    { new Guid("38a9e64c-8d6f-4618-bf91-1539a5dab06a"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(2046), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("53f89d61-fe23-489c-9348-dfa15219b9c8"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1941), false, true, "Script 2" },
                    { new Guid("f33917d8-ed83-4fdb-b67c-0652b33c4692"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1940), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("b0d89e34-cdae-4ac3-96c2-2083fbea3dcd"), new Guid("53f89d61-fe23-489c-9348-dfa15219b9c8"), false, true, null, null },
                    { new Guid("e145c218-9d0b-4204-89a6-45e0f3c0d1da"), new Guid("f33917d8-ed83-4fdb-b67c-0652b33c4692"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("497ed262-5451-4157-a72b-cd04ac0d0c09"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1729), "User@example.com", false, true, true, "UserPass", new Guid("d69faa9f-a081-457d-9f12-1e69bb2497e1"), "User1", new Guid("3e1ba1dc-4331-4412-b749-92cfb7717e7a") },
                    { new Guid("d13c4377-31fb-4c77-aafd-2e197dcd0ab0"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1733), "User@example.com", false, true, true, "UserPass", new Guid("d69faa9f-a081-457d-9f12-1e69bb2497e1"), "User2", new Guid("25b46b15-94a9-4a54-8302-f2a4af9a4c13") },
                    { new Guid("f5582f31-a28e-4b17-9dd5-f4edbb69451d"), new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1735), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("25b46b15-94a9-4a54-8302-f2a4af9a4c13") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("ff64a691-885c-4d27-936c-cb0cae4b32ae"), new Guid("b0d89e34-cdae-4ac3-96c2-2083fbea3dcd"), new Guid("2318f928-098d-4296-a5cb-22f4f4fd49c4"), false, true },
                    { new Guid("5facf2fb-1859-4dae-b14e-65d070b4b921"), new Guid("e145c218-9d0b-4204-89a6-45e0f3c0d1da"), new Guid("38a9e64c-8d6f-4618-bf91-1539a5dab06a"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("1bdf7d56-7c5c-4c66-946a-6333e58f380d"), new Guid("f33917d8-ed83-4fdb-b67c-0652b33c4692"), false, true },
                    { new Guid("d631c471-80c5-4785-97fd-402b8bb651a6"), new Guid("53f89d61-fe23-489c-9348-dfa15219b9c8"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("497ed262-5451-4157-a72b-cd04ac0d0c09"), new Guid("5cf109ee-6071-42ef-ae0f-1972c411ad7a"), false, true },
                    { new Guid("d13c4377-31fb-4c77-aafd-2e197dcd0ab0"), new Guid("376f7d25-23c9-484c-8178-5d24b690edcd"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("497ed262-5451-4157-a72b-cd04ac0d0c09"), new Guid("1bdf7d56-7c5c-4c66-946a-6333e58f380d"), false, true },
                    { new Guid("d13c4377-31fb-4c77-aafd-2e197dcd0ab0"), new Guid("d631c471-80c5-4785-97fd-402b8bb651a6"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("08a2c973-eb8c-40fa-b7ec-6cf5e05a16f6"), 200, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1766), false, true, "Message", new Guid("497ed262-5451-4157-a72b-cd04ac0d0c09") },
                    { new Guid("47ea70b3-74aa-437b-893f-b5162e9ba710"), 200, new DateTime(2024, 12, 3, 19, 36, 16, 414, DateTimeKind.Local).AddTicks(1768), false, true, "Message", new Guid("d13c4377-31fb-4c77-aafd-2e197dcd0ab0") }
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

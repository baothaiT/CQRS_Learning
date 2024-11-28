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
                    { new Guid("466bc1f8-7429-4baf-874f-576d4766c29c"), false, true, 1 },
                    { new Guid("822028a6-01ec-44a0-910f-26d93b8af800"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("045d17ad-511f-4db8-b8da-727db1bd2e7b"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9723), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("8f0708f6-3d81-4e6d-a591-f2ec4864d3ea"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9730), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("542796a0-04db-4d1e-b0b0-2dee295affa6"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9950), false, true, 0, "Name1" },
                    { new Guid("7edac65f-45d2-4e2d-8c9f-20cbba253f97"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9951), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9884), false, true, "Plan 2" },
                    { new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9880), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 12, 2, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9781), false, true, "Project1", new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9780) },
                    { new Guid("f258e918-3d26-4f70-a579-2e51d75cc294"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9790), new DateTime(2024, 12, 2, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9790), false, true, "Project2", new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9789) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("4094d064-b6e5-4cfc-b421-eabd53fbe660"), null, new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9445), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("66048e20-e2a8-4c98-aedb-5b119e2cfb88"), null, new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9447), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("8a31daae-add2-4c55-b2e7-19a673a4596c"), null, new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9430), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("4d1ce191-e900-41d2-ab6a-5d24e4598da1"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9925), false, true, 0, 0, "Name1" },
                    { new Guid("c8143a3e-a460-45e9-b26b-e6745ae3b577"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9928), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("8f362753-2911-424f-97bd-08a63ac73d7e"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9837), false, true, "Script 2" },
                    { new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9836), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"), new Guid("8f362753-2911-424f-97bd-08a63ac73d7e"), false, true, null, null },
                    { new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"), new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9666), "User@example.com", false, true, true, "UserPass", new Guid("8a31daae-add2-4c55-b2e7-19a673a4596c"), "User1", new Guid("822028a6-01ec-44a0-910f-26d93b8af800") },
                    { new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9669), "User@example.com", false, true, true, "UserPass", new Guid("8a31daae-add2-4c55-b2e7-19a673a4596c"), "User2", new Guid("466bc1f8-7429-4baf-874f-576d4766c29c") },
                    { new Guid("528ac774-b797-4b36-8dd9-459ba1d968f2"), new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9672), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("466bc1f8-7429-4baf-874f-576d4766c29c") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("542796a0-04db-4d1e-b0b0-2dee295affa6"), new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"), new Guid("4d1ce191-e900-41d2-ab6a-5d24e4598da1"), false, true },
                    { new Guid("7edac65f-45d2-4e2d-8c9f-20cbba253f97"), new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"), new Guid("c8143a3e-a460-45e9-b26b-e6745ae3b577"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163"), new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0"), false, true },
                    { new Guid("f258e918-3d26-4f70-a579-2e51d75cc294"), new Guid("8f362753-2911-424f-97bd-08a63ac73d7e"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"), new Guid("045d17ad-511f-4db8-b8da-727db1bd2e7b"), false, true },
                    { new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"), new Guid("8f0708f6-3d81-4e6d-a591-f2ec4864d3ea"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"), new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163"), false, true },
                    { new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"), new Guid("f258e918-3d26-4f70-a579-2e51d75cc294"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("cf17486f-8c05-470d-961d-448d2e288b42"), 200, new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9698), false, true, "Message", new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52") },
                    { new Guid("d32bdb7b-3496-4bf2-9e4e-f832dc3720a5"), 200, new DateTime(2024, 11, 27, 16, 50, 20, 437, DateTimeKind.Local).AddTicks(9700), false, true, "Message", new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008") }
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

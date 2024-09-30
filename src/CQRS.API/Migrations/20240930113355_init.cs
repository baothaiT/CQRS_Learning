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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("3b9499a8-1e50-48b5-bd8a-9d732b73cab4"), false, 0 },
                    { new Guid("e556e4bc-84ce-436d-b5f1-11f95e871596"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("c1c7824c-fe62-45bc-a161-aa10eb6c5bc3"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6975), 600m, false, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("ddcacb2e-d45f-45a4-9664-75d6d5443c91"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6983), 600m, false, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("6059a752-6350-443f-aabf-ecd8d4d277d5"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7193), false, 0, "Name1" },
                    { new Guid("6d1a9a05-aa35-4dc1-8f00-0f2a5f9d438a"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7192), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7128), false, "Plan 2" },
                    { new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7127), false, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 10, 5, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7038), false, "Project1", new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7037) },
                    { new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7046), new DateTime(2024, 10, 5, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7045), false, "Project2", new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7044) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "IsStatus", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("21b6cfca-6b55-4f7c-906e-91f5013d2555"), "192.168.1.7", false, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("2bc7de9e-80c0-47f7-94d5-a5a449616cdc"), "192.168.1.6", false, null, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("85978f00-7e55-4a48-9bab-41f06847cabb"), "192.168.1.8", false, null, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("5676c2a7-6ea1-4265-8637-7502b9a4de80"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7168), false, 0, 0, "Name1" },
                    { new Guid("65ab1cd3-8869-455d-90ee-1ef81257d963"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7171), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7088), false, "Script 2" },
                    { new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(7086), false, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"), new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2"), false, null, null },
                    { new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"), new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec"), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0e892c99-358f-4279-85c2-7dc99407babe"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6912), "User@example.com", false, true, "UserPass", new Guid("2bc7de9e-80c0-47f7-94d5-a5a449616cdc"), "User1", new Guid("3b9499a8-1e50-48b5-bd8a-9d732b73cab4") },
                    { new Guid("23f7e997-e479-4810-8f2a-21f6d4b61af8"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6925), "User@example.com", false, true, "UserPass", null, "User3", new Guid("e556e4bc-84ce-436d-b5f1-11f95e871596") },
                    { new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"), new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6923), "User@example.com", false, true, "UserPass", new Guid("2bc7de9e-80c0-47f7-94d5-a5a449616cdc"), "User2", new Guid("e556e4bc-84ce-436d-b5f1-11f95e871596") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("6d1a9a05-aa35-4dc1-8f00-0f2a5f9d438a"), new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"), new Guid("5676c2a7-6ea1-4265-8637-7502b9a4de80"), false },
                    { new Guid("6059a752-6350-443f-aabf-ecd8d4d277d5"), new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"), new Guid("65ab1cd3-8869-455d-90ee-1ef81257d963"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346"), new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec"), false },
                    { new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8"), new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("0e892c99-358f-4279-85c2-7dc99407babe"), new Guid("c1c7824c-fe62-45bc-a161-aa10eb6c5bc3"), false },
                    { new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"), new Guid("ddcacb2e-d45f-45a4-9664-75d6d5443c91"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("0e892c99-358f-4279-85c2-7dc99407babe"), new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346"), false },
                    { new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"), new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8"), false }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2e161e69-6479-419a-905c-4e67f113c5d7"), 200, new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6950), false, "Message", new Guid("0e892c99-358f-4279-85c2-7dc99407babe") },
                    { new Guid("5ca37569-5d9f-4773-94be-91963dfd0859"), 200, new DateTime(2024, 9, 30, 18, 33, 55, 362, DateTimeKind.Local).AddTicks(6952), false, "Message", new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6") }
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

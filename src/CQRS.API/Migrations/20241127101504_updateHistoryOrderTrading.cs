using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class updateHistoryOrderTrading : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("528ac774-b797-4b36-8dd9-459ba1d968f2"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"), new Guid("045d17ad-511f-4db8-b8da-727db1bd2e7b") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"), new Guid("8f0708f6-3d81-4e6d-a591-f2ec4864d3ea") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"), new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"), new Guid("f258e918-3d26-4f70-a579-2e51d75cc294") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("cf17486f-8c05-470d-961d-448d2e288b42"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("d32bdb7b-3496-4bf2-9e4e-f832dc3720a5"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("542796a0-04db-4d1e-b0b0-2dee295affa6"), new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"), new Guid("4d1ce191-e900-41d2-ab6a-5d24e4598da1") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("7edac65f-45d2-4e2d-8c9f-20cbba253f97"), new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"), new Guid("c8143a3e-a460-45e9-b26b-e6745ae3b577") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("4094d064-b6e5-4cfc-b421-eabd53fbe660"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("66048e20-e2a8-4c98-aedb-5b119e2cfb88"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"), new Guid("8f362753-2911-424f-97bd-08a63ac73d7e") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"), new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163"), new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("f258e918-3d26-4f70-a579-2e51d75cc294"), new Guid("8f362753-2911-424f-97bd-08a63ac73d7e") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("2ba7f908-1aa5-4f7c-a0cd-50c27366ad52"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("518a089f-e3e2-4556-9f47-cecb7abd2008"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("045d17ad-511f-4db8-b8da-727db1bd2e7b"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("8f0708f6-3d81-4e6d-a591-f2ec4864d3ea"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("542796a0-04db-4d1e-b0b0-2dee295affa6"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("7edac65f-45d2-4e2d-8c9f-20cbba253f97"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("23bdbf59-81ff-466e-a149-e07da6fb6c9f"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("36e7d914-1a46-47ee-aaa7-cfb46670f6d9"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("a28b1fe5-27e4-4d86-b041-e5dea6f32163"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("f258e918-3d26-4f70-a579-2e51d75cc294"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("4d1ce191-e900-41d2-ab6a-5d24e4598da1"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("c8143a3e-a460-45e9-b26b-e6745ae3b577"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("8f362753-2911-424f-97bd-08a63ac73d7e"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("f673ad19-42e9-4bcf-8f80-79d6b1c797a0"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("466bc1f8-7429-4baf-874f-576d4766c29c"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("822028a6-01ec-44a0-910f-26d93b8af800"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("8a31daae-add2-4c55-b2e7-19a673a4596c"));

            migrationBuilder.CreateTable(
                name: "HistoryOrderTradingTable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Symbol_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol_Suffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Side = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FillAndOrderPrice_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillAndOrderPrice_Suffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Prefix_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Prefix_Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Suffix_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndTotal_Suffix_Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilledAndOrderValue_Prefix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryOrderTradingTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("3fff9f4a-c224-4831-9ce7-c35d1c53a4d2"), false, true, 0 },
                    { new Guid("dc4c517a-5028-4f4c-a857-073924acfc86"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("367b0229-927b-48d6-9ae2-35954ab08c8d"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(834), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("74bcad97-e2ba-47eb-a3f9-35f757f7c45e"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(842), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("96be8cc1-9b0b-4c36-bd63-629875ca50e1"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1118), false, true, 0, "Name1" },
                    { new Guid("d130eb57-0601-4dd3-b4a3-a76f43e5f131"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1119), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1039), false, true, "Plan 2" },
                    { new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1038), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("7f99775f-4c03-4643-8854-aeb94930bb87"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(914), new DateTime(2024, 12, 2, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(907), false, true, "Project1", new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(906) },
                    { new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 12, 2, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(916), false, true, "Project2", new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(915) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("0010b5f3-b774-4d4f-8d19-860de1072f41"), null, new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(454), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("59925203-aa02-41cf-ba2f-47b918b7abfb"), null, new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(451), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("7c0bf6ef-7ead-475d-9c6b-e9aaa5a65c4e"), null, new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(437), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("0067204e-9198-4710-81eb-4e1becb3f81f"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1087), false, true, 0, 0, "Name1" },
                    { new Guid("291425a8-ed58-4c4b-b73a-3906c8be4759"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1091), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(1090), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("31b08688-6734-438c-8e5a-f40f98895018"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(978), false, true, "Script 1" },
                    { new Guid("56726c37-0703-451c-b2b6-63bf95158a42"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(980), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"), new Guid("56726c37-0703-451c-b2b6-63bf95158a42"), false, true, null, null },
                    { new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"), new Guid("31b08688-6734-438c-8e5a-f40f98895018"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("732d95d6-c2ad-4300-bed7-cb04671664f7"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(769), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("dc4c517a-5028-4f4c-a857-073924acfc86") },
                    { new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(766), "User@example.com", false, true, true, "UserPass", new Guid("7c0bf6ef-7ead-475d-9c6b-e9aaa5a65c4e"), "User2", new Guid("dc4c517a-5028-4f4c-a857-073924acfc86") },
                    { new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"), new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(763), "User@example.com", false, true, true, "UserPass", new Guid("7c0bf6ef-7ead-475d-9c6b-e9aaa5a65c4e"), "User1", new Guid("3fff9f4a-c224-4831-9ce7-c35d1c53a4d2") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("96be8cc1-9b0b-4c36-bd63-629875ca50e1"), new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"), new Guid("0067204e-9198-4710-81eb-4e1becb3f81f"), false, true },
                    { new Guid("d130eb57-0601-4dd3-b4a3-a76f43e5f131"), new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"), new Guid("291425a8-ed58-4c4b-b73a-3906c8be4759"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("7f99775f-4c03-4643-8854-aeb94930bb87"), new Guid("31b08688-6734-438c-8e5a-f40f98895018"), false, true },
                    { new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8"), new Guid("56726c37-0703-451c-b2b6-63bf95158a42"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"), new Guid("74bcad97-e2ba-47eb-a3f9-35f757f7c45e"), false, true },
                    { new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"), new Guid("367b0229-927b-48d6-9ae2-35954ab08c8d"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"), new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8"), false, true },
                    { new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"), new Guid("7f99775f-4c03-4643-8854-aeb94930bb87"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("b1c59d1c-75c2-4dd5-9bee-8ab1321d0974"), 200, new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(802), false, true, "Message", new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838") },
                    { new Guid("f8edd8bc-82ea-42b4-bbef-f7f96a7fd0cb"), 200, new DateTime(2024, 11, 27, 17, 15, 3, 704, DateTimeKind.Local).AddTicks(800), false, true, "Message", new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryOrderTradingTable");

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("732d95d6-c2ad-4300-bed7-cb04671664f7"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"), new Guid("74bcad97-e2ba-47eb-a3f9-35f757f7c45e") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"), new Guid("367b0229-927b-48d6-9ae2-35954ab08c8d") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"), new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"), new Guid("7f99775f-4c03-4643-8854-aeb94930bb87") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("b1c59d1c-75c2-4dd5-9bee-8ab1321d0974"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("f8edd8bc-82ea-42b4-bbef-f7f96a7fd0cb"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("96be8cc1-9b0b-4c36-bd63-629875ca50e1"), new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"), new Guid("0067204e-9198-4710-81eb-4e1becb3f81f") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("d130eb57-0601-4dd3-b4a3-a76f43e5f131"), new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"), new Guid("291425a8-ed58-4c4b-b73a-3906c8be4759") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("0010b5f3-b774-4d4f-8d19-860de1072f41"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("59925203-aa02-41cf-ba2f-47b918b7abfb"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"), new Guid("56726c37-0703-451c-b2b6-63bf95158a42") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"), new Guid("31b08688-6734-438c-8e5a-f40f98895018") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("7f99775f-4c03-4643-8854-aeb94930bb87"), new Guid("31b08688-6734-438c-8e5a-f40f98895018") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8"), new Guid("56726c37-0703-451c-b2b6-63bf95158a42") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("956b2196-c210-4c82-bc7f-954ee2a6e838"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("fcdc7633-8603-4f7d-a2b0-f562d78c5489"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("367b0229-927b-48d6-9ae2-35954ab08c8d"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("74bcad97-e2ba-47eb-a3f9-35f757f7c45e"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("96be8cc1-9b0b-4c36-bd63-629875ca50e1"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("d130eb57-0601-4dd3-b4a3-a76f43e5f131"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("6b9b2fdb-4298-434e-95f7-ea0dcc5e4c52"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("f4cd7738-28c6-4681-a0f1-99fb1a40cd90"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("7f99775f-4c03-4643-8854-aeb94930bb87"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("c2e5c723-6548-4167-a331-9ff7db64aee8"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("0067204e-9198-4710-81eb-4e1becb3f81f"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("291425a8-ed58-4c4b-b73a-3906c8be4759"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("31b08688-6734-438c-8e5a-f40f98895018"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("56726c37-0703-451c-b2b6-63bf95158a42"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("3fff9f4a-c224-4831-9ce7-c35d1c53a4d2"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("dc4c517a-5028-4f4c-a857-073924acfc86"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("7c0bf6ef-7ead-475d-9c6b-e9aaa5a65c4e"));

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
        }
    }
}

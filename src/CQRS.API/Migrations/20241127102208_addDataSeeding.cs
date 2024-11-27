using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class addDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Side",
                table: "HistoryOrderTradingTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("ecb29862-0920-44f7-a67c-5da4720d8704"), false, true, 1 },
                    { new Guid("f4153bed-571e-4d4e-b6af-5acda02908de"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("36d4f1c2-e638-4af0-99a8-666492504d30"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1877), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("924cb8f5-dc58-4fa2-9bf2-2804296120bc"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1869), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("26386a4b-17cc-438c-9423-192a54ccb737"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2153), false, true, 0, "Name1" },
                    { new Guid("aba412ea-1db5-4cc7-b860-56c60a1e8753"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2154), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[] { new Guid("e0e827d5-9a20-4dc8-bb35-693ffde5cac2"), 0.080000000000000002, "", "", "", "", "", "", "", new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2213), "BUY", "DOGE", "USDT" });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2077), false, true, "Plan 2" },
                    { new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2075), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("38fe5c17-e067-440d-b21c-afb69dba4934"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1949), new DateTime(2024, 12, 2, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1944), false, true, "Project1", new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1943) },
                    { new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 12, 2, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1952), false, true, "Project2", new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1952) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("01eec3cd-4e33-4516-a0a1-b2fe777387e0"), null, new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1465), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("0cc5314d-6fd4-407b-b0e6-de446d78cbd3"), null, new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1467), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("7b43a4a8-1caa-44dd-b0e0-4896709c968a"), null, new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1445), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("979b1230-29b1-4fc9-b005-39e58c8186ee"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2124), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2123), false, true, 0, 0, "Name1" },
                    { new Guid("fab08348-42b3-4abc-95ee-75124f1e5886"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2126), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2126), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("65016dd9-0bb7-4229-a830-e51ddde25656"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2016), false, true, "Script 2" },
                    { new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(2014), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"), new Guid("65016dd9-0bb7-4229-a830-e51ddde25656"), false, true, null, null },
                    { new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"), new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1788), "User@example.com", false, true, true, "UserPass", new Guid("7b43a4a8-1caa-44dd-b0e0-4896709c968a"), "User2", new Guid("ecb29862-0920-44f7-a67c-5da4720d8704") },
                    { new Guid("94f332db-9dc1-4fd2-9751-f3e60ae3f8d9"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1790), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("ecb29862-0920-44f7-a67c-5da4720d8704") },
                    { new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"), new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1784), "User@example.com", false, true, true, "UserPass", new Guid("7b43a4a8-1caa-44dd-b0e0-4896709c968a"), "User1", new Guid("f4153bed-571e-4d4e-b6af-5acda02908de") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("26386a4b-17cc-438c-9423-192a54ccb737"), new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"), new Guid("979b1230-29b1-4fc9-b005-39e58c8186ee"), false, true },
                    { new Guid("aba412ea-1db5-4cc7-b860-56c60a1e8753"), new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"), new Guid("fab08348-42b3-4abc-95ee-75124f1e5886"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("38fe5c17-e067-440d-b21c-afb69dba4934"), new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8"), false, true },
                    { new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f"), new Guid("65016dd9-0bb7-4229-a830-e51ddde25656"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"), new Guid("36d4f1c2-e638-4af0-99a8-666492504d30"), false, true },
                    { new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"), new Guid("924cb8f5-dc58-4fa2-9bf2-2804296120bc"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"), new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f"), false, true },
                    { new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"), new Guid("38fe5c17-e067-440d-b21c-afb69dba4934"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("13f13006-fc9c-4391-b89b-0d64fc73bb83"), 200, new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1822), false, true, "Message", new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5") },
                    { new Guid("295281f0-ef46-46c6-b396-18fc63b8c5b7"), 200, new DateTime(2024, 11, 27, 17, 22, 7, 980, DateTimeKind.Local).AddTicks(1820), false, true, "Message", new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("94f332db-9dc1-4fd2-9751-f3e60ae3f8d9"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"), new Guid("36d4f1c2-e638-4af0-99a8-666492504d30") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"), new Guid("924cb8f5-dc58-4fa2-9bf2-2804296120bc") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"), new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"), new Guid("38fe5c17-e067-440d-b21c-afb69dba4934") });

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("e0e827d5-9a20-4dc8-bb35-693ffde5cac2"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("13f13006-fc9c-4391-b89b-0d64fc73bb83"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("295281f0-ef46-46c6-b396-18fc63b8c5b7"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("26386a4b-17cc-438c-9423-192a54ccb737"), new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"), new Guid("979b1230-29b1-4fc9-b005-39e58c8186ee") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("aba412ea-1db5-4cc7-b860-56c60a1e8753"), new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"), new Guid("fab08348-42b3-4abc-95ee-75124f1e5886") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("01eec3cd-4e33-4516-a0a1-b2fe777387e0"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("0cc5314d-6fd4-407b-b0e6-de446d78cbd3"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"), new Guid("65016dd9-0bb7-4229-a830-e51ddde25656") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"), new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("38fe5c17-e067-440d-b21c-afb69dba4934"), new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f"), new Guid("65016dd9-0bb7-4229-a830-e51ddde25656") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("8ff5630e-530b-4c38-9998-4c96ce46b9f5"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("d0cc74c9-061c-4480-a2b1-672daedd5b82"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("36d4f1c2-e638-4af0-99a8-666492504d30"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("924cb8f5-dc58-4fa2-9bf2-2804296120bc"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("26386a4b-17cc-438c-9423-192a54ccb737"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("aba412ea-1db5-4cc7-b860-56c60a1e8753"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("4be7a30a-649f-4a1b-b3df-8c46fe1f58b4"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("7830dcd6-8adc-48e1-b3c9-f7956fcd98b1"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("38fe5c17-e067-440d-b21c-afb69dba4934"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("6f7a5a6f-5016-4736-a61d-d96a5009532f"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("979b1230-29b1-4fc9-b005-39e58c8186ee"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("fab08348-42b3-4abc-95ee-75124f1e5886"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("65016dd9-0bb7-4229-a830-e51ddde25656"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("6a7c467e-a9b4-43a2-b3a4-ca81f9a4ece8"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("ecb29862-0920-44f7-a67c-5da4720d8704"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("f4153bed-571e-4d4e-b6af-5acda02908de"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("7b43a4a8-1caa-44dd-b0e0-4896709c968a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Side",
                table: "HistoryOrderTradingTable",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}

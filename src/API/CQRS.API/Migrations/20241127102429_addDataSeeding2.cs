using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class addDataSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("46b0f3b5-78bf-4a9d-9c61-629cac4da7d5"), false, true, 1 },
                    { new Guid("ebf2e26d-84c5-48ed-b411-726fbe48852d"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("72f96229-45dc-4e9b-acce-539cb685965d"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8435), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("88d82e7c-8651-491b-8f76-c471778709dd"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8443), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("b72c296d-e650-45b0-9074-fa60077bd713"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8683), false, true, 0, "Name1" },
                    { new Guid("cffc3a82-b8f8-42a1-871c-dcb888ce9fcb"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8685), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[] { new Guid("6df98115-81c6-43d1-b26c-850a616975aa"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8741), "BUY", "DOGE", "USDT" });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8599), false, true, "Plan 1" },
                    { new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8601), false, true, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 12, 2, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8494), false, true, "Project1", new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8493) },
                    { new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 12, 2, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8502), false, true, "Project2", new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8501) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("5fa81840-6d45-4fbc-8333-b06e40cdd1bc"), null, new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8106), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("6946cf1d-880c-431b-9160-c432e7e63241"), null, new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8104), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("ad4fc108-d9ec-41af-9d7d-a126fcb4e29b"), null, new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8087), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("10993375-933f-43c2-9080-bd657178d60d"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8658), false, true, 0, 0, "Name1" },
                    { new Guid("53eda4bd-ab1f-40b0-ac55-062c7e7c00c1"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8655), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8554), false, true, "Script 2" },
                    { new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8552), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"), new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c"), false, true, null, null },
                    { new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"), new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8374), "User@example.com", false, true, true, "UserPass", new Guid("ad4fc108-d9ec-41af-9d7d-a126fcb4e29b"), "User2", new Guid("46b0f3b5-78bf-4a9d-9c61-629cac4da7d5") },
                    { new Guid("8e68d17a-adb6-4cbb-8567-17c8d3fc412c"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8376), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("46b0f3b5-78bf-4a9d-9c61-629cac4da7d5") },
                    { new Guid("b0359103-3344-4644-9352-725033b04572"), new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8371), "User@example.com", false, true, true, "UserPass", new Guid("ad4fc108-d9ec-41af-9d7d-a126fcb4e29b"), "User1", new Guid("ebf2e26d-84c5-48ed-b411-726fbe48852d") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("cffc3a82-b8f8-42a1-871c-dcb888ce9fcb"), new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"), new Guid("10993375-933f-43c2-9080-bd657178d60d"), false, true },
                    { new Guid("b72c296d-e650-45b0-9074-fa60077bd713"), new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"), new Guid("53eda4bd-ab1f-40b0-ac55-062c7e7c00c1"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4"), new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c"), false, true },
                    { new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d"), new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"), new Guid("88d82e7c-8651-491b-8f76-c471778709dd"), false, true },
                    { new Guid("b0359103-3344-4644-9352-725033b04572"), new Guid("72f96229-45dc-4e9b-acce-539cb685965d"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"), new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d"), false, true },
                    { new Guid("b0359103-3344-4644-9352-725033b04572"), new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("37c14e55-3762-4092-b563-8bb6c938b674"), 200, new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8406), false, true, "Message", new Guid("4f6a07c7-f005-4316-a976-e6cf92837867") },
                    { new Guid("7683f812-9b16-4dbd-b771-ae47a3c57e2b"), 200, new DateTime(2024, 11, 27, 17, 24, 28, 729, DateTimeKind.Local).AddTicks(8403), false, true, "Message", new Guid("b0359103-3344-4644-9352-725033b04572") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("8e68d17a-adb6-4cbb-8567-17c8d3fc412c"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"), new Guid("88d82e7c-8651-491b-8f76-c471778709dd") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("b0359103-3344-4644-9352-725033b04572"), new Guid("72f96229-45dc-4e9b-acce-539cb685965d") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"), new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("b0359103-3344-4644-9352-725033b04572"), new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4") });

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("6df98115-81c6-43d1-b26c-850a616975aa"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("37c14e55-3762-4092-b563-8bb6c938b674"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("7683f812-9b16-4dbd-b771-ae47a3c57e2b"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("cffc3a82-b8f8-42a1-871c-dcb888ce9fcb"), new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"), new Guid("10993375-933f-43c2-9080-bd657178d60d") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("b72c296d-e650-45b0-9074-fa60077bd713"), new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"), new Guid("53eda4bd-ab1f-40b0-ac55-062c7e7c00c1") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("5fa81840-6d45-4fbc-8333-b06e40cdd1bc"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("6946cf1d-880c-431b-9160-c432e7e63241"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"), new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"), new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4"), new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d"), new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("4f6a07c7-f005-4316-a976-e6cf92837867"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("b0359103-3344-4644-9352-725033b04572"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("72f96229-45dc-4e9b-acce-539cb685965d"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("88d82e7c-8651-491b-8f76-c471778709dd"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("b72c296d-e650-45b0-9074-fa60077bd713"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("cffc3a82-b8f8-42a1-871c-dcb888ce9fcb"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("da62a7d1-c9e6-4b67-ae04-50ec7c813589"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("fc64d729-6dc5-4f47-8fe4-8e02e1172147"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("0125ded7-47d5-4671-a564-d53c1aedb0c4"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("9fd30f75-a583-4882-9f4f-8b84eaade54d"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("10993375-933f-43c2-9080-bd657178d60d"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("53eda4bd-ab1f-40b0-ac55-062c7e7c00c1"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("32bff1f1-0e70-4acf-8f35-96247a6af2e0"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("cb71dfff-9629-463e-9129-efcd70ffde6c"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("46b0f3b5-78bf-4a9d-9c61-629cac4da7d5"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("ebf2e26d-84c5-48ed-b411-726fbe48852d"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("ad4fc108-d9ec-41af-9d7d-a126fcb4e29b"));

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
    }
}

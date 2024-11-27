using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class addDataSeeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1a3631fd-4671-4bd2-bf58-25e5fd09bc48"), false, true, 1 },
                    { new Guid("7dfe96bd-df00-4dc7-b407-ff4d22d5014a"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("1f1567b7-16d2-46f8-8d54-fea949356acd"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1382), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("cb67427b-1487-4065-9fd1-63f68cc11dec"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1372), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("526fbf26-3443-4d07-8fa0-f4af6e6dc8e7"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1626), false, true, 0, "Name1" },
                    { new Guid("537ba68b-731c-49fe-b45d-279f29f9e5c2"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1627), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[,]
                {
                    { new Guid("46c56e5f-121d-4beb-bd6b-fad583a8d3a5"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1689), "SELL", "DOGE", "USDT" },
                    { new Guid("4d7dfc97-274f-4111-8aa0-3c2424f0e1dc"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1686), "SELL", "DOGE", "USDT" },
                    { new Guid("bdfcec71-6d9a-47f9-af79-3fa416d49693"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1678), "BUY", "DOGE", "USDT" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1554), false, true, "Plan 2" },
                    { new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1553), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1446), new DateTime(2024, 12, 2, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1445), false, true, "Project2", new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1445) },
                    { new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 12, 2, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1438), false, true, "Project1", new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1437) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("82f052cc-256f-473b-9f9d-9fb3a78c2732"), null, new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1025), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("8e325b78-2e18-4391-81ac-8e7ff99f7f6b"), null, new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1010), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" },
                    { new Guid("c78cc8ca-2356-4209-a871-3001191ee00e"), null, new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1023), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("67d73aa0-759c-4a29-8ba4-1d22ec9957dd"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1598), false, true, 0, 0, "Name1" },
                    { new Guid("dc3165b9-2c87-4344-adb4-6efa8b0cec04"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1602), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1602), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1497), false, true, "Script 1" },
                    { new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1499), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"), new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c"), false, true, null, null },
                    { new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"), new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("18980103-b86b-4e55-a42a-ee33c0137161"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1304), "User@example.com", false, true, true, "UserPass", new Guid("8e325b78-2e18-4391-81ac-8e7ff99f7f6b"), "User2", new Guid("1a3631fd-4671-4bd2-bf58-25e5fd09bc48") },
                    { new Guid("1f4ccd47-8637-4f2e-819c-13767083a25d"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1306), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("1a3631fd-4671-4bd2-bf58-25e5fd09bc48") },
                    { new Guid("96d13728-e614-4ebf-8998-346071c72210"), new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1300), "User@example.com", false, true, true, "UserPass", new Guid("8e325b78-2e18-4391-81ac-8e7ff99f7f6b"), "User1", new Guid("7dfe96bd-df00-4dc7-b407-ff4d22d5014a") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("526fbf26-3443-4d07-8fa0-f4af6e6dc8e7"), new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"), new Guid("67d73aa0-759c-4a29-8ba4-1d22ec9957dd"), false, true },
                    { new Guid("537ba68b-731c-49fe-b45d-279f29f9e5c2"), new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"), new Guid("dc3165b9-2c87-4344-adb4-6efa8b0cec04"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d"), new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c"), false, true },
                    { new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5"), new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("18980103-b86b-4e55-a42a-ee33c0137161"), new Guid("1f1567b7-16d2-46f8-8d54-fea949356acd"), false, true },
                    { new Guid("96d13728-e614-4ebf-8998-346071c72210"), new Guid("cb67427b-1487-4065-9fd1-63f68cc11dec"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("18980103-b86b-4e55-a42a-ee33c0137161"), new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d"), false, true },
                    { new Guid("96d13728-e614-4ebf-8998-346071c72210"), new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("1dc7a428-c0b1-42e4-875a-b2bff16ea2d7"), 200, new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1342), false, true, "Message", new Guid("18980103-b86b-4e55-a42a-ee33c0137161") },
                    { new Guid("70b96037-2150-429e-8a4e-eb4f3e168ba8"), 200, new DateTime(2024, 11, 27, 17, 26, 2, 402, DateTimeKind.Local).AddTicks(1338), false, true, "Message", new Guid("96d13728-e614-4ebf-8998-346071c72210") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("1f4ccd47-8637-4f2e-819c-13767083a25d"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("18980103-b86b-4e55-a42a-ee33c0137161"), new Guid("1f1567b7-16d2-46f8-8d54-fea949356acd") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("96d13728-e614-4ebf-8998-346071c72210"), new Guid("cb67427b-1487-4065-9fd1-63f68cc11dec") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("18980103-b86b-4e55-a42a-ee33c0137161"), new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("96d13728-e614-4ebf-8998-346071c72210"), new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5") });

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("46c56e5f-121d-4beb-bd6b-fad583a8d3a5"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("4d7dfc97-274f-4111-8aa0-3c2424f0e1dc"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("bdfcec71-6d9a-47f9-af79-3fa416d49693"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("1dc7a428-c0b1-42e4-875a-b2bff16ea2d7"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("70b96037-2150-429e-8a4e-eb4f3e168ba8"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("526fbf26-3443-4d07-8fa0-f4af6e6dc8e7"), new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"), new Guid("67d73aa0-759c-4a29-8ba4-1d22ec9957dd") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("537ba68b-731c-49fe-b45d-279f29f9e5c2"), new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"), new Guid("dc3165b9-2c87-4344-adb4-6efa8b0cec04") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("82f052cc-256f-473b-9f9d-9fb3a78c2732"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("c78cc8ca-2356-4209-a871-3001191ee00e"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"), new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"), new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d"), new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5"), new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("18980103-b86b-4e55-a42a-ee33c0137161"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("96d13728-e614-4ebf-8998-346071c72210"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("1f1567b7-16d2-46f8-8d54-fea949356acd"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("cb67427b-1487-4065-9fd1-63f68cc11dec"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("526fbf26-3443-4d07-8fa0-f4af6e6dc8e7"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("537ba68b-731c-49fe-b45d-279f29f9e5c2"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("b6e2fd35-d3ca-46e4-9b1e-ee07a80560fe"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("fdee3a5b-fe7f-4f27-9d2c-16d1649ac9e3"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("3da46593-bf64-408d-ab5f-852efbd7da3d"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("874c2b98-e792-4ff2-93bd-54c4684c5ad5"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("67d73aa0-759c-4a29-8ba4-1d22ec9957dd"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("dc3165b9-2c87-4344-adb4-6efa8b0cec04"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("d60b3154-6cb9-4a36-bf05-d0c833252b98"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("f0ac1b38-be3f-41ac-a5a0-f40a7129b88c"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("1a3631fd-4671-4bd2-bf58-25e5fd09bc48"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("7dfe96bd-df00-4dc7-b407-ff4d22d5014a"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("8e325b78-2e18-4391-81ac-8e7ff99f7f6b"));

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class isResolveCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsResovlve",
                table: "HistoryOrderTradingTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("34d85621-81cb-4428-8ca7-c4c1daeb4eea"), false, true, 0 },
                    { new Guid("c82b2137-f55c-47ea-88f0-1cdc4c463a3f"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("d632d62e-e575-419c-9533-c4aad556db97"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9282), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("e3a3aca2-9aee-4198-a462-e638a30f4ae4"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9290), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("d00c20ec-e986-47aa-9fe9-ae04124d76d0"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9574), false, true, 0, "Name1" },
                    { new Guid("d51ccf6f-1434-4e5f-8991-05fcdf28fafd"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9572), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "IsResovlve", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[,]
                {
                    { new Guid("7d2dd1af-9151-44fc-aeff-d9063f9ab377"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", false, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9633), "BUY", "DOGE", "USDT" },
                    { new Guid("95f6587e-a668-46e6-a220-0a4f141ae403"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", false, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9641), "SELL", "DOGE", "USDT" },
                    { new Guid("ca6d42f5-b031-41bd-b50e-ad86ff744128"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", false, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9638), "SELL", "DOGE", "USDT" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9489), false, true, "Plan 1" },
                    { new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9491), false, true, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 12, 3, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9366), false, true, "Project2", new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9365) },
                    { new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9359), new DateTime(2024, 12, 3, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9352), false, true, "Project1", new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9351) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("bcf5d0a6-a568-424b-8552-dd835cd5309e"), null, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(8898), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("c242eac5-4e00-4342-ad61-8f45a1ba74b7"), null, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(8900), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("cf6cca11-8042-4509-8831-9b7e36c0b9c9"), null, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(8881), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("b40ebb43-302c-402d-98ff-e71185743391"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9543), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9542), false, true, 0, 0, "Name1" },
                    { new Guid("b901030c-1f0c-4e40-9f35-d51fd2c9c170"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9541), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9539), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("04921956-1120-454b-ba62-839daf24dc32"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9435), false, true, "Script 2" },
                    { new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9432), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"), new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23"), false, true, null, null },
                    { new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"), new Guid("04921956-1120-454b-ba62-839daf24dc32"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9210), "User@example.com", false, true, true, "UserPass", new Guid("cf6cca11-8042-4509-8831-9b7e36c0b9c9"), "User2", new Guid("c82b2137-f55c-47ea-88f0-1cdc4c463a3f") },
                    { new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9205), "User@example.com", false, true, true, "UserPass", new Guid("cf6cca11-8042-4509-8831-9b7e36c0b9c9"), "User1", new Guid("34d85621-81cb-4428-8ca7-c4c1daeb4eea") },
                    { new Guid("edbee17f-410b-4c48-b268-05348862b719"), new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9212), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("c82b2137-f55c-47ea-88f0-1cdc4c463a3f") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("d00c20ec-e986-47aa-9fe9-ae04124d76d0"), new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"), new Guid("b40ebb43-302c-402d-98ff-e71185743391"), false, true },
                    { new Guid("d51ccf6f-1434-4e5f-8991-05fcdf28fafd"), new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"), new Guid("b901030c-1f0c-4e40-9f35-d51fd2c9c170"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e"), new Guid("04921956-1120-454b-ba62-839daf24dc32"), false, true },
                    { new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b"), new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"), new Guid("e3a3aca2-9aee-4198-a462-e638a30f4ae4"), false, true },
                    { new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"), new Guid("d632d62e-e575-419c-9533-c4aad556db97"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"), new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e"), false, true },
                    { new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"), new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("a4abba82-59e0-42b0-9303-bf3d30038c80"), 200, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9251), false, true, "Message", new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed") },
                    { new Guid("aca5d584-97f6-4a09-a220-df42c2f0b3be"), 200, new DateTime(2024, 11, 28, 0, 19, 12, 591, DateTimeKind.Local).AddTicks(9248), false, true, "Message", new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("edbee17f-410b-4c48-b268-05348862b719"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"), new Guid("e3a3aca2-9aee-4198-a462-e638a30f4ae4") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"), new Guid("d632d62e-e575-419c-9533-c4aad556db97") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"), new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"), new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b") });

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("7d2dd1af-9151-44fc-aeff-d9063f9ab377"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("95f6587e-a668-46e6-a220-0a4f141ae403"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("ca6d42f5-b031-41bd-b50e-ad86ff744128"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("a4abba82-59e0-42b0-9303-bf3d30038c80"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("aca5d584-97f6-4a09-a220-df42c2f0b3be"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("d00c20ec-e986-47aa-9fe9-ae04124d76d0"), new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"), new Guid("b40ebb43-302c-402d-98ff-e71185743391") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("d51ccf6f-1434-4e5f-8991-05fcdf28fafd"), new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"), new Guid("b901030c-1f0c-4e40-9f35-d51fd2c9c170") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("bcf5d0a6-a568-424b-8552-dd835cd5309e"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("c242eac5-4e00-4342-ad61-8f45a1ba74b7"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"), new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"), new Guid("04921956-1120-454b-ba62-839daf24dc32") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e"), new Guid("04921956-1120-454b-ba62-839daf24dc32") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b"), new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("2db96ebc-1324-433b-85fb-cd39ef2b46ed"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("8d4faaa3-e0e6-4a7d-b695-cf8d2d7c5884"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("d632d62e-e575-419c-9533-c4aad556db97"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("e3a3aca2-9aee-4198-a462-e638a30f4ae4"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("d00c20ec-e986-47aa-9fe9-ae04124d76d0"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("d51ccf6f-1434-4e5f-8991-05fcdf28fafd"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("138589fd-4044-4ac7-acbe-42c9166d70c8"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("71c8702b-574a-48bd-979d-1861ca0ee784"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("1b68a457-1e2d-4a46-b6e5-abf15df5ab2e"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("d7bee786-dd7e-40d3-a733-93bbe07a8e9b"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("b40ebb43-302c-402d-98ff-e71185743391"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("b901030c-1f0c-4e40-9f35-d51fd2c9c170"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("04921956-1120-454b-ba62-839daf24dc32"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("906c1a4c-8289-4745-b00b-d5952d57fe23"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("34d85621-81cb-4428-8ca7-c4c1daeb4eea"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("c82b2137-f55c-47ea-88f0-1cdc4c463a3f"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("cf6cca11-8042-4509-8831-9b7e36c0b9c9"));

            migrationBuilder.DropColumn(
                name: "IsResovlve",
                table: "HistoryOrderTradingTable");

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
    }
}

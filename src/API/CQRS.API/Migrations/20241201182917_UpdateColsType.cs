using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColsType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "IsResovlve",
                table: "HistoryOrderTradingTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("77c3f7f3-d044-495f-9361-114252aeccec"), false, true, 0 },
                    { new Guid("d634feec-38a9-405c-9c7a-f16c79189354"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("62a20988-6d2f-43be-a842-a0465ca31335"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3762), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("beaa2bf5-9277-4a10-b376-916ee83e09be"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3754), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("266de0a4-1c09-400a-943b-e6bbc8319115"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3988), false, true, 0, "Name1" },
                    { new Guid("f7b98922-b11b-4a18-8ced-a84621970190"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3990), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "HistoryOrderTradingTable",
                columns: new[] { "Id", "Fee", "FillAndOrderPrice_Prefix", "FillAndOrderPrice_Suffix", "FilledAndOrderValue_Prefix", "FilledAndTotal_Prefix_Symbol", "FilledAndTotal_Prefix_Value", "FilledAndTotal_Suffix_Symbol", "FilledAndTotal_Suffix_Value", "IsResovlve", "OrderTime", "Side", "Symbol_Prefix", "Symbol_Suffix" },
                values: new object[,]
                {
                    { new Guid("33669ec9-5596-4395-b311-d7280a3101c1"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(4047), "SELL", "DOGE", "USDT" },
                    { new Guid("5b840cfa-98fe-42a3-806d-87ff7f2e7e2c"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(4044), "SELL", "DOGE", "USDT" },
                    { new Guid("bb153ba7-28c4-436b-9c98-7be936e3884a"), 0.080000000000000002, "0.381", "0.381", "15.25", "DOGE", "40", "DOGE", "40", 0, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(4040), "BUY", "DOGE", "USDT" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3914), false, true, "Plan 2" },
                    { new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3913), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 12, 7, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3813), false, true, "Project1", new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3811) },
                    { new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 12, 7, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3820), false, true, "Project2", new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3820) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("2b453063-6253-4973-927e-b9ab11a56c9e"), null, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3415), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("4f3d0415-cd4f-4c9b-a95c-db3a3d775308"), null, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3413), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("aafbb842-9140-418a-84a1-00033ef3ccb1"), null, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3397), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("3fad85d1-5751-4987-94a3-0a3bc6b36309"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3964), false, true, 0, 0, "Name1" },
                    { new Guid("e5ae9307-1b84-4e08-bf3f-9aef1001680c"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3961), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("6592ced5-8e9c-479c-af75-03677111ac5c"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3865), false, true, "Script 1" },
                    { new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3867), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"), new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5"), false, true, null, null },
                    { new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"), new Guid("6592ced5-8e9c-479c-af75-03677111ac5c"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3687), "User@example.com", false, true, true, "UserPass", new Guid("aafbb842-9140-418a-84a1-00033ef3ccb1"), "User1", new Guid("77c3f7f3-d044-495f-9361-114252aeccec") },
                    { new Guid("a3ae1460-67bd-4282-895b-0e93749fbae0"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3695), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("d634feec-38a9-405c-9c7a-f16c79189354") },
                    { new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"), new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3692), "User@example.com", false, true, true, "UserPass", new Guid("aafbb842-9140-418a-84a1-00033ef3ccb1"), "User2", new Guid("d634feec-38a9-405c-9c7a-f16c79189354") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("f7b98922-b11b-4a18-8ced-a84621970190"), new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"), new Guid("3fad85d1-5751-4987-94a3-0a3bc6b36309"), false, true },
                    { new Guid("266de0a4-1c09-400a-943b-e6bbc8319115"), new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"), new Guid("e5ae9307-1b84-4e08-bf3f-9aef1001680c"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393"), new Guid("6592ced5-8e9c-479c-af75-03677111ac5c"), false, true },
                    { new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee"), new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"), new Guid("beaa2bf5-9277-4a10-b376-916ee83e09be"), false, true },
                    { new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"), new Guid("62a20988-6d2f-43be-a842-a0465ca31335"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"), new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393"), false, true },
                    { new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"), new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("8b3ea08d-d7d5-4e79-9892-8c61dc7c7c49"), 200, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3728), false, true, "Message", new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4") },
                    { new Guid("cc533c9a-5307-45c9-85f3-f8f7f27744b7"), 200, new DateTime(2024, 12, 2, 1, 29, 14, 536, DateTimeKind.Local).AddTicks(3724), false, true, "Message", new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("a3ae1460-67bd-4282-895b-0e93749fbae0"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"), new Guid("beaa2bf5-9277-4a10-b376-916ee83e09be") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"), new Guid("62a20988-6d2f-43be-a842-a0465ca31335") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"), new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"), new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee") });

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("33669ec9-5596-4395-b311-d7280a3101c1"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("5b840cfa-98fe-42a3-806d-87ff7f2e7e2c"));

            migrationBuilder.DeleteData(
                table: "HistoryOrderTradingTable",
                keyColumn: "Id",
                keyValue: new Guid("bb153ba7-28c4-436b-9c98-7be936e3884a"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("8b3ea08d-d7d5-4e79-9892-8c61dc7c7c49"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("cc533c9a-5307-45c9-85f3-f8f7f27744b7"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("f7b98922-b11b-4a18-8ced-a84621970190"), new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"), new Guid("3fad85d1-5751-4987-94a3-0a3bc6b36309") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("266de0a4-1c09-400a-943b-e6bbc8319115"), new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"), new Guid("e5ae9307-1b84-4e08-bf3f-9aef1001680c") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("2b453063-6253-4973-927e-b9ab11a56c9e"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("4f3d0415-cd4f-4c9b-a95c-db3a3d775308"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"), new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"), new Guid("6592ced5-8e9c-479c-af75-03677111ac5c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393"), new Guid("6592ced5-8e9c-479c-af75-03677111ac5c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee"), new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("404e91da-f375-47d9-9e55-5e30bfa0b4be"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("afc1113a-f7ba-4410-8832-0b08e921e0d4"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("62a20988-6d2f-43be-a842-a0465ca31335"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("beaa2bf5-9277-4a10-b376-916ee83e09be"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("266de0a4-1c09-400a-943b-e6bbc8319115"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("f7b98922-b11b-4a18-8ced-a84621970190"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("1ab4f4bc-7a64-4c17-ac0a-5af60d51d976"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("ed60eba2-5db5-4493-9af9-0e21c49737c4"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("85d9ee9a-1a5a-4fa7-b87c-3ada26ad2393"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("fcd20c13-3815-4d3a-a076-3ebc870c21ee"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("3fad85d1-5751-4987-94a3-0a3bc6b36309"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("e5ae9307-1b84-4e08-bf3f-9aef1001680c"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("6592ced5-8e9c-479c-af75-03677111ac5c"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("c38f56a6-ffc1-4768-820d-ea2b9ddc2ea5"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("77c3f7f3-d044-495f-9361-114252aeccec"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("d634feec-38a9-405c-9c7a-f16c79189354"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("aafbb842-9140-418a-84a1-00033ef3ccb1"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsResovlve",
                table: "HistoryOrderTradingTable",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}

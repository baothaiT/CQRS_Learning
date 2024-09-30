using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("e502cf30-75af-4df7-bf1f-f515b860243d"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"), new Guid("913e2b46-7325-420d-bdee-2e5c6ba8c15e") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"), new Guid("977ed311-f7c5-4ce8-aac4-9ef49f3e5f18") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"), new Guid("56d38d47-884a-4186-b9c9-8921a5108483") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"), new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("313ca6bd-f1d0-48ec-b8a3-cba018c22ef0"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("31c6a3fe-ca44-452b-b21d-5eeb9f1303d9"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("2fc317e5-9190-4efa-8577-2784c90a67b1"), new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"), new Guid("6a9a225c-e108-4c38-b844-50a13941bcb5") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("425bfaee-83b8-4f4d-a987-2541a02b838c"), new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"), new Guid("b19f768e-4ced-4bba-9e6d-30a516c5c4fb") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("5b0cf2f2-657c-4777-bda7-f42982681496"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("7419c7ae-752a-4ef7-b17e-a59f15e98be4"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"), new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"), new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("56d38d47-884a-4186-b9c9-8921a5108483"), new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012"), new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("913e2b46-7325-420d-bdee-2e5c6ba8c15e"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("977ed311-f7c5-4ce8-aac4-9ef49f3e5f18"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("2fc317e5-9190-4efa-8577-2784c90a67b1"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("425bfaee-83b8-4f4d-a987-2541a02b838c"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("56d38d47-884a-4186-b9c9-8921a5108483"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("6a9a225c-e108-4c38-b844-50a13941bcb5"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("b19f768e-4ced-4bba-9e6d-30a516c5c4fb"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("2daaf4af-dbbe-4e4b-89fe-00a39a3b13ff"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("c6ca23e0-ec47-4286-98f3-f496063a44bd"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("e5c55fda-428c-454f-972e-3b29083d5c36"));

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("dd2a5295-1d48-47c1-8b26-7991a8af7352"), false, true, 1 },
                    { new Guid("e6c37806-abe5-4d8d-b44c-a1b4d0033c18"), false, true, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("62a8331a-f81b-4571-a58c-3025e9ccfac9"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4048), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("96417f66-a853-4789-b86a-110f7d88efa6"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4042), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("c7ea3574-3879-4965-91a8-35e5ad75e5de"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4254), false, true, 0, "Name1" },
                    { new Guid("f2d3612b-e85e-4a8b-883a-cf500e121921"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4256), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4190), false, true, "Plan 1" },
                    { new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4193), false, true, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 10, 5, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4094), false, true, "Project1", new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4093) },
                    { new Guid("c7876571-c563-4700-b28d-ccdf8fccc933"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 10, 5, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4101), false, true, "Project2", new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4101) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("6a28f0b1-e914-4abf-a39e-32c57dcfa48c"), null, null, "192.168.1.6", false, true, null, "proxyPass1", 8080, null, "proxyUser1" },
                    { new Guid("9af657f4-6eaf-4b05-b39e-d073cc68d79f"), null, null, "192.168.1.8", false, true, null, "proxyPass2", 8080, null, "proxyUser2" },
                    { new Guid("d5eebb52-32e4-45d6-ae29-5530fbf036dc"), null, null, "192.168.1.7", false, true, null, "proxyPass2", 8080, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("37f73168-2747-4f00-bff4-586f9d144586"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4233), false, true, 0, 0, "Name1" },
                    { new Guid("b2457adf-0048-4439-87fa-62cbf03fbfba"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4236), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4143), false, true, "Script 1" },
                    { new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4144), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"), new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd"), false, true, null, null },
                    { new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"), new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("54770009-288e-46f2-9202-6d02be53470a"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(3971), "User@example.com", false, true, true, "UserPass", new Guid("6a28f0b1-e914-4abf-a39e-32c57dcfa48c"), "User1", new Guid("e6c37806-abe5-4d8d-b44c-a1b4d0033c18") },
                    { new Guid("5850cf37-d741-4cbc-a004-855d365cf0b5"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(3984), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("dd2a5295-1d48-47c1-8b26-7991a8af7352") },
                    { new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"), new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(3982), "User@example.com", false, true, true, "UserPass", new Guid("6a28f0b1-e914-4abf-a39e-32c57dcfa48c"), "User2", new Guid("dd2a5295-1d48-47c1-8b26-7991a8af7352") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("c7ea3574-3879-4965-91a8-35e5ad75e5de"), new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"), new Guid("37f73168-2747-4f00-bff4-586f9d144586"), false, true },
                    { new Guid("f2d3612b-e85e-4a8b-883a-cf500e121921"), new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"), new Guid("b2457adf-0048-4439-87fa-62cbf03fbfba"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2"), new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd"), false, true },
                    { new Guid("c7876571-c563-4700-b28d-ccdf8fccc933"), new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("54770009-288e-46f2-9202-6d02be53470a"), new Guid("96417f66-a853-4789-b86a-110f7d88efa6"), false, true },
                    { new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"), new Guid("62a8331a-f81b-4571-a58c-3025e9ccfac9"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("54770009-288e-46f2-9202-6d02be53470a"), new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2"), false, true },
                    { new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"), new Guid("c7876571-c563-4700-b28d-ccdf8fccc933"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("3ce740f9-f65e-4029-a663-554ea58fcaf7"), 200, new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4010), false, true, "Message", new Guid("e85f7279-4782-4043-9ba8-21a44403bdac") },
                    { new Guid("70603f02-6f79-4af9-9552-dd803d79d7e7"), 200, new DateTime(2024, 9, 30, 22, 27, 39, 681, DateTimeKind.Local).AddTicks(4008), false, true, "Message", new Guid("54770009-288e-46f2-9202-6d02be53470a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("5850cf37-d741-4cbc-a004-855d365cf0b5"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("54770009-288e-46f2-9202-6d02be53470a"), new Guid("96417f66-a853-4789-b86a-110f7d88efa6") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"), new Guid("62a8331a-f81b-4571-a58c-3025e9ccfac9") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("54770009-288e-46f2-9202-6d02be53470a"), new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"), new Guid("c7876571-c563-4700-b28d-ccdf8fccc933") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("3ce740f9-f65e-4029-a663-554ea58fcaf7"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("70603f02-6f79-4af9-9552-dd803d79d7e7"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("c7ea3574-3879-4965-91a8-35e5ad75e5de"), new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"), new Guid("37f73168-2747-4f00-bff4-586f9d144586") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("f2d3612b-e85e-4a8b-883a-cf500e121921"), new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"), new Guid("b2457adf-0048-4439-87fa-62cbf03fbfba") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("9af657f4-6eaf-4b05-b39e-d073cc68d79f"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("d5eebb52-32e4-45d6-ae29-5530fbf036dc"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"), new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"), new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2"), new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("c7876571-c563-4700-b28d-ccdf8fccc933"), new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("54770009-288e-46f2-9202-6d02be53470a"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("e85f7279-4782-4043-9ba8-21a44403bdac"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("62a8331a-f81b-4571-a58c-3025e9ccfac9"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("96417f66-a853-4789-b86a-110f7d88efa6"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("c7ea3574-3879-4965-91a8-35e5ad75e5de"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("f2d3612b-e85e-4a8b-883a-cf500e121921"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("83b87d20-ea43-4380-9292-c6933ce6b361"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("a11a59ee-6921-4248-8dad-fdfe9b687abf"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("1e74e7e2-4329-409d-b58e-7245455d7fb2"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("c7876571-c563-4700-b28d-ccdf8fccc933"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("37f73168-2747-4f00-bff4-586f9d144586"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("b2457adf-0048-4439-87fa-62cbf03fbfba"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("7303792b-d7c0-409a-bafc-bbac9c9362bd"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("ccded7cc-7aca-47df-9078-d094f015c7ab"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("dd2a5295-1d48-47c1-8b26-7991a8af7352"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("e6c37806-abe5-4d8d-b44c-a1b4d0033c18"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("6a28f0b1-e914-4abf-a39e-32c57dcfa48c"));

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("2daaf4af-dbbe-4e4b-89fe-00a39a3b13ff"), false, true, 0 },
                    { new Guid("c6ca23e0-ec47-4286-98f3-f496063a44bd"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("913e2b46-7325-420d-bdee-2e5c6ba8c15e"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8034), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("977ed311-f7c5-4ce8-aac4-9ef49f3e5f18"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8026), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("2fc317e5-9190-4efa-8577-2784c90a67b1"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8257), false, true, 0, "Name1" },
                    { new Guid("425bfaee-83b8-4f4d-a987-2541a02b838c"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8255), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8187), false, true, "Plan 2" },
                    { new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8185), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("56d38d47-884a-4186-b9c9-8921a5108483"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8097), new DateTime(2024, 10, 5, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8096), false, true, "Project2", new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8096) },
                    { new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 10, 5, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8089), false, true, "Project1", new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8085) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("5b0cf2f2-657c-4777-bda7-f42982681496"), null, null, "192.168.1.8", false, true, null, "proxyPass2", 8080, null, "proxyUser2" },
                    { new Guid("7419c7ae-752a-4ef7-b17e-a59f15e98be4"), null, null, "192.168.1.7", false, true, null, "proxyPass2", 8080, null, "proxyUser2" },
                    { new Guid("e5c55fda-428c-454f-972e-3b29083d5c36"), null, null, "192.168.1.6", false, true, null, "proxyPass1", 8080, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("6a9a225c-e108-4c38-b844-50a13941bcb5"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8233), false, true, 0, 0, "Name1" },
                    { new Guid("b19f768e-4ced-4bba-9e6d-30a516c5c4fb"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8231), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8229), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8140), false, true, "Script 1" },
                    { new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8141), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"), new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c"), false, true, null, null },
                    { new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"), new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(7970), "User@example.com", false, true, true, "UserPass", new Guid("e5c55fda-428c-454f-972e-3b29083d5c36"), "User2", new Guid("c6ca23e0-ec47-4286-98f3-f496063a44bd") },
                    { new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(7956), "User@example.com", false, true, true, "UserPass", new Guid("e5c55fda-428c-454f-972e-3b29083d5c36"), "User1", new Guid("2daaf4af-dbbe-4e4b-89fe-00a39a3b13ff") },
                    { new Guid("e502cf30-75af-4df7-bf1f-f515b860243d"), new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(7973), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("c6ca23e0-ec47-4286-98f3-f496063a44bd") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2fc317e5-9190-4efa-8577-2784c90a67b1"), new Guid("517167b9-4f07-4f19-9619-703c5916b5a1"), new Guid("6a9a225c-e108-4c38-b844-50a13941bcb5"), false, true },
                    { new Guid("425bfaee-83b8-4f4d-a987-2541a02b838c"), new Guid("53b12a3f-badc-4d4a-aeb0-0d645bc95132"), new Guid("b19f768e-4ced-4bba-9e6d-30a516c5c4fb"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("56d38d47-884a-4186-b9c9-8921a5108483"), new Guid("ae9f4c54-63e3-4abe-ba03-17c86d4f307c"), false, true },
                    { new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012"), new Guid("63442f53-78ca-40b0-9bcf-8eadebb9f9ec"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"), new Guid("913e2b46-7325-420d-bdee-2e5c6ba8c15e"), false, true },
                    { new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"), new Guid("977ed311-f7c5-4ce8-aac4-9ef49f3e5f18"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de"), new Guid("56d38d47-884a-4186-b9c9-8921a5108483"), false, true },
                    { new Guid("c21c7efb-f548-400f-8c2f-94439afe582d"), new Guid("d4b54d73-0ffa-4e20-ad87-a52cfffe5012"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("313ca6bd-f1d0-48ec-b8a3-cba018c22ef0"), 200, new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(7997), false, true, "Message", new Guid("c21c7efb-f548-400f-8c2f-94439afe582d") },
                    { new Guid("31c6a3fe-ca44-452b-b21d-5eeb9f1303d9"), 200, new DateTime(2024, 9, 30, 19, 41, 7, 526, DateTimeKind.Local).AddTicks(8000), false, true, "Message", new Guid("4c7b268f-7b2e-492f-94a6-940a5f8325de") }
                });
        }
    }
}

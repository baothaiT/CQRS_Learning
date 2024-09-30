using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("23f7e997-e479-4810-8f2a-21f6d4b61af8"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("0e892c99-358f-4279-85c2-7dc99407babe"), new Guid("c1c7824c-fe62-45bc-a161-aa10eb6c5bc3") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"), new Guid("ddcacb2e-d45f-45a4-9664-75d6d5443c91") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("0e892c99-358f-4279-85c2-7dc99407babe"), new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"), new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("2e161e69-6479-419a-905c-4e67f113c5d7"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("5ca37569-5d9f-4773-94be-91963dfd0859"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("6d1a9a05-aa35-4dc1-8f00-0f2a5f9d438a"), new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"), new Guid("5676c2a7-6ea1-4265-8637-7502b9a4de80") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("6059a752-6350-443f-aabf-ecd8d4d277d5"), new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"), new Guid("65ab1cd3-8869-455d-90ee-1ef81257d963") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("21b6cfca-6b55-4f7c-906e-91f5013d2555"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("85978f00-7e55-4a48-9bab-41f06847cabb"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"), new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"), new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346"), new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8"), new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("0e892c99-358f-4279-85c2-7dc99407babe"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("30dfb552-05da-457f-a24a-361e62f7a2e6"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("c1c7824c-fe62-45bc-a161-aa10eb6c5bc3"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("ddcacb2e-d45f-45a4-9664-75d6d5443c91"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("6059a752-6350-443f-aabf-ecd8d4d277d5"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("6d1a9a05-aa35-4dc1-8f00-0f2a5f9d438a"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("78992a86-be2c-4e88-90eb-232cebd44edf"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("ab15debb-0c1b-49c9-a99f-1de56dbedb47"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("2f760619-ddd0-4e26-8e2b-eb82fda2d346"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("5b593ead-c0d1-4ba9-ab40-6d09fd52dbf8"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("5676c2a7-6ea1-4265-8637-7502b9a4de80"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("65ab1cd3-8869-455d-90ee-1ef81257d963"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("4e68caa0-fc5d-4a80-87ee-dd7ca5c717c2"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("f3191aa0-756d-4ee3-8c52-eff8a05b1eec"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("3b9499a8-1e50-48b5-bd8a-9d732b73cab4"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("e556e4bc-84ce-436d-b5f1-11f95e871596"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("2bc7de9e-80c0-47f7-94d5-a5a449616cdc"));

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("b4f23363-0df6-4dc4-9d51-2855c1be9605"), false, 0 },
                    { new Guid("ed9e8897-ac93-4721-9c62-b89191b3f47d"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("03513d62-ca7f-45f8-9747-d665b324addf"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2483), 600m, false, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("69aaeee5-2e9f-4d58-9c03-5a8f12f89158"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2475), 600m, false, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("17be27b6-26ae-4a86-ae21-d102ba9a8cdc"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3520), false, 0, "Name1" },
                    { new Guid("f9a2b7db-fd30-4e42-be4c-a1421326a8cb"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3517), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2669), false, "Plan 1" },
                    { new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2670), false, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2554), new DateTime(2024, 10, 5, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2553), false, "Project2", new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2553) },
                    { new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2551), new DateTime(2024, 10, 5, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2544), false, "Project1", new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2543) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "IsStatus", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("05be8454-92dd-4203-ac4d-629cd87cd5b2"), "192.168.1.8", false, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("1c9219e4-99f6-4e4b-9553-2ec76249cbe1"), "192.168.1.7", false, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("6be1a98b-1268-43a6-9471-228307ba532a"), "192.168.1.6", false, null, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("85633b00-4ba0-4141-8060-3a471fcaf448"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3313), false, 0, 0, "Name1" },
                    { new Guid("bd6e4a02-3c34-411d-aea6-1fc595977b6d"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(3321), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2607), false, "Script 1" },
                    { new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2609), false, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"), new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9"), false, null, null },
                    { new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"), new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f"), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0f1e7877-acf3-45a4-a533-367c7f2d21ce"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2399), "User@example.com", false, true, "UserPass", null, "User3", new Guid("ed9e8897-ac93-4721-9c62-b89191b3f47d") },
                    { new Guid("106d6612-4380-43a9-aa36-129b1edef91f"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2396), "User@example.com", false, true, "UserPass", new Guid("6be1a98b-1268-43a6-9471-228307ba532a"), "User2", new Guid("ed9e8897-ac93-4721-9c62-b89191b3f47d") },
                    { new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"), new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2383), "User@example.com", false, true, "UserPass", new Guid("6be1a98b-1268-43a6-9471-228307ba532a"), "User1", new Guid("b4f23363-0df6-4dc4-9d51-2855c1be9605") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("f9a2b7db-fd30-4e42-be4c-a1421326a8cb"), new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"), new Guid("85633b00-4ba0-4141-8060-3a471fcaf448"), false },
                    { new Guid("17be27b6-26ae-4a86-ae21-d102ba9a8cdc"), new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"), new Guid("bd6e4a02-3c34-411d-aea6-1fc595977b6d"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da"), new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f"), false },
                    { new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d"), new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("106d6612-4380-43a9-aa36-129b1edef91f"), new Guid("03513d62-ca7f-45f8-9747-d665b324addf"), false },
                    { new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"), new Guid("69aaeee5-2e9f-4d58-9c03-5a8f12f89158"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("106d6612-4380-43a9-aa36-129b1edef91f"), new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da"), false },
                    { new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"), new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d"), false }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("63495a93-d3aa-4445-8cd4-da62482ccb68"), 200, new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2433), false, "Message", new Guid("106d6612-4380-43a9-aa36-129b1edef91f") },
                    { new Guid("8bea94e5-8067-4a75-b11c-376db814691d"), 200, new DateTime(2024, 9, 30, 19, 1, 15, 477, DateTimeKind.Local).AddTicks(2432), false, "Message", new Guid("914f03cf-56cf-4185-8bbd-27cae876b100") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("0f1e7877-acf3-45a4-a533-367c7f2d21ce"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("106d6612-4380-43a9-aa36-129b1edef91f"), new Guid("03513d62-ca7f-45f8-9747-d665b324addf") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"), new Guid("69aaeee5-2e9f-4d58-9c03-5a8f12f89158") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("106d6612-4380-43a9-aa36-129b1edef91f"), new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"), new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("63495a93-d3aa-4445-8cd4-da62482ccb68"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("8bea94e5-8067-4a75-b11c-376db814691d"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("f9a2b7db-fd30-4e42-be4c-a1421326a8cb"), new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"), new Guid("85633b00-4ba0-4141-8060-3a471fcaf448") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("17be27b6-26ae-4a86-ae21-d102ba9a8cdc"), new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"), new Guid("bd6e4a02-3c34-411d-aea6-1fc595977b6d") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("05be8454-92dd-4203-ac4d-629cd87cd5b2"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("1c9219e4-99f6-4e4b-9553-2ec76249cbe1"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"), new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"), new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da"), new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d"), new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("106d6612-4380-43a9-aa36-129b1edef91f"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("914f03cf-56cf-4185-8bbd-27cae876b100"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("03513d62-ca7f-45f8-9747-d665b324addf"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("69aaeee5-2e9f-4d58-9c03-5a8f12f89158"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("17be27b6-26ae-4a86-ae21-d102ba9a8cdc"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("f9a2b7db-fd30-4e42-be4c-a1421326a8cb"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("22073baa-3cd1-4f1e-8d70-4cbfe56e8291"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("ddd964a0-2f6c-45c5-8b02-56dc1332a325"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("7c26c640-883a-4cb3-9f97-c3dcc6ebb5da"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("9b34a485-d497-4d73-91ec-aa5076c0268d"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("85633b00-4ba0-4141-8060-3a471fcaf448"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("bd6e4a02-3c34-411d-aea6-1fc595977b6d"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("875c3c10-eb59-4a46-9d78-a3f898ad29b9"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("aa64cfd9-3dab-4cad-9326-fcf5026c720f"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("b4f23363-0df6-4dc4-9d51-2855c1be9605"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("ed9e8897-ac93-4721-9c62-b89191b3f47d"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("6be1a98b-1268-43a6-9471-228307ba532a"));

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ScriptTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ScriptsInProjectTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ScriptsInPlanTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ScheduleTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ProxyTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "ProjectTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "PlanTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "PlansInScheduleTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "LogsTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "DevicesTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "BrowserTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "AccountTypeTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "AccountTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "AccountsInProjectTable",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMigration",
                table: "AccountsInBrowserTable",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("a28a142b-6965-42f6-999c-ec8cb4eaf85c"), false, null, 1 },
                    { new Guid("f10b2c9f-2918-4fe9-ab8a-9a8fae6e41b6"), false, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("628334c0-ecdc-4635-b10e-da37bf9b2e69"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3353), 600m, false, null, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("6dbfe761-d698-4896-b839-1f8e56f1e899"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3361), 600m, false, null, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("86cbd0e0-4e9c-42f9-9f5a-962d4c239f1d"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3581), false, null, 0, "Name1" },
                    { new Guid("b08edeae-9e01-429e-b977-533d373a3ad1"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3579), false, null, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3514), false, null, "Plan 1" },
                    { new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3515), false, null, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 10, 5, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3411), false, null, "Project2", new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3410) },
                    { new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 10, 5, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3404), false, null, "Project1", new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3403) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("617b4283-d6ed-4773-abc4-3c9363850465"), "192.168.1.7", false, null, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("68f05e14-2fea-4106-879c-9108e7db8887"), "192.168.1.8", false, null, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("d6052f43-4ca3-4147-ba5d-8527a6cda9d5"), "192.168.1.6", false, null, null, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("9cc45dae-4d67-4707-b7cb-99bb774a65fd"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3558), false, null, 0, 0, "Name1" },
                    { new Guid("a2641b86-c511-40ba-beaf-2927d9a522b4"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3555), false, null, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("098f52d9-2d23-449e-b799-2a52fd323737"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3461), false, null, "Script 2" },
                    { new Guid("9559f168-3592-46aa-a269-e6406587d055"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3460), false, null, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"), new Guid("9559f168-3592-46aa-a269-e6406587d055"), false, null, null, null },
                    { new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"), new Guid("098f52d9-2d23-449e-b799-2a52fd323737"), false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3284), "User@example.com", false, null, true, "UserPass", new Guid("d6052f43-4ca3-4147-ba5d-8527a6cda9d5"), "User1", new Guid("f10b2c9f-2918-4fe9-ab8a-9a8fae6e41b6") },
                    { new Guid("5f90bc81-20ea-440c-8fc2-068fffa7319c"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3297), "User@example.com", false, null, true, "UserPass", null, "User3", new Guid("a28a142b-6965-42f6-999c-ec8cb4eaf85c") },
                    { new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"), new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3295), "User@example.com", false, null, true, "UserPass", new Guid("d6052f43-4ca3-4147-ba5d-8527a6cda9d5"), "User2", new Guid("a28a142b-6965-42f6-999c-ec8cb4eaf85c") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("86cbd0e0-4e9c-42f9-9f5a-962d4c239f1d"), new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"), new Guid("9cc45dae-4d67-4707-b7cb-99bb774a65fd"), false, null },
                    { new Guid("b08edeae-9e01-429e-b977-533d373a3ad1"), new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"), new Guid("a2641b86-c511-40ba-beaf-2927d9a522b4"), false, null }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6"), new Guid("098f52d9-2d23-449e-b799-2a52fd323737"), false, null },
                    { new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828"), new Guid("9559f168-3592-46aa-a269-e6406587d055"), false, null }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"), new Guid("628334c0-ecdc-4635-b10e-da37bf9b2e69"), false, null },
                    { new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"), new Guid("6dbfe761-d698-4896-b839-1f8e56f1e899"), false, null }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"), new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828"), false, null },
                    { new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"), new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6"), false, null }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("1714949b-b0c1-43c4-afa3-9f794ba09c29"), 200, new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3324), false, null, "Message", new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3") },
                    { new Guid("ab5b535f-23fb-4e6b-b185-b7d2e996550e"), 200, new DateTime(2024, 9, 30, 19, 4, 45, 246, DateTimeKind.Local).AddTicks(3323), false, null, "Message", new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("5f90bc81-20ea-440c-8fc2-068fffa7319c"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"), new Guid("628334c0-ecdc-4635-b10e-da37bf9b2e69") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"), new Guid("6dbfe761-d698-4896-b839-1f8e56f1e899") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"), new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"), new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("1714949b-b0c1-43c4-afa3-9f794ba09c29"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("ab5b535f-23fb-4e6b-b185-b7d2e996550e"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("86cbd0e0-4e9c-42f9-9f5a-962d4c239f1d"), new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"), new Guid("9cc45dae-4d67-4707-b7cb-99bb774a65fd") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("b08edeae-9e01-429e-b977-533d373a3ad1"), new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"), new Guid("a2641b86-c511-40ba-beaf-2927d9a522b4") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("617b4283-d6ed-4773-abc4-3c9363850465"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("68f05e14-2fea-4106-879c-9108e7db8887"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"), new Guid("9559f168-3592-46aa-a269-e6406587d055") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"), new Guid("098f52d9-2d23-449e-b799-2a52fd323737") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6"), new Guid("098f52d9-2d23-449e-b799-2a52fd323737") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828"), new Guid("9559f168-3592-46aa-a269-e6406587d055") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("0bb39e35-a9c6-48cd-a89a-1eacc713d1b1"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("b68c05d9-6f2f-4d7b-8160-fadc678477b3"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("628334c0-ecdc-4635-b10e-da37bf9b2e69"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("6dbfe761-d698-4896-b839-1f8e56f1e899"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("86cbd0e0-4e9c-42f9-9f5a-962d4c239f1d"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("b08edeae-9e01-429e-b977-533d373a3ad1"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("1b2273af-6af6-4fa5-9dbd-0500e9d398bc"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("655fab4e-8a84-4a9b-9027-41af8416fdc0"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("4fb2a882-56e3-41cd-a3d7-7ccfcf91b3b6"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("c2f99f15-a1e0-436f-a041-8f1a1a491828"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("9cc45dae-4d67-4707-b7cb-99bb774a65fd"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("a2641b86-c511-40ba-beaf-2927d9a522b4"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("098f52d9-2d23-449e-b799-2a52fd323737"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("9559f168-3592-46aa-a269-e6406587d055"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("a28a142b-6965-42f6-999c-ec8cb4eaf85c"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("f10b2c9f-2918-4fe9-ab8a-9a8fae6e41b6"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("d6052f43-4ca3-4147-ba5d-8527a6cda9d5"));

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ScriptTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ScriptsInProjectTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ScriptsInPlanTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ScheduleTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ProxyTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "ProjectTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "PlanTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "PlansInScheduleTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "LogsTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "DevicesTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "BrowserTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "AccountTypeTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "AccountTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "AccountsInProjectTable");

            migrationBuilder.DropColumn(
                name: "IsMigration",
                table: "AccountsInBrowserTable");

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
    }
}

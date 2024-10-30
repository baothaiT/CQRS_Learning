using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class updateCreateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("7a98ead2-e62a-4552-96f4-d31a9f668a8b"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("0264bd72-fc09-4758-8216-c5948751826e") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("2cb5373f-6566-49b3-858a-c19ef9f8f0f5"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("72aae3a6-d1fc-435d-8ca1-cbea0502fd0f"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"), new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"), new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("d607cf84-46c1-459c-9bf9-969669e14714") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("112ec4af-b26f-4cdc-8953-2f5ff466b9c9"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("75bd90cb-add8-4b72-8d95-738edaa85d90"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("04aab300-11f3-4172-bada-9948a88d5722"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("0264bd72-fc09-4758-8216-c5948751826e"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("d607cf84-46c1-459c-9bf9-969669e14714"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("2f7a710e-9dfd-4483-bf1e-a555c43da3dd"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"));

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("9d41984d-5500-41bc-98ae-434430766854"), false, true, 0 },
                    { new Guid("b95aaf4e-1591-40bd-9078-800e5cf0daff"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("abd344fb-2d1e-47a5-846f-c4e486de3766"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7928), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("f6b53eb4-aee2-49e9-9f11-acda70d8f22e"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7920), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("b509188c-50b7-4552-8459-6bd03f52e2fc"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8174), false, true, 0, "Name1" },
                    { new Guid("c6f38230-18da-443e-bff2-756849b78f45"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8176), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("4499227e-433c-4196-904b-e664625dc235"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8105), false, true, "Plan 2" },
                    { new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8104), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 11, 4, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8000), false, true, "Project2", new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7999) },
                    { new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7998), new DateTime(2024, 11, 4, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7992), false, true, "Project1", new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7991) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("079e8565-e2ab-4bab-b775-9cd8bb972e2a"), null, new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7451), "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("8ad2d9b7-165a-43ac-8257-214d8992b7ed"), null, new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7448), "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("df5f745b-4381-41d0-a4fc-e19962d09bc0"), null, new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7434), "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("c5ddebb9-7c95-4a4d-808e-35dd3b22d892"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8150), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8149), false, true, 0, 0, "Name1" },
                    { new Guid("f5fedc54-7fd4-4e71-a69a-c7759408a71e"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8148), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8147), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("8be00122-8e51-457e-adaf-545166bb8717"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8053), false, true, "Script 2" },
                    { new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(8052), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("4499227e-433c-4196-904b-e664625dc235"), new Guid("8be00122-8e51-457e-adaf-545166bb8717"), false, true, null, null },
                    { new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"), new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7850), "User@example.com", false, true, true, "UserPass", new Guid("df5f745b-4381-41d0-a4fc-e19962d09bc0"), "User1", new Guid("9d41984d-5500-41bc-98ae-434430766854") },
                    { new Guid("8fe2b153-a026-4e6e-8f30-b7655c0dc9ee"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7857), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("b95aaf4e-1591-40bd-9078-800e5cf0daff") },
                    { new Guid("906deb90-0973-4d47-b802-13008ab0145d"), new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7854), "User@example.com", false, true, true, "UserPass", new Guid("df5f745b-4381-41d0-a4fc-e19962d09bc0"), "User2", new Guid("b95aaf4e-1591-40bd-9078-800e5cf0daff") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("c6f38230-18da-443e-bff2-756849b78f45"), new Guid("4499227e-433c-4196-904b-e664625dc235"), new Guid("c5ddebb9-7c95-4a4d-808e-35dd3b22d892"), false, true },
                    { new Guid("b509188c-50b7-4552-8459-6bd03f52e2fc"), new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"), new Guid("f5fedc54-7fd4-4e71-a69a-c7759408a71e"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6"), new Guid("8be00122-8e51-457e-adaf-545166bb8717"), false, true },
                    { new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f"), new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"), new Guid("f6b53eb4-aee2-49e9-9f11-acda70d8f22e"), false, true },
                    { new Guid("906deb90-0973-4d47-b802-13008ab0145d"), new Guid("abd344fb-2d1e-47a5-846f-c4e486de3766"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"), new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f"), false, true },
                    { new Guid("906deb90-0973-4d47-b802-13008ab0145d"), new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("de43462c-f75b-4046-8e7e-41162989bd6e"), 200, new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7889), false, true, "Message", new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c") },
                    { new Guid("e1a99076-ca44-41ce-ba24-acbbc42e3be2"), 200, new DateTime(2024, 10, 30, 23, 54, 43, 973, DateTimeKind.Local).AddTicks(7891), false, true, "Message", new Guid("906deb90-0973-4d47-b802-13008ab0145d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("8fe2b153-a026-4e6e-8f30-b7655c0dc9ee"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"), new Guid("f6b53eb4-aee2-49e9-9f11-acda70d8f22e") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("906deb90-0973-4d47-b802-13008ab0145d"), new Guid("abd344fb-2d1e-47a5-846f-c4e486de3766") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"), new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("906deb90-0973-4d47-b802-13008ab0145d"), new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("de43462c-f75b-4046-8e7e-41162989bd6e"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("e1a99076-ca44-41ce-ba24-acbbc42e3be2"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("c6f38230-18da-443e-bff2-756849b78f45"), new Guid("4499227e-433c-4196-904b-e664625dc235"), new Guid("c5ddebb9-7c95-4a4d-808e-35dd3b22d892") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("b509188c-50b7-4552-8459-6bd03f52e2fc"), new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"), new Guid("f5fedc54-7fd4-4e71-a69a-c7759408a71e") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("079e8565-e2ab-4bab-b775-9cd8bb972e2a"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("8ad2d9b7-165a-43ac-8257-214d8992b7ed"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("4499227e-433c-4196-904b-e664625dc235"), new Guid("8be00122-8e51-457e-adaf-545166bb8717") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"), new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6"), new Guid("8be00122-8e51-457e-adaf-545166bb8717") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f"), new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("55111db4-fae8-4be6-bfc6-00a1669ea14c"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("906deb90-0973-4d47-b802-13008ab0145d"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("abd344fb-2d1e-47a5-846f-c4e486de3766"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("f6b53eb4-aee2-49e9-9f11-acda70d8f22e"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("b509188c-50b7-4552-8459-6bd03f52e2fc"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("c6f38230-18da-443e-bff2-756849b78f45"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("4499227e-433c-4196-904b-e664625dc235"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("dc74a64d-3e81-48e9-b276-85ce6e4cc891"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("c431ae29-4ab2-4d25-b813-0d6920b241c6"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("d4b4bc60-42cb-40ce-8705-6ecae6bda75f"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("c5ddebb9-7c95-4a4d-808e-35dd3b22d892"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("f5fedc54-7fd4-4e71-a69a-c7759408a71e"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("8be00122-8e51-457e-adaf-545166bb8717"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("c63a8572-bc4f-4066-8986-cac01095d9d5"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("9d41984d-5500-41bc-98ae-434430766854"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("b95aaf4e-1591-40bd-9078-800e5cf0daff"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("df5f745b-4381-41d0-a4fc-e19962d09bc0"));

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("2f7a710e-9dfd-4483-bf1e-a555c43da3dd"), false, true, 0 },
                    { new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("0264bd72-fc09-4758-8216-c5948751826e"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2451), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2464), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2700), false, true, 0, "Name1" },
                    { new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2698), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2624), false, true, "Plan 2" },
                    { new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2622), false, true, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2519), new DateTime(2024, 11, 4, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2513), false, true, "Project1", new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2513) },
                    { new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 11, 4, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2521), false, true, "Project2", new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2521) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "CheckLiveDate", "CreateDate", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "Type", "UpdateDate", "User" },
                values: new object[,]
                {
                    { new Guid("112ec4af-b26f-4cdc-8953-2f5ff466b9c9"), null, null, "192.168.1.8", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" },
                    { new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), null, null, "192.168.1.6", false, true, 0, "proxyPass1", 8080, 0, null, "proxyUser1" },
                    { new Guid("75bd90cb-add8-4b72-8d95-738edaa85d90"), null, null, "192.168.1.7", false, true, 0, "proxyPass2", 8080, 0, null, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2675), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2674), false, true, 0, 0, "Name1" },
                    { new Guid("d607cf84-46c1-459c-9bf9-969669e14714"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2677), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2677), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2575), false, true, "Script 1" },
                    { new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2577), false, true, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), false, true, null, null },
                    { new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2363), "User@example.com", false, true, true, "UserPass", new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), "User1", new Guid("2f7a710e-9dfd-4483-bf1e-a555c43da3dd") },
                    { new Guid("7a98ead2-e62a-4552-96f4-d31a9f668a8b"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2383), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6") },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2381), "User@example.com", false, true, true, "UserPass", new Guid("69385a9c-f3d7-4ee4-b34f-0914ef71d9fc"), "User2", new Guid("5b39f337-e1e5-4f0c-8072-0f2b1d52c4d6") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("2e41de76-28b4-4804-a497-ae18bc2fb0a4"), new Guid("d5d5e3e0-d998-4eeb-bb32-5307470d0e00"), new Guid("91e16205-2a8b-41d1-86b5-ea56e335c982"), false, true },
                    { new Guid("03ef9bbd-9e4b-43e3-89f3-b53bb81eb844"), new Guid("8e655d17-60ba-4f5e-a75b-ca7e9566e706"), new Guid("d607cf84-46c1-459c-9bf9-969669e14714"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), new Guid("1d0e120e-2dbb-423b-8f0c-059267b9c3ad"), false, true },
                    { new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), new Guid("3eadbcd5-72c9-4a15-a340-bc0492035e6a"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("0264bd72-fc09-4758-8216-c5948751826e"), false, true },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("18e85931-c09d-4b9b-8c00-e1e1ef93be5d"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("04aab300-11f3-4172-bada-9948a88d5722"), new Guid("27984667-34cc-43bc-a2c0-e5c333b2ef10"), false, true },
                    { new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689"), new Guid("f195ccff-80f5-41b6-928f-6b1c85b945bf"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2cb5373f-6566-49b3-858a-c19ef9f8f0f5"), 200, new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2416), false, true, "Message", new Guid("b5c573b4-fa0e-4ea1-91dc-7d4f37e13689") },
                    { new Guid("72aae3a6-d1fc-435d-8ca1-cbea0502fd0f"), 200, new DateTime(2024, 10, 30, 23, 51, 13, 671, DateTimeKind.Local).AddTicks(2414), false, true, "Message", new Guid("04aab300-11f3-4172-bada-9948a88d5722") }
                });
        }
    }
}

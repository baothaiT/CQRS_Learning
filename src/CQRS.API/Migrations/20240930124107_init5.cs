using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("7b9a2d22-2b0d-4cbf-a697-4061be622f82"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"), new Guid("cb65a69d-ba6d-4c46-9cf1-40d0f61ec2e1") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"), new Guid("92036125-19f9-4564-8d89-f2f7a2cf3683") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"), new Guid("94416f05-8186-4559-bf28-0f79afe770e7") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"), new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("13c03f82-f063-483b-8c0b-e9eddc910c8c"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("7a5eab54-239d-447e-8f68-62a6a6a58038"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("b07d0921-f3eb-45f9-922c-c7070eb67ea6"), new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"), new Guid("55665578-c406-42ca-949d-0c29804d851c") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("f219613a-a78b-4910-bd36-34cfe61d0674"), new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"), new Guid("d7eedfc9-53fe-4fa7-bcd5-1d07fdd13a07") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("63de0e94-1371-422d-98b0-2298e74ad38e"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("7d9f10c0-cf12-4859-83c9-ce023eabda4b"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"), new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"), new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("94416f05-8186-4559-bf28-0f79afe770e7"), new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd"), new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("92036125-19f9-4564-8d89-f2f7a2cf3683"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("cb65a69d-ba6d-4c46-9cf1-40d0f61ec2e1"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("b07d0921-f3eb-45f9-922c-c7070eb67ea6"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("f219613a-a78b-4910-bd36-34cfe61d0674"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("94416f05-8186-4559-bf28-0f79afe770e7"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("55665578-c406-42ca-949d-0c29804d851c"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("d7eedfc9-53fe-4fa7-bcd5-1d07fdd13a07"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("23fe0fe3-a62e-4572-a1c9-240de66f81ea"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("b6a26c1c-30d7-4eb8-8e6d-333bf14332ce"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("faa08555-d930-4f82-b65c-ac76df752c49"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckLiveDate",
                table: "ProxyTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ProxyTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "ProxyTable",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CheckLiveDate",
                table: "ProxyTable");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ProxyTable");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "ProxyTable");

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "IsMigration", "TypeName" },
                values: new object[,]
                {
                    { new Guid("23fe0fe3-a62e-4572-a1c9-240de66f81ea"), false, true, 0 },
                    { new Guid("b6a26c1c-30d7-4eb8-8e6d-333bf14332ce"), false, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsMigration", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("92036125-19f9-4564-8d89-f2f7a2cf3683"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5437), 600m, false, true, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("cb65a69d-ba6d-4c46-9cf1-40d0f61ec2e1"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5430), 600m, false, true, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("b07d0921-f3eb-45f9-922c-c7070eb67ea6"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5806), false, true, 0, "Name1" },
                    { new Guid("f219613a-a78b-4910-bd36-34cfe61d0674"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5805), false, true, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5734), false, true, "Plan 1" },
                    { new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5736), false, true, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "IsMigration", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("94416f05-8186-4559-bf28-0f79afe770e7"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5492), new DateTime(2024, 10, 5, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5487), false, true, "Project1", new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5485) },
                    { new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 10, 5, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5503), false, true, "Project2", new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5502) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "IsMigration", "IsStatus", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("63de0e94-1371-422d-98b0-2298e74ad38e"), "192.168.1.7", false, true, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("7d9f10c0-cf12-4859-83c9-ce023eabda4b"), "192.168.1.8", false, true, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("faa08555-d930-4f82-b65c-ac76df752c49"), "192.168.1.6", false, true, null, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsMigration", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("55665578-c406-42ca-949d-0c29804d851c"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5785), false, true, 0, 0, "Name1" },
                    { new Guid("d7eedfc9-53fe-4fa7-bcd5-1d07fdd13a07"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5781), false, true, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsMigration", "Name" },
                values: new object[,]
                {
                    { new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5549), false, true, "Script 2" },
                    { new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5547), false, true, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "IsMigration", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"), new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5"), false, true, null, null },
                    { new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"), new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42"), false, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsMigration", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("7b9a2d22-2b0d-4cbf-a697-4061be622f82"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5370), "User@example.com", false, true, true, "UserPass", null, "User3", new Guid("b6a26c1c-30d7-4eb8-8e6d-333bf14332ce") },
                    { new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5357), "User@example.com", false, true, true, "UserPass", new Guid("faa08555-d930-4f82-b65c-ac76df752c49"), "User1", new Guid("23fe0fe3-a62e-4572-a1c9-240de66f81ea") },
                    { new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"), new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5368), "User@example.com", false, true, true, "UserPass", new Guid("faa08555-d930-4f82-b65c-ac76df752c49"), "User2", new Guid("b6a26c1c-30d7-4eb8-8e6d-333bf14332ce") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("b07d0921-f3eb-45f9-922c-c7070eb67ea6"), new Guid("de6f16e2-0faf-4506-9da7-76c64b2e485b"), new Guid("55665578-c406-42ca-949d-0c29804d851c"), false, true },
                    { new Guid("f219613a-a78b-4910-bd36-34cfe61d0674"), new Guid("c857e06d-d1bc-4d13-a6ee-974414922c7f"), new Guid("d7eedfc9-53fe-4fa7-bcd5-1d07fdd13a07"), false, true }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("94416f05-8186-4559-bf28-0f79afe770e7"), new Guid("81089183-c973-4b6d-86d5-e80ec9302ca5"), false, true },
                    { new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd"), new Guid("6c959b11-ac8c-42b6-b7d9-2bda39793e42"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"), new Guid("cb65a69d-ba6d-4c46-9cf1-40d0f61ec2e1"), false, true },
                    { new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"), new Guid("92036125-19f9-4564-8d89-f2f7a2cf3683"), false, true }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete", "IsMigration" },
                values: new object[,]
                {
                    { new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850"), new Guid("94416f05-8186-4559-bf28-0f79afe770e7"), false, true },
                    { new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b"), new Guid("dc1fde1a-8ab9-4979-95d6-fc519124fcdd"), false, true }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "IsMigration", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("13c03f82-f063-483b-8c0b-e9eddc910c8c"), 200, new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5402), false, true, "Message", new Guid("c3e5060b-5322-483d-8d2b-7b4ada88de1b") },
                    { new Guid("7a5eab54-239d-447e-8f68-62a6a6a58038"), 200, new DateTime(2024, 9, 30, 19, 7, 28, 357, DateTimeKind.Local).AddTicks(5400), false, true, "Message", new Guid("7c158e86-b3e3-4b72-9212-c79c8d5b3850") }
                });
        }
    }
}

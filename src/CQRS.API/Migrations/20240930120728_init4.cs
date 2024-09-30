using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.API.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

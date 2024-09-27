using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScriptsInPlanTable_PlanTable_ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ScriptsInPlanTable_ScriptTable_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable");

            migrationBuilder.AlterColumn<Guid>(
                name: "ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("15480db7-ecd2-4d1c-8931-b1c18e0c20d8"), false, 1 },
                    { new Guid("ed253fc7-350a-4a38-99b3-8f44bccd7fbb"), false, 0 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("b93f690d-44b9-423f-938f-d0835245dc21"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7600), false, false, "Name2", "Path" },
                    { new Guid("f3d6f56c-61f8-4cbe-81f4-9275791e682b"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7598), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("4d1e224f-bce3-4cde-82f5-6fd42e7536be"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7802), false, 0, "Name1" },
                    { new Guid("cd55bf1f-1e17-488e-a68f-90d0ce983021"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7803), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("a4174b7c-6313-40dc-9551-abfb04470350"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7730), false, "Plan 1" },
                    { new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7732), false, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 10, 3, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7639), false, "Project1", new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7638) },
                    { new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7646), new DateTime(2024, 10, 3, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7645), false, "Project2", new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7645) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("58830584-f650-4def-834b-38101d98537b"), "192.168.1.7", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("9f65ca1a-7b12-4838-9519-b0248281e57f"), "192.168.1.6", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("ee936e18-f4b9-4894-b709-4db7c551f88a"), "192.168.1.8", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("52a2dcbb-68c7-4e4c-bc23-cee4d49721c0"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7778), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7777), false, 0, 0, "Name1" },
                    { new Guid("a2d2a23e-5d46-4bca-a018-0ea676fdf2b6"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7780), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7688), false, "Script 1" },
                    { new Guid("68fad250-947e-417d-ab6b-12762196ddfa"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7690), false, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("a4174b7c-6313-40dc-9551-abfb04470350"), new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238"), false, null, null },
                    { new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"), new Guid("68fad250-947e-417d-ab6b-12762196ddfa"), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0bdadcbc-15cb-41f1-8294-997cdfde036d"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7551), "User@example.com", false, true, "UserPass", null, "User3", new Guid("15480db7-ecd2-4d1c-8931-b1c18e0c20d8") },
                    { new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7537), "User@example.com", false, true, "UserPass", new Guid("9f65ca1a-7b12-4838-9519-b0248281e57f"), "User1", new Guid("ed253fc7-350a-4a38-99b3-8f44bccd7fbb") },
                    { new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"), new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7548), "User@example.com", false, true, "UserPass", new Guid("9f65ca1a-7b12-4838-9519-b0248281e57f"), "User2", new Guid("15480db7-ecd2-4d1c-8931-b1c18e0c20d8") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("4d1e224f-bce3-4cde-82f5-6fd42e7536be"), new Guid("a4174b7c-6313-40dc-9551-abfb04470350"), new Guid("52a2dcbb-68c7-4e4c-bc23-cee4d49721c0"), false },
                    { new Guid("cd55bf1f-1e17-488e-a68f-90d0ce983021"), new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"), new Guid("a2d2a23e-5d46-4bca-a018-0ea676fdf2b6"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5"), new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238"), false },
                    { new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949"), new Guid("68fad250-947e-417d-ab6b-12762196ddfa"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"), new Guid("f3d6f56c-61f8-4cbe-81f4-9275791e682b"), false },
                    { new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"), new Guid("b93f690d-44b9-423f-938f-d0835245dc21"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"), new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5"), false },
                    { new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"), new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949"), false }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("be3c8b82-91a4-4269-bf1c-dcfa3abf6311"), 200, new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7577), false, "Message", new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da") },
                    { new Guid("cbc892d1-a6c2-43ea-9c90-4abd4121dc94"), 200, new DateTime(2024, 9, 28, 1, 12, 46, 399, DateTimeKind.Local).AddTicks(7575), false, "Message", new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ScriptsInPlanTable_PlanTable_ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_PlanId",
                principalTable: "PlanTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScriptsInPlanTable_ScriptTable_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_ScriptId",
                principalTable: "ScriptTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScriptsInPlanTable_PlanTable_ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ScriptsInPlanTable_ScriptTable_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable");

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("0bdadcbc-15cb-41f1-8294-997cdfde036d"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"), new Guid("f3d6f56c-61f8-4cbe-81f4-9275791e682b") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"), new Guid("b93f690d-44b9-423f-938f-d0835245dc21") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"), new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"), new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("be3c8b82-91a4-4269-bf1c-dcfa3abf6311"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("cbc892d1-a6c2-43ea-9c90-4abd4121dc94"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("4d1e224f-bce3-4cde-82f5-6fd42e7536be"), new Guid("a4174b7c-6313-40dc-9551-abfb04470350"), new Guid("52a2dcbb-68c7-4e4c-bc23-cee4d49721c0") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("cd55bf1f-1e17-488e-a68f-90d0ce983021"), new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"), new Guid("a2d2a23e-5d46-4bca-a018-0ea676fdf2b6") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("58830584-f650-4def-834b-38101d98537b"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("ee936e18-f4b9-4894-b709-4db7c551f88a"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("a4174b7c-6313-40dc-9551-abfb04470350"), new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"), new Guid("68fad250-947e-417d-ab6b-12762196ddfa") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5"), new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949"), new Guid("68fad250-947e-417d-ab6b-12762196ddfa") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("30957a4c-3c7e-4e13-98bd-cd53c948dd4f"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("9bde2d10-bda4-489b-8630-9267ec02c1da"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("b93f690d-44b9-423f-938f-d0835245dc21"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("f3d6f56c-61f8-4cbe-81f4-9275791e682b"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("4d1e224f-bce3-4cde-82f5-6fd42e7536be"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("cd55bf1f-1e17-488e-a68f-90d0ce983021"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("a4174b7c-6313-40dc-9551-abfb04470350"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("dbfd0db7-7de1-421d-b948-244d65d69c4d"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("7ce36f74-c342-495f-a85c-d4002e3734b5"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("921e2bd4-ca65-49db-b1b4-b83d3eddf949"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("52a2dcbb-68c7-4e4c-bc23-cee4d49721c0"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("a2d2a23e-5d46-4bca-a018-0ea676fdf2b6"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("5ad0d62a-f7dc-451c-85df-61260b7c1238"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("68fad250-947e-417d-ab6b-12762196ddfa"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("15480db7-ecd2-4d1c-8931-b1c18e0c20d8"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("ed253fc7-350a-4a38-99b3-8f44bccd7fbb"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("9f65ca1a-7b12-4838-9519-b0248281e57f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScriptsInPlanTable_PlanTable_ScriptsInPlan_PlanId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_PlanId",
                principalTable: "PlanTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScriptsInPlanTable_ScriptTable_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlanTable",
                column: "ScriptsInPlan_ScriptId",
                principalTable: "ScriptTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

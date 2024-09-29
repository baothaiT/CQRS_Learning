using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("81dc9483-9d3c-49e1-9557-4b5a85d5497d"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"), new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"), new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"), new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"), new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("938343d9-2e8d-4b8b-8274-27e2aa6c9452"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("e32d1f38-a88a-4d96-8982-e235c7d2d81b"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"), new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"), new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("dff63ac0-810a-49a6-80bb-085986df2517"), new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"), new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("36b22dd7-9f06-4343-8b40-3bbb1cd7d021"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("9d02baf8-5da7-4f24-8ea3-396cacbb9a0f"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"), new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"), new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"), new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"), new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("dff63ac0-810a-49a6-80bb-085986df2517"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("1e96c5a0-1524-4269-8c22-bcd4cc38c19f"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("aa9e0449-1ba7-4551-b141-bc766096620c"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"));

            migrationBuilder.AddColumn<int>(
                name: "IsStatus",
                table: "ProxyTable",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("4c8d64d9-3bbd-404c-b604-caa23b54aae3"), false, 0 },
                    { new Guid("ce5f685b-8024-4e2a-ac75-024642866d3d"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("69e0aab6-3cf6-489c-9db8-1bd39bf682b7"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4156), 600m, false, false, "Name1", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("8758ec2c-ab61-4350-b5e5-ae84be6f3474"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4164), 600m, false, false, "Name2", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("30f77383-9425-4688-b016-e5bec2f1e128"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4390), false, 0, "Name1" },
                    { new Guid("61b61c01-5014-467e-ab3c-a22ce5d2f4bf"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4388), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4319), false, "Plan 1" },
                    { new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4320), false, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4224), new DateTime(2024, 10, 4, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4224), false, "Project2", new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4223) },
                    { new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 10, 4, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4217), false, "Project1", new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4216) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "IsStatus", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("31f5398c-0d74-4694-b2ac-0b0154572c94"), "192.168.1.7", false, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("8de5d7d9-9e8a-4a10-9295-aa1d201b3992"), "192.168.1.8", false, null, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("b6aa5c34-7756-48fc-a120-1b4e4fe2d681"), "192.168.1.6", false, null, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("8c4f01b0-7b8f-4ab9-84ee-7d10fe62793f"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4367), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4365), false, 0, 0, "Name1" },
                    { new Guid("ba25e0dc-cb6c-41d0-9f89-afea90937f67"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4369), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4369), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4270), false, "Script 1" },
                    { new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4271), false, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"), new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47"), false, null, null },
                    { new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"), new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0"), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4098), "User@example.com", false, true, "UserPass", new Guid("b6aa5c34-7756-48fc-a120-1b4e4fe2d681"), "User2", new Guid("ce5f685b-8024-4e2a-ac75-024642866d3d") },
                    { new Guid("efda896c-c4bf-42a8-a339-326afb2d1a39"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4100), "User@example.com", false, true, "UserPass", null, "User3", new Guid("ce5f685b-8024-4e2a-ac75-024642866d3d") },
                    { new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"), new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4084), "User@example.com", false, true, "UserPass", new Guid("b6aa5c34-7756-48fc-a120-1b4e4fe2d681"), "User1", new Guid("4c8d64d9-3bbd-404c-b604-caa23b54aae3") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("61b61c01-5014-467e-ab3c-a22ce5d2f4bf"), new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"), new Guid("8c4f01b0-7b8f-4ab9-84ee-7d10fe62793f"), false },
                    { new Guid("30f77383-9425-4688-b016-e5bec2f1e128"), new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"), new Guid("ba25e0dc-cb6c-41d0-9f89-afea90937f67"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc"), new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0"), false },
                    { new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c"), new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"), new Guid("8758ec2c-ab61-4350-b5e5-ae84be6f3474"), false },
                    { new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"), new Guid("69e0aab6-3cf6-489c-9db8-1bd39bf682b7"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"), new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc"), false },
                    { new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"), new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c"), false }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("aa2e0b29-5ec3-4b7f-8456-ee3f9053f39b"), 200, new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4128), false, "Message", new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2") },
                    { new Guid("f5a1abaf-84df-4b76-b3a6-b2f70977883d"), 200, new DateTime(2024, 9, 29, 23, 42, 14, 861, DateTimeKind.Local).AddTicks(4130), false, "Message", new Guid("e675c66c-7522-4a07-8354-2ef2fc557999") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("efda896c-c4bf-42a8-a339-326afb2d1a39"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"), new Guid("8758ec2c-ab61-4350-b5e5-ae84be6f3474") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowserTable",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"), new Guid("69e0aab6-3cf6-489c-9db8-1bd39bf682b7") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"), new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc") });

            migrationBuilder.DeleteData(
                table: "AccountsInProjectTable",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"), new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c") });

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("aa2e0b29-5ec3-4b7f-8456-ee3f9053f39b"));

            migrationBuilder.DeleteData(
                table: "LogsTable",
                keyColumn: "Id",
                keyValue: new Guid("f5a1abaf-84df-4b76-b3a6-b2f70977883d"));

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("61b61c01-5014-467e-ab3c-a22ce5d2f4bf"), new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"), new Guid("8c4f01b0-7b8f-4ab9-84ee-7d10fe62793f") });

            migrationBuilder.DeleteData(
                table: "PlansInScheduleTable",
                keyColumns: new[] { "DeviceId", "PlanId", "ScheduleId" },
                keyValues: new object[] { new Guid("30f77383-9425-4688-b016-e5bec2f1e128"), new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"), new Guid("ba25e0dc-cb6c-41d0-9f89-afea90937f67") });

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("31f5398c-0d74-4694-b2ac-0b0154572c94"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("8de5d7d9-9e8a-4a10-9295-aa1d201b3992"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"), new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlanTable",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"), new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc"), new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProjectTable",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c"), new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47") });

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("e675c66c-7522-4a07-8354-2ef2fc557999"));

            migrationBuilder.DeleteData(
                table: "AccountTable",
                keyColumn: "Id",
                keyValue: new Guid("fc1fd6b6-a288-42f2-ada3-f73420de75f2"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("69e0aab6-3cf6-489c-9db8-1bd39bf682b7"));

            migrationBuilder.DeleteData(
                table: "BrowserTable",
                keyColumn: "Id",
                keyValue: new Guid("8758ec2c-ab61-4350-b5e5-ae84be6f3474"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("30f77383-9425-4688-b016-e5bec2f1e128"));

            migrationBuilder.DeleteData(
                table: "DevicesTable",
                keyColumn: "Id",
                keyValue: new Guid("61b61c01-5014-467e-ab3c-a22ce5d2f4bf"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("5d883040-92c3-485d-8096-5b7d5dfc1544"));

            migrationBuilder.DeleteData(
                table: "PlanTable",
                keyColumn: "Id",
                keyValue: new Guid("b4ef3cb9-6bc0-4b24-8569-33528f68fdc8"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("240ebeaa-090f-4cbb-aab7-c9f2cd70abbc"));

            migrationBuilder.DeleteData(
                table: "ProjectTable",
                keyColumn: "Id",
                keyValue: new Guid("eb3f5d7d-175e-4ad3-883a-76639c992d7c"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("8c4f01b0-7b8f-4ab9-84ee-7d10fe62793f"));

            migrationBuilder.DeleteData(
                table: "ScheduleTable",
                keyColumn: "Id",
                keyValue: new Guid("ba25e0dc-cb6c-41d0-9f89-afea90937f67"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("24e1d810-6a5e-4b66-927c-84ddfaa6de47"));

            migrationBuilder.DeleteData(
                table: "ScriptTable",
                keyColumn: "Id",
                keyValue: new Guid("ab5978b3-1aeb-46b5-b9c3-2187fa2209e0"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("4c8d64d9-3bbd-404c-b604-caa23b54aae3"));

            migrationBuilder.DeleteData(
                table: "AccountTypeTable",
                keyColumn: "Id",
                keyValue: new Guid("ce5f685b-8024-4e2a-ac75-024642866d3d"));

            migrationBuilder.DeleteData(
                table: "ProxyTable",
                keyColumn: "Id",
                keyValue: new Guid("b6aa5c34-7756-48fc-a120-1b4e4fe2d681"));

            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "ProxyTable");

            migrationBuilder.InsertData(
                table: "AccountTypeTable",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1e96c5a0-1524-4269-8c22-bcd4cc38c19f"), false, 0 },
                    { new Guid("aa9e0449-1ba7-4551-b141-bc766096620c"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "BrowserTable",
                columns: new[] { "Id", "CreateDate", "HightScreen", "IsDelete", "IsStatus", "Name", "Path", "Scale", "UserAgent", "WithScreeen", "XPosition", "YPosition" },
                values: new object[,]
                {
                    { new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6743), 600m, false, false, "Name2", "Path", 50m, "", 400m, 160m, 50m },
                    { new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6734), 600m, false, false, "Name1", "Path", 50m, "", 400m, 160m, 50m }
                });

            migrationBuilder.InsertData(
                table: "DevicesTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(7005), false, 0, "Name1" },
                    { new Guid("dff63ac0-810a-49a6-80bb-085986df2517"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(7004), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "PlanTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6932), false, "Plan 2" },
                    { new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6930), false, "Plan 1" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTable",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 10, 3, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6804), false, "Project1", new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6803) },
                    { new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 10, 3, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6812), false, "Project2", new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6811) }
                });

            migrationBuilder.InsertData(
                table: "ProxyTable",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"), "192.168.1.6", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("36b22dd7-9f06-4343-8b40-3bbb1cd7d021"), "192.168.1.7", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("9d02baf8-5da7-4f24-8ea3-396cacbb9a0f"), "192.168.1.8", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "ScheduleTable",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6980), false, 0, 0, "Name1" },
                    { new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6977), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptTable",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6871), false, "Script 2" },
                    { new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6870), false, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlanTable",
                columns: new[] { "PlanId", "ScriptId", "IsDelete", "ScriptsInPlan_PlanId", "ScriptsInPlan_ScriptId" },
                values: new object[,]
                {
                    { new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"), new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"), false, null, null },
                    { new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"), new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AccountTable",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("81dc9483-9d3c-49e1-9557-4b5a85d5497d"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6654), "User@example.com", false, true, "UserPass", null, "User3", new Guid("aa9e0449-1ba7-4551-b141-bc766096620c") },
                    { new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6652), "User@example.com", false, true, "UserPass", new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"), "User2", new Guid("aa9e0449-1ba7-4551-b141-bc766096620c") },
                    { new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"), new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6487), "User@example.com", false, true, "UserPass", new Guid("06e4ccbf-77d4-4ff2-9002-23c9749a7521"), "User1", new Guid("1e96c5a0-1524-4269-8c22-bcd4cc38c19f") }
                });

            migrationBuilder.InsertData(
                table: "PlansInScheduleTable",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("bc1234ba-8656-45e4-a0ce-b0191af17dbd"), new Guid("5910cb0a-7a84-45bc-94bd-bdefd3aa061a"), new Guid("7e5e5bdd-0500-4c65-b1c4-370e8ac98117"), false },
                    { new Guid("dff63ac0-810a-49a6-80bb-085986df2517"), new Guid("86cf482d-221b-473e-9dde-55fed5cfdb86"), new Guid("bd89777d-57e5-4a67-8942-121e72b4cff2"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProjectTable",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"), new Guid("b6d63d30-3e24-4b86-ba58-8810fcd82751"), false },
                    { new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"), new Guid("985bad44-e8b3-42ba-96e5-cdaa22185143"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowserTable",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"), new Guid("2a2dd33e-21f6-4dae-baa6-e4548610996a"), false },
                    { new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"), new Guid("58f82d47-7ef0-4c01-8028-7b86d10b70a2"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProjectTable",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4"), new Guid("e7cfd962-1c04-442f-8dd8-6b35b3e591cd"), false },
                    { new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea"), new Guid("03f32fcf-aa52-455f-9855-cdf3729f39fd"), false }
                });

            migrationBuilder.InsertData(
                table: "LogsTable",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("938343d9-2e8d-4b8b-8274-27e2aa6c9452"), 200, new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6697), false, "Message", new Guid("fdacb69a-01a5-4bdf-961c-79b4189f14ea") },
                    { new Guid("e32d1f38-a88a-4d96-8982-e235c7d2d81b"), 200, new DateTime(2024, 9, 28, 15, 7, 5, 320, DateTimeKind.Local).AddTicks(6698), false, "Message", new Guid("e7f95096-02e3-438d-8be7-2986504b2fa4") }
                });
        }
    }
}

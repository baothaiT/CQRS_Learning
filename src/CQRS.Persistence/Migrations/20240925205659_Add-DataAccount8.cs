using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("481ca6ae-7bf0-463a-880b-ae034ba1370c"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"), new Guid("4de10ec1-25bf-4b48-9a90-5ba7a581fd9f") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"), new Guid("f5913811-3cb2-46a1-9d5d-af0eadad23a6") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"), new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"), new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("6a50aa70-b298-4a64-9069-a93e18251442"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("8ec533bb-1300-4044-ad5d-c2cab914169a"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("7cebd2f5-0caf-4283-a3b2-efe8d998ec7a"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlan",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("05ad3862-0943-4884-a9a6-5662bf35ffa9"), new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlan",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("0906bdcd-1a6d-40bc-9e85-69dc3fbfa967"), new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0"), new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81"), new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("4de10ec1-25bf-4b48-9a90-5ba7a581fd9f"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("f5913811-3cb2-46a1-9d5d-af0eadad23a6"));

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("05ad3862-0943-4884-a9a6-5662bf35ffa9"));

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("0906bdcd-1a6d-40bc-9e85-69dc3fbfa967"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("7638800c-d4a3-49b4-8003-61c0c60f2270"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("aabb23a1-921d-4b5a-b902-9f50190fee10"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("63445160-0ae1-434b-8fdb-f3dc3f260742"));

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRun = table.Column<int>(type: "int", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlansInSchedule",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansInSchedule", x => new { x.ScheduleId, x.DeviceId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("5e323159-17b5-4c04-ac88-1c50d0077334"), false, 1 },
                    { new Guid("afdd66c7-4c45-4ae6-ba79-61b22b9025b6"), false, 0 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("8ae12057-c120-443b-8bec-4d6f96d477c9"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9130), false, false, "Name1", "Path" },
                    { new Guid("f5ffda0d-d93c-41d8-b768-78551c592248"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9131), false, false, "Name2", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("4d97257f-da22-460f-a092-d548d35db69e"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9322), false, 0, "Name1" },
                    { new Guid("e1c48963-818e-4c38-8fa8-2bb7c5e4b9ec"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9321), false, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("5e74b30e-687c-421a-99c8-c76e5be8bfe5"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9261), false, "Plan 1" },
                    { new Guid("8dc052cd-035c-4b7b-bfe9-64a9968fe586"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9263), false, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9178), new DateTime(2024, 10, 1, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9177), false, "Project2", new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9177) },
                    { new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 10, 1, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9169), false, "Project1", new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9168) }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("2a84d509-2bf2-4445-9c1c-e8855969fb4c"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("6578974f-b219-44ac-bfaa-8d1481c69ffa"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "CreateDate", "DateTimeStart", "IsDelete", "IsRun", "IsStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("4cb4e482-1b61-403e-9336-678de45de1fe"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9299), false, 0, 0, "Name1" },
                    { new Guid("85b7cf63-a05a-4345-a72c-2602d66087c8"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9301), false, 0, 0, "Name1" }
                });

            migrationBuilder.InsertData(
                table: "Script",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("ad49a07c-f442-433e-8666-a51b5ac95026"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9220), false, "Script 2" },
                    { new Guid("d70b2067-9345-4225-8a81-132a70ec8d70"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9218), false, "Script 1" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9063), "User@example.com", false, true, "UserPass", new Guid("6578974f-b219-44ac-bfaa-8d1481c69ffa"), "User1", new Guid("afdd66c7-4c45-4ae6-ba79-61b22b9025b6") },
                    { new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9077), "User@example.com", false, true, "UserPass", new Guid("6578974f-b219-44ac-bfaa-8d1481c69ffa"), "User2", new Guid("5e323159-17b5-4c04-ac88-1c50d0077334") },
                    { new Guid("ee071123-2105-4a3c-adc6-47687883d722"), new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9080), "User@example.com", false, true, "UserPass", null, "User3", new Guid("5e323159-17b5-4c04-ac88-1c50d0077334") }
                });

            migrationBuilder.InsertData(
                table: "PlansInSchedule",
                columns: new[] { "DeviceId", "PlanId", "ScheduleId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("e1c48963-818e-4c38-8fa8-2bb7c5e4b9ec"), new Guid("5e74b30e-687c-421a-99c8-c76e5be8bfe5"), new Guid("4cb4e482-1b61-403e-9336-678de45de1fe"), false },
                    { new Guid("4d97257f-da22-460f-a092-d548d35db69e"), new Guid("8dc052cd-035c-4b7b-bfe9-64a9968fe586"), new Guid("85b7cf63-a05a-4345-a72c-2602d66087c8"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlan",
                columns: new[] { "PlanId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("5e74b30e-687c-421a-99c8-c76e5be8bfe5"), new Guid("d70b2067-9345-4225-8a81-132a70ec8d70"), false },
                    { new Guid("8dc052cd-035c-4b7b-bfe9-64a9968fe586"), new Guid("ad49a07c-f442-433e-8666-a51b5ac95026"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProject",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9"), new Guid("ad49a07c-f442-433e-8666-a51b5ac95026"), false },
                    { new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7"), new Guid("d70b2067-9345-4225-8a81-132a70ec8d70"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"), new Guid("8ae12057-c120-443b-8bec-4d6f96d477c9"), false },
                    { new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"), new Guid("f5ffda0d-d93c-41d8-b768-78551c592248"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProject",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"), new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7"), false },
                    { new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"), new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("38e236ba-fda2-4784-b379-4678ac7f3a42"), 200, new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9101), false, "Message", new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215") },
                    { new Guid("67b72649-c877-45a5-b088-286d31c6ef54"), 200, new DateTime(2024, 9, 26, 3, 56, 57, 977, DateTimeKind.Local).AddTicks(9104), false, "Message", new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlansInSchedule_DeviceId",
                table: "PlansInSchedule",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlansInSchedule_PlanId",
                table: "PlansInSchedule",
                column: "PlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlansInSchedule");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("ee071123-2105-4a3c-adc6-47687883d722"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"), new Guid("8ae12057-c120-443b-8bec-4d6f96d477c9") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"), new Guid("f5ffda0d-d93c-41d8-b768-78551c592248") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"), new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"), new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("38e236ba-fda2-4784-b379-4678ac7f3a42"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("67b72649-c877-45a5-b088-286d31c6ef54"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("2a84d509-2bf2-4445-9c1c-e8855969fb4c"));

            migrationBuilder.DeleteData(
                table: "ScriptsInPlan",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("5e74b30e-687c-421a-99c8-c76e5be8bfe5"), new Guid("d70b2067-9345-4225-8a81-132a70ec8d70") });

            migrationBuilder.DeleteData(
                table: "ScriptsInPlan",
                keyColumns: new[] { "PlanId", "ScriptId" },
                keyValues: new object[] { new Guid("8dc052cd-035c-4b7b-bfe9-64a9968fe586"), new Guid("ad49a07c-f442-433e-8666-a51b5ac95026") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9"), new Guid("ad49a07c-f442-433e-8666-a51b5ac95026") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7"), new Guid("d70b2067-9345-4225-8a81-132a70ec8d70") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("6bf5ea3e-c72c-4ec2-9506-f5e4894b2215"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("7d05bb3a-a0f6-44c4-b2d8-86bb59530e3b"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("8ae12057-c120-443b-8bec-4d6f96d477c9"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("f5ffda0d-d93c-41d8-b768-78551c592248"));

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("5e74b30e-687c-421a-99c8-c76e5be8bfe5"));

            migrationBuilder.DeleteData(
                table: "Plan",
                keyColumn: "Id",
                keyValue: new Guid("8dc052cd-035c-4b7b-bfe9-64a9968fe586"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("390c9fc7-ddb9-4797-9c7d-e935f6fc06a9"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("65e3db6b-d09c-4b3a-b39d-4d1132bd1ba7"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("ad49a07c-f442-433e-8666-a51b5ac95026"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("d70b2067-9345-4225-8a81-132a70ec8d70"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("5e323159-17b5-4c04-ac88-1c50d0077334"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("afdd66c7-4c45-4ae6-ba79-61b22b9025b6"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("6578974f-b219-44ac-bfaa-8d1481c69ffa"));

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("7638800c-d4a3-49b4-8003-61c0c60f2270"), false, 0 },
                    { new Guid("aabb23a1-921d-4b5a-b902-9f50190fee10"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("4de10ec1-25bf-4b48-9a90-5ba7a581fd9f"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(411), false, false, "Name2", "Path" },
                    { new Guid("f5913811-3cb2-46a1-9d5d-af0eadad23a6"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(409), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Plan",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("05ad3862-0943-4884-a9a6-5662bf35ffa9"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(578), false, "Plan 1" },
                    { new Guid("0906bdcd-1a6d-40bc-9e85-69dc3fbfa967"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(579), false, "Plan 2" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(488), new DateTime(2024, 10, 1, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(487), false, "Project2", new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(486) },
                    { new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 10, 1, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(480), false, "Project1", new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(479) }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("63445160-0ae1-434b-8fdb-f3dc3f260742"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("7cebd2f5-0caf-4283-a3b2-efe8d998ec7a"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "Script",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(533), false, "Script 1" },
                    { new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(534), false, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("481ca6ae-7bf0-463a-880b-ae034ba1370c"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(357), "User@example.com", false, true, "UserPass", null, "User3", new Guid("aabb23a1-921d-4b5a-b902-9f50190fee10") },
                    { new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(356), "User@example.com", false, true, "UserPass", new Guid("63445160-0ae1-434b-8fdb-f3dc3f260742"), "User2", new Guid("aabb23a1-921d-4b5a-b902-9f50190fee10") },
                    { new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"), new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(345), "User@example.com", false, true, "UserPass", new Guid("63445160-0ae1-434b-8fdb-f3dc3f260742"), "User1", new Guid("7638800c-d4a3-49b4-8003-61c0c60f2270") }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInPlan",
                columns: new[] { "PlanId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("05ad3862-0943-4884-a9a6-5662bf35ffa9"), new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45"), false },
                    { new Guid("0906bdcd-1a6d-40bc-9e85-69dc3fbfa967"), new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea"), false }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProject",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0"), new Guid("d19acd0c-c197-4de2-ba54-29fcfe63a8ea"), false },
                    { new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81"), new Guid("615aaeb1-2f8d-41e1-8abe-15b72df8cc45"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"), new Guid("4de10ec1-25bf-4b48-9a90-5ba7a581fd9f"), false },
                    { new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"), new Guid("f5913811-3cb2-46a1-9d5d-af0eadad23a6"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProject",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288"), new Guid("3d2d800c-fcb4-4da5-a138-1499437a75a0"), false },
                    { new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628"), new Guid("ca098303-b8fa-4e4e-9fc7-92145364ed81"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("6a50aa70-b298-4a64-9069-a93e18251442"), 200, new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(383), false, "Message", new Guid("b1c37213-43ab-49d0-8a50-b00ac36fc628") },
                    { new Guid("8ec533bb-1300-4044-ad5d-c2cab914169a"), 200, new DateTime(2024, 9, 26, 3, 43, 6, 479, DateTimeKind.Local).AddTicks(385), false, "Message", new Guid("871845eb-fecc-4ccf-acf2-1b4968f39288") }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a57f53fa-01b3-4c3e-b971-2c98f32f27ef"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"), new Guid("00685fc1-ee62-48d1-b3de-c4d656c28f56") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"), new Guid("7bc6d9a0-4133-4e41-bb55-4889cda0963b") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"), new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"), new Guid("08552e0b-bfc4-4549-ade5-47080c53436d") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("1b91a64e-cefc-4007-a2e5-cf75ace2fd5f"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("59c3af7a-1832-47ba-a9b1-7e49ce1ac3ed"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("d9b50a6e-cf9e-488d-b015-f02f7bbcc6f6"));

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("08552e0b-bfc4-4549-ade5-47080c53436d"), new Guid("6207b114-be2d-40f3-86e2-91c3425ce058") });

            migrationBuilder.DeleteData(
                table: "ScriptsInProject",
                keyColumns: new[] { "ProjectId", "ScriptId" },
                keyValues: new object[] { new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29"), new Guid("83f49bae-dc7d-44ff-95b4-7cd8dcec719b") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("00685fc1-ee62-48d1-b3de-c4d656c28f56"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("7bc6d9a0-4133-4e41-bb55-4889cda0963b"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("08552e0b-bfc4-4549-ade5-47080c53436d"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("6207b114-be2d-40f3-86e2-91c3425ce058"));

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: new Guid("83f49bae-dc7d-44ff-95b4-7cd8dcec719b"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("47acab9c-3983-48b5-8d97-0a5486060f8d"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("ec6637d2-3251-48b1-859c-3c165ad14564"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("5ad35617-07ae-4ed2-b7db-5069c969ba64"));

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInPlan",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInPlan", x => new { x.PlanId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInPlan_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScriptsInPlan_Script_ScriptId",
                        column: x => x.ScriptId,
                        principalTable: "Script",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlan",
                column: "ScriptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScriptsInPlan");

            migrationBuilder.DropTable(
                name: "Plan");

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

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("47acab9c-3983-48b5-8d97-0a5486060f8d"), false, 0 },
                    { new Guid("ec6637d2-3251-48b1-859c-3c165ad14564"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("00685fc1-ee62-48d1-b3de-c4d656c28f56"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8380), false, false, "Name2", "Path" },
                    { new Guid("7bc6d9a0-4133-4e41-bb55-4889cda0963b"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8378), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("08552e0b-bfc4-4549-ade5-47080c53436d"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8429), new DateTime(2024, 10, 1, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8424), false, "Project1", new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8423) },
                    { new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 10, 1, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8432), false, "Project2", new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8431) }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("5ad35617-07ae-4ed2-b7db-5069c969ba64"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("d9b50a6e-cf9e-488d-b015-f02f7bbcc6f6"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "Script",
                columns: new[] { "Id", "CreateDate", "IsDelete", "Name" },
                values: new object[,]
                {
                    { new Guid("6207b114-be2d-40f3-86e2-91c3425ce058"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8516), false, "Script 1" },
                    { new Guid("83f49bae-dc7d-44ff-95b4-7cd8dcec719b"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8517), false, "Script 2" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8320), "User@example.com", false, true, "UserPass", new Guid("5ad35617-07ae-4ed2-b7db-5069c969ba64"), "User2", new Guid("ec6637d2-3251-48b1-859c-3c165ad14564") },
                    { new Guid("a57f53fa-01b3-4c3e-b971-2c98f32f27ef"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8322), "User@example.com", false, true, "UserPass", null, "User3", new Guid("ec6637d2-3251-48b1-859c-3c165ad14564") },
                    { new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"), new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8309), "User@example.com", false, true, "UserPass", new Guid("5ad35617-07ae-4ed2-b7db-5069c969ba64"), "User1", new Guid("47acab9c-3983-48b5-8d97-0a5486060f8d") }
                });

            migrationBuilder.InsertData(
                table: "ScriptsInProject",
                columns: new[] { "ProjectId", "ScriptId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("08552e0b-bfc4-4549-ade5-47080c53436d"), new Guid("6207b114-be2d-40f3-86e2-91c3425ce058"), false },
                    { new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29"), new Guid("83f49bae-dc7d-44ff-95b4-7cd8dcec719b"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"), new Guid("00685fc1-ee62-48d1-b3de-c4d656c28f56"), false },
                    { new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"), new Guid("7bc6d9a0-4133-4e41-bb55-4889cda0963b"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProject",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d"), new Guid("237cb61a-3a63-4191-b30f-cbdc45d55b29"), false },
                    { new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66"), new Guid("08552e0b-bfc4-4549-ade5-47080c53436d"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("1b91a64e-cefc-4007-a2e5-cf75ace2fd5f"), 200, new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8355), false, "Message", new Guid("0d86f0c6-3778-41ad-bec8-059ea247f76d") },
                    { new Guid("59c3af7a-1832-47ba-a9b1-7e49ce1ac3ed"), 200, new DateTime(2024, 9, 26, 3, 38, 17, 289, DateTimeKind.Local).AddTicks(8353), false, "Message", new Guid("ec6e9679-d6c8-4846-963b-12a04ddbef66") }
                });
        }
    }
}

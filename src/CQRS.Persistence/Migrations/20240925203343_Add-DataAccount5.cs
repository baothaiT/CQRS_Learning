using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("7629e68c-cbec-4730-8b9f-7ade89f286fa"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("2e266d80-e354-45b4-a9f9-db5070214c34"), new Guid("fab261ec-6158-4fb0-a829-26b3cc3246cc") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("ce15b268-c1de-4c0f-b76e-cfd56c9149bb"), new Guid("67e2da50-3dc6-445d-9c12-c7cdb37b659e") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("2a86d50e-fd82-4346-a5c9-38bca5452111"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("bf7c6c2c-67b0-4c73-8804-585e0aeed2e6"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("2715b1e3-f3a0-4c64-b05d-0598b23a9082"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2e266d80-e354-45b4-a9f9-db5070214c34"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("ce15b268-c1de-4c0f-b76e-cfd56c9149bb"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("67e2da50-3dc6-445d-9c12-c7cdb37b659e"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("fab261ec-6158-4fb0-a829-26b3cc3246cc"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("6f273958-97ca-4e11-a493-23fc9e14d065"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("acbb179c-5fb3-4682-8fa7-c37704fdd1cc"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("12910082-9a29-4f25-be7a-39fc819f6b90"));

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Script",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Script", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsInProject",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsInProject", x => new { x.AccountId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_AccountsInProject_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsInProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInProject",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInProject", x => new { x.ProjectId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScriptsInProject_Script_ScriptId",
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
                    { new Guid("4796f13e-8f80-445a-94b8-e24a010b21a7"), false, 0 },
                    { new Guid("980bb4a5-1524-473c-865e-17d09b367793"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("0d2568ec-54ab-40ed-b181-08b0107306e8"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6820), false, false, "Name2", "Path" },
                    { new Guid("5b1f197f-aedd-40bb-81cd-f270f874cadd"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6818), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "EndDate", "IsDelete", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("56a33d24-ab91-4cd3-8230-015c28d56524"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 10, 1, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6866), false, "Project2", new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6865) },
                    { new Guid("7218aa30-241f-4564-a51b-d2c53ca4709e"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 10, 1, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6859), false, "Project1", new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6858) }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("6f0c62d5-81fb-4732-b683-d7314d115cf7"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("fe6d5e26-c9a8-430e-bf2e-4e2de368eca7"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("2db2b8ac-69e3-485e-b5d7-00f628129477"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6755), "User@example.com", false, true, "UserPass", null, "User3", new Guid("980bb4a5-1524-473c-865e-17d09b367793") },
                    { new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6741), "User@example.com", false, true, "UserPass", new Guid("6f0c62d5-81fb-4732-b683-d7314d115cf7"), "User1", new Guid("4796f13e-8f80-445a-94b8-e24a010b21a7") },
                    { new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"), new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6753), "User@example.com", false, true, "UserPass", new Guid("6f0c62d5-81fb-4732-b683-d7314d115cf7"), "User2", new Guid("980bb4a5-1524-473c-865e-17d09b367793") }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"), new Guid("5b1f197f-aedd-40bb-81cd-f270f874cadd"), false },
                    { new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"), new Guid("0d2568ec-54ab-40ed-b181-08b0107306e8"), false }
                });

            migrationBuilder.InsertData(
                table: "AccountsInProject",
                columns: new[] { "AccountId", "ProjectId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"), new Guid("7218aa30-241f-4564-a51b-d2c53ca4709e"), false },
                    { new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"), new Guid("56a33d24-ab91-4cd3-8230-015c28d56524"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("5f2fec20-2628-4ff4-a585-24e9bff5bc24"), 200, new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6795), false, "Message", new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b") },
                    { new Guid("bbb4375b-50e9-478d-8325-119cc650186b"), 200, new DateTime(2024, 9, 26, 3, 33, 43, 485, DateTimeKind.Local).AddTicks(6798), false, "Message", new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInProject_ProjectId",
                table: "AccountsInProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInProject_ScriptId",
                table: "ScriptsInProject",
                column: "ScriptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsInProject");

            migrationBuilder.DropTable(
                name: "ScriptsInProject");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Script");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2db2b8ac-69e3-485e-b5d7-00f628129477"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"), new Guid("5b1f197f-aedd-40bb-81cd-f270f874cadd") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"), new Guid("0d2568ec-54ab-40ed-b181-08b0107306e8") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("5f2fec20-2628-4ff4-a585-24e9bff5bc24"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("bbb4375b-50e9-478d-8325-119cc650186b"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("fe6d5e26-c9a8-430e-bf2e-4e2de368eca7"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("0d2568ec-54ab-40ed-b181-08b0107306e8"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("5b1f197f-aedd-40bb-81cd-f270f874cadd"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("4796f13e-8f80-445a-94b8-e24a010b21a7"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("980bb4a5-1524-473c-865e-17d09b367793"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("6f0c62d5-81fb-4732-b683-d7314d115cf7"));

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("6f273958-97ca-4e11-a493-23fc9e14d065"), false, 0 },
                    { new Guid("acbb179c-5fb3-4682-8fa7-c37704fdd1cc"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("67e2da50-3dc6-445d-9c12-c7cdb37b659e"), new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(154), false, false, "Name2", "Path" },
                    { new Guid("fab261ec-6158-4fb0-a829-26b3cc3246cc"), new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(153), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("12910082-9a29-4f25-be7a-39fc819f6b90"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("2715b1e3-f3a0-4c64-b05d-0598b23a9082"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("2e266d80-e354-45b4-a9f9-db5070214c34"), new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(87), "User@example.com", false, true, "UserPass", new Guid("12910082-9a29-4f25-be7a-39fc819f6b90"), "User1", new Guid("6f273958-97ca-4e11-a493-23fc9e14d065") },
                    { new Guid("7629e68c-cbec-4730-8b9f-7ade89f286fa"), new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(102), "User@example.com", false, true, "UserPass", null, "User3", new Guid("acbb179c-5fb3-4682-8fa7-c37704fdd1cc") },
                    { new Guid("ce15b268-c1de-4c0f-b76e-cfd56c9149bb"), new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(100), "User@example.com", false, true, "UserPass", new Guid("12910082-9a29-4f25-be7a-39fc819f6b90"), "User2", new Guid("acbb179c-5fb3-4682-8fa7-c37704fdd1cc") }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("2e266d80-e354-45b4-a9f9-db5070214c34"), new Guid("fab261ec-6158-4fb0-a829-26b3cc3246cc"), false },
                    { new Guid("ce15b268-c1de-4c0f-b76e-cfd56c9149bb"), new Guid("67e2da50-3dc6-445d-9c12-c7cdb37b659e"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2a86d50e-fd82-4346-a5c9-38bca5452111"), 200, new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(133), false, "Message", new Guid("ce15b268-c1de-4c0f-b76e-cfd56c9149bb") },
                    { new Guid("bf7c6c2c-67b0-4c73-8804-585e0aeed2e6"), 200, new DateTime(2024, 9, 26, 3, 24, 19, 222, DateTimeKind.Local).AddTicks(131), false, "Message", new Guid("2e266d80-e354-45b4-a9f9-db5070214c34") }
                });
        }
    }
}

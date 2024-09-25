using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("77623404-5777-4bd5-82cd-3b3d448cf01b"), new Guid("7218aa30-241f-4564-a51b-d2c53ca4709e") });

            migrationBuilder.DeleteData(
                table: "AccountsInProject",
                keyColumns: new[] { "AccountId", "ProjectId" },
                keyValues: new object[] { new Guid("7f01d006-4785-4509-9eac-1f2eef3dea91"), new Guid("56a33d24-ab91-4cd3-8230-015c28d56524") });

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
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("56a33d24-ab91-4cd3-8230-015c28d56524"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("7218aa30-241f-4564-a51b-d2c53ca4709e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cae94160-fab7-4de9-bb8f-08307fb15cfe"));

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("76df9643-4ecc-4c48-9f9f-894af12f3ca4"), new Guid("2b5ab9f0-780c-4fa4-b2f5-6e615d27d96e") });

            migrationBuilder.DeleteData(
                table: "AccountsInBrowser",
                keyColumns: new[] { "AccountId", "BrowserId" },
                keyValues: new object[] { new Guid("cf93fafa-e47e-4c76-ad0b-eb20a5376aa0"), new Guid("688825ca-7b79-44eb-907e-0760294d8d81") });

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("0ed3449e-44b7-4783-afeb-2fa8442b9fa1"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("742e2751-ee81-44f6-9997-d61fa52388fd"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("72b95702-01f9-44cd-8a17-e0af7939ea62"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("76df9643-4ecc-4c48-9f9f-894af12f3ca4"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cf93fafa-e47e-4c76-ad0b-eb20a5376aa0"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("2b5ab9f0-780c-4fa4-b2f5-6e615d27d96e"));

            migrationBuilder.DeleteData(
                table: "Browser",
                keyColumn: "Id",
                keyValue: new Guid("688825ca-7b79-44eb-907e-0760294d8d81"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("17354c4f-6a97-4d5d-b121-549564418e90"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("b37653f3-cf41-437e-9bdc-4271288c9018"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("10818ff5-8ded-4919-9764-ea85ace706fd"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Browser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Browser");

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("17354c4f-6a97-4d5d-b121-549564418e90"), false, 1 },
                    { new Guid("b37653f3-cf41-437e-9bdc-4271288c9018"), false, 0 }
                });

            migrationBuilder.InsertData(
                table: "Browser",
                columns: new[] { "Id", "IsDelete", "IsStatus", "Name", "Path" },
                values: new object[,]
                {
                    { new Guid("2b5ab9f0-780c-4fa4-b2f5-6e615d27d96e"), false, false, "Name2", "Path" },
                    { new Guid("688825ca-7b79-44eb-907e-0760294d8d81"), false, false, "Name1", "Path" }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("10818ff5-8ded-4919-9764-ea85ace706fd"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" },
                    { new Guid("72b95702-01f9-44cd-8a17-e0af7939ea62"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("76df9643-4ecc-4c48-9f9f-894af12f3ca4"), new DateTime(2024, 9, 26, 3, 21, 23, 235, DateTimeKind.Local).AddTicks(5303), "User@example.com", false, true, "UserPass", new Guid("10818ff5-8ded-4919-9764-ea85ace706fd"), "User2", new Guid("17354c4f-6a97-4d5d-b121-549564418e90") },
                    { new Guid("cae94160-fab7-4de9-bb8f-08307fb15cfe"), new DateTime(2024, 9, 26, 3, 21, 23, 235, DateTimeKind.Local).AddTicks(5305), "User@example.com", false, true, "UserPass", null, "User3", new Guid("17354c4f-6a97-4d5d-b121-549564418e90") },
                    { new Guid("cf93fafa-e47e-4c76-ad0b-eb20a5376aa0"), new DateTime(2024, 9, 26, 3, 21, 23, 235, DateTimeKind.Local).AddTicks(5291), "User@example.com", false, true, "UserPass", new Guid("10818ff5-8ded-4919-9764-ea85ace706fd"), "User1", new Guid("b37653f3-cf41-437e-9bdc-4271288c9018") }
                });

            migrationBuilder.InsertData(
                table: "AccountsInBrowser",
                columns: new[] { "AccountId", "BrowserId", "IsDelete" },
                values: new object[,]
                {
                    { new Guid("76df9643-4ecc-4c48-9f9f-894af12f3ca4"), new Guid("2b5ab9f0-780c-4fa4-b2f5-6e615d27d96e"), false },
                    { new Guid("cf93fafa-e47e-4c76-ad0b-eb20a5376aa0"), new Guid("688825ca-7b79-44eb-907e-0760294d8d81"), false }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("0ed3449e-44b7-4783-afeb-2fa8442b9fa1"), 200, new DateTime(2024, 9, 26, 3, 21, 23, 235, DateTimeKind.Local).AddTicks(5329), false, "Message", new Guid("cf93fafa-e47e-4c76-ad0b-eb20a5376aa0") },
                    { new Guid("742e2751-ee81-44f6-9997-d61fa52388fd"), 200, new DateTime(2024, 9, 26, 3, 21, 23, 235, DateTimeKind.Local).AddTicks(5330), false, "Message", new Guid("76df9643-4ecc-4c48-9f9f-894af12f3ca4") }
                });
        }
    }
}

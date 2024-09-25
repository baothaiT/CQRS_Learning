using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataForProxy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("2cf6ea4a-f17e-47e0-b913-03fb26be6ff7"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("c6c38870-9e22-4791-8eac-f15b1b9e66de"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("4fa0a7ab-de8c-4840-968a-7c7d17c0de19"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("883ca30d-4b53-4023-8ef9-894be95717a7"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("1cd166a8-4bd8-4c24-94f2-ee539b7e8572"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("275ba768-e7f1-4dab-9772-1551f5c6ff88"));

            migrationBuilder.AddColumn<Guid>(
                name: "Proxy",
                table: "Account",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Proxy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proxy", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1a40e727-1895-4753-a892-6ebf162068b3"), false, 0 },
                    { new Guid("85510140-e0fb-4151-aaed-f178eba5270c"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("f847c6a3-03a6-428c-9130-e314e3b75e06"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("94ee142d-675c-4c39-a71b-5d2fa86e5080"), new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7028), "User@example.com", false, true, "UserPass", new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"), "User2", new Guid("85510140-e0fb-4151-aaed-f178eba5270c") },
                    { new Guid("d6f35afb-aaf2-4f3e-bd80-001ce15f26cb"), new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7018), "User@example.com", false, true, "UserPass", new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"), "User1", new Guid("1a40e727-1895-4753-a892-6ebf162068b3") }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("1db53132-e23b-4356-b34e-fe28acc04e03"), 200, new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7051), false, "Message", new Guid("d6f35afb-aaf2-4f3e-bd80-001ce15f26cb") },
                    { new Guid("1fef23f3-ae9f-4462-9d06-9defedd76adb"), 200, new DateTime(2024, 9, 26, 3, 9, 27, 645, DateTimeKind.Local).AddTicks(7053), false, "Message", new Guid("94ee142d-675c-4c39-a71b-5d2fa86e5080") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Proxy",
                table: "Account",
                column: "Proxy");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Proxy_Proxy",
                table: "Account",
                column: "Proxy",
                principalTable: "Proxy",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Proxy_Proxy",
                table: "Account");

            migrationBuilder.DropTable(
                name: "Proxy");

            migrationBuilder.DropIndex(
                name: "IX_Account_Proxy",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("1db53132-e23b-4356-b34e-fe28acc04e03"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("1fef23f3-ae9f-4462-9d06-9defedd76adb"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("94ee142d-675c-4c39-a71b-5d2fa86e5080"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d6f35afb-aaf2-4f3e-bd80-001ce15f26cb"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("1a40e727-1895-4753-a892-6ebf162068b3"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("85510140-e0fb-4151-aaed-f178eba5270c"));

            migrationBuilder.DropColumn(
                name: "Proxy",
                table: "Account");

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("1cd166a8-4bd8-4c24-94f2-ee539b7e8572"), false, 0 },
                    { new Guid("275ba768-e7f1-4dab-9772-1551f5c6ff88"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("4fa0a7ab-de8c-4840-968a-7c7d17c0de19"), new DateTime(2024, 9, 26, 3, 2, 29, 555, DateTimeKind.Local).AddTicks(1373), "User@example.com", false, true, "UserPass", "User1", new Guid("1cd166a8-4bd8-4c24-94f2-ee539b7e8572") },
                    { new Guid("883ca30d-4b53-4023-8ef9-894be95717a7"), new DateTime(2024, 9, 26, 3, 2, 29, 555, DateTimeKind.Local).AddTicks(1387), "User@example.com", false, true, "UserPass", "User2", new Guid("275ba768-e7f1-4dab-9772-1551f5c6ff88") }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2cf6ea4a-f17e-47e0-b913-03fb26be6ff7"), 200, new DateTime(2024, 9, 26, 3, 2, 29, 555, DateTimeKind.Local).AddTicks(1414), false, "Message", new Guid("4fa0a7ab-de8c-4840-968a-7c7d17c0de19") },
                    { new Guid("c6c38870-9e22-4791-8eac-f15b1b9e66de"), 200, new DateTime(2024, 9, 26, 3, 2, 29, 555, DateTimeKind.Local).AddTicks(1415), false, "Message", new Guid("883ca30d-4b53-4023-8ef9-894be95717a7") }
                });
        }
    }
}

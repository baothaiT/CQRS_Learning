using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("1db53132-e23b-4356-b34e-fe28acc04e03"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("1fef23f3-ae9f-4462-9d06-9defedd76adb"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("f847c6a3-03a6-428c-9130-e314e3b75e06"));

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

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("f9ef2730-409f-4221-b53d-52972c151a1e"));

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("2d4951ad-5f9d-4fb6-b439-78a7ea60298d"), false, 1 },
                    { new Guid("d6d6a683-e809-4288-91f5-8d7d998cc9f7"), false, 0 }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("9c4fce14-1b3c-4ea7-b081-d60f42438fdb"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("ee7a7d5c-06d3-4940-a40c-8b0529b3c43f"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("0f5651c4-5532-4c07-a6dc-6e7637be0fed"), new DateTime(2024, 9, 26, 3, 10, 49, 116, DateTimeKind.Local).AddTicks(5620), "User@example.com", false, true, "UserPass", new Guid("ee7a7d5c-06d3-4940-a40c-8b0529b3c43f"), "User2", new Guid("2d4951ad-5f9d-4fb6-b439-78a7ea60298d") },
                    { new Guid("42b2091c-7c31-411c-a2b3-1e4c52bc643c"), new DateTime(2024, 9, 26, 3, 10, 49, 116, DateTimeKind.Local).AddTicks(5608), "User@example.com", false, true, "UserPass", new Guid("ee7a7d5c-06d3-4940-a40c-8b0529b3c43f"), "User1", new Guid("d6d6a683-e809-4288-91f5-8d7d998cc9f7") }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("42d67664-1c73-4184-99df-e00c95e1f6e0"), 200, new DateTime(2024, 9, 26, 3, 10, 49, 116, DateTimeKind.Local).AddTicks(5644), false, "Message", new Guid("0f5651c4-5532-4c07-a6dc-6e7637be0fed") },
                    { new Guid("a0bf6a04-6c70-4907-9cb9-04dad095b3fb"), 200, new DateTime(2024, 9, 26, 3, 10, 49, 116, DateTimeKind.Local).AddTicks(5642), false, "Message", new Guid("42b2091c-7c31-411c-a2b3-1e4c52bc643c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("42d67664-1c73-4184-99df-e00c95e1f6e0"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("a0bf6a04-6c70-4907-9cb9-04dad095b3fb"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("9c4fce14-1b3c-4ea7-b081-d60f42438fdb"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("0f5651c4-5532-4c07-a6dc-6e7637be0fed"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("42b2091c-7c31-411c-a2b3-1e4c52bc643c"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("2d4951ad-5f9d-4fb6-b439-78a7ea60298d"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("d6d6a683-e809-4288-91f5-8d7d998cc9f7"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("ee7a7d5c-06d3-4940-a40c-8b0529b3c43f"));

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
        }
    }
}

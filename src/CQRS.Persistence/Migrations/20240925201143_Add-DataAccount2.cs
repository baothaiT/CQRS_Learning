using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0f0527c7-7e4b-4315-b1fc-ddf7f00edc8f"), false, 0 },
                    { new Guid("56b0abaf-4e43-41c2-ace0-d507b1a1edf9"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("5dc9a98e-b936-4051-838c-800e1f70ae3c"), "192.168.1.2", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("c7d9a3b6-3ee7-467d-af2d-3c69561ba4a2"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("18a21c54-887e-42ee-adbd-4ff2b7e0df38"), new DateTime(2024, 9, 26, 3, 11, 43, 569, DateTimeKind.Local).AddTicks(1705), "User@example.com", false, true, "UserPass", new Guid("c7d9a3b6-3ee7-467d-af2d-3c69561ba4a2"), "User2", new Guid("56b0abaf-4e43-41c2-ace0-d507b1a1edf9") },
                    { new Guid("27625528-71d8-4635-ac5b-878a689ff24e"), new DateTime(2024, 9, 26, 3, 11, 43, 569, DateTimeKind.Local).AddTicks(1693), "User@example.com", false, true, "UserPass", new Guid("c7d9a3b6-3ee7-467d-af2d-3c69561ba4a2"), "User1", new Guid("0f0527c7-7e4b-4315-b1fc-ddf7f00edc8f") },
                    { new Guid("6a1a2e95-fffd-49e4-a2a0-0bd6c05500a3"), new DateTime(2024, 9, 26, 3, 11, 43, 569, DateTimeKind.Local).AddTicks(1707), "User@example.com", false, true, "UserPass", null, "User3", new Guid("56b0abaf-4e43-41c2-ace0-d507b1a1edf9") }
                });

            migrationBuilder.InsertData(
                table: "Logs",
                columns: new[] { "Id", "Code", "CreateDate", "IsDelete", "Message", "User" },
                values: new object[,]
                {
                    { new Guid("2a394ff9-62a4-4404-a909-bf07c8ebc57a"), 200, new DateTime(2024, 9, 26, 3, 11, 43, 569, DateTimeKind.Local).AddTicks(1730), false, "Message", new Guid("27625528-71d8-4635-ac5b-878a689ff24e") },
                    { new Guid("edf444b0-4c24-4d4f-a974-f3a8151a1e2c"), 200, new DateTime(2024, 9, 26, 3, 11, 43, 569, DateTimeKind.Local).AddTicks(1732), false, "Message", new Guid("18a21c54-887e-42ee-adbd-4ff2b7e0df38") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("6a1a2e95-fffd-49e4-a2a0-0bd6c05500a3"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("2a394ff9-62a4-4404-a909-bf07c8ebc57a"));

            migrationBuilder.DeleteData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: new Guid("edf444b0-4c24-4d4f-a974-f3a8151a1e2c"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("5dc9a98e-b936-4051-838c-800e1f70ae3c"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("18a21c54-887e-42ee-adbd-4ff2b7e0df38"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("27625528-71d8-4635-ac5b-878a689ff24e"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("0f0527c7-7e4b-4315-b1fc-ddf7f00edc8f"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("56b0abaf-4e43-41c2-ace0-d507b1a1edf9"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("c7d9a3b6-3ee7-467d-af2d-3c69561ba4a2"));

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
    }
}

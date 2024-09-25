using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataForLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("764e371f-fe65-4d24-83ab-a3cca7c634f0"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cea832fe-5164-4703-b11c-531047347bdf"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("2dd812cc-abb8-4dee-96cc-95d294a4b7bb"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("3b119c87-c233-4762-a2f9-8b21385c795a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("2dd812cc-abb8-4dee-96cc-95d294a4b7bb"), false, 1 },
                    { new Guid("3b119c87-c233-4762-a2f9-8b21385c795a"), false, 0 }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("764e371f-fe65-4d24-83ab-a3cca7c634f0"), new DateTime(2024, 9, 26, 2, 59, 0, 955, DateTimeKind.Local).AddTicks(575), "User@example.com", false, true, "UserPass", "User2", new Guid("2dd812cc-abb8-4dee-96cc-95d294a4b7bb") },
                    { new Guid("cea832fe-5164-4703-b11c-531047347bdf"), new DateTime(2024, 9, 26, 2, 59, 0, 955, DateTimeKind.Local).AddTicks(562), "User@example.com", false, true, "UserPass", "User1", new Guid("3b119c87-c233-4762-a2f9-8b21385c795a") }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d50c7da5-947a-4324-8f93-887c23ef204e"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d6d5636f-7ca4-4ba2-a625-803988257fe5"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("f1fad7d7-7aa8-44ca-87d6-3aa27db11414"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("32b6df0d-da33-48af-8616-062c748af79e"));

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "Id",
                keyValue: new Guid("35154da0-0fb2-40d2-b6ec-19ff0d50085b"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("fff4e167-5595-41ed-825e-d1f59c640089"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[] { new Guid("599f7760-c419-4b68-8f97-18080eabb254"), "192.168.1.5", false, "proxyPass1", 8080, "proxyUser1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("599f7760-c419-4b68-8f97-18080eabb254"));

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "Id", "IsDelete", "TypeName" },
                values: new object[,]
                {
                    { new Guid("32b6df0d-da33-48af-8616-062c748af79e"), false, 0 },
                    { new Guid("35154da0-0fb2-40d2-b6ec-19ff0d50085b"), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[] { new Guid("fff4e167-5595-41ed-825e-d1f59c640089"), "192.168.1.1", false, "proxyPass1", 8080, "proxyUser1" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "CreateDate", "Email", "IsDelete", "IsStatus", "Password", "Proxy", "UserName", "UserType" },
                values: new object[,]
                {
                    { new Guid("d50c7da5-947a-4324-8f93-887c23ef204e"), new DateTime(2024, 9, 26, 23, 41, 25, 736, DateTimeKind.Local).AddTicks(6665), "User@example.com", false, true, "UserPass", new Guid("fff4e167-5595-41ed-825e-d1f59c640089"), "User2", new Guid("35154da0-0fb2-40d2-b6ec-19ff0d50085b") },
                    { new Guid("d6d5636f-7ca4-4ba2-a625-803988257fe5"), new DateTime(2024, 9, 26, 23, 41, 25, 736, DateTimeKind.Local).AddTicks(6667), "User@example.com", false, true, "UserPass", null, "User3", new Guid("35154da0-0fb2-40d2-b6ec-19ff0d50085b") },
                    { new Guid("f1fad7d7-7aa8-44ca-87d6-3aa27db11414"), new DateTime(2024, 9, 26, 23, 41, 25, 736, DateTimeKind.Local).AddTicks(6654), "User@example.com", false, true, "UserPass", new Guid("fff4e167-5595-41ed-825e-d1f59c640089"), "User1", new Guid("32b6df0d-da33-48af-8616-062c748af79e") }
                });
        }
    }
}

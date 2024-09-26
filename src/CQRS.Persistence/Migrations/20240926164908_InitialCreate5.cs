using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("6c47c34c-d89f-468b-af98-988c6eea44e1"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("91bc8153-2b0e-4c07-a599-2cd933ffbdc3"), "192.168.1.7", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("9995ec0d-4b1b-403a-a932-04c0a963f8bb"), "192.168.1.6", false, "proxyPass1", 8080, "proxyUser1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("91bc8153-2b0e-4c07-a599-2cd933ffbdc3"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("9995ec0d-4b1b-403a-a932-04c0a963f8bb"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[] { new Guid("6c47c34c-d89f-468b-af98-988c6eea44e1"), "192.168.1.5", false, "proxyPass1", 8080, "proxyUser1" });
        }
    }
}

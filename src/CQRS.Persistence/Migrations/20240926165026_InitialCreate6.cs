using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("1c17593c-1f15-46e2-b23c-f4971e75ce5d"), "192.168.1.7", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("34941776-5565-45d2-a8d5-5e97eda28ed6"), "192.168.1.8", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("5088b53c-66f2-44b4-8d74-664b746c53ef"), "192.168.1.6", false, "proxyPass1", 8080, "proxyUser1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("1c17593c-1f15-46e2-b23c-f4971e75ce5d"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("34941776-5565-45d2-a8d5-5e97eda28ed6"));

            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("5088b53c-66f2-44b4-8d74-664b746c53ef"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[,]
                {
                    { new Guid("91bc8153-2b0e-4c07-a599-2cd933ffbdc3"), "192.168.1.7", false, "proxyPass2", 8080, "proxyUser2" },
                    { new Guid("9995ec0d-4b1b-403a-a932-04c0a963f8bb"), "192.168.1.6", false, "proxyPass1", 8080, "proxyUser1" }
                });
        }
    }
}

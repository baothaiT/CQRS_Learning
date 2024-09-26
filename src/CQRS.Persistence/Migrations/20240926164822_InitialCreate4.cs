using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("599f7760-c419-4b68-8f97-18080eabb254"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[] { new Guid("6c47c34c-d89f-468b-af98-988c6eea44e1"), "192.168.1.5", false, "proxyPass1", 8080, "proxyUser1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Proxy",
                keyColumn: "Id",
                keyValue: new Guid("6c47c34c-d89f-468b-af98-988c6eea44e1"));

            migrationBuilder.InsertData(
                table: "Proxy",
                columns: new[] { "Id", "Ip", "IsDelete", "Password", "Port", "User" },
                values: new object[] { new Guid("599f7760-c419-4b68-8f97-18080eabb254"), "192.168.1.5", false, "proxyPass1", 8080, "proxyUser1" });
        }
    }
}

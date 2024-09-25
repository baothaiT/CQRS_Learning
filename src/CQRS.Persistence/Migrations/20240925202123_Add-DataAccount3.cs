using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAccount3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Browser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Browser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountsInBrowser",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrowserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsInBrowser", x => new { x.AccountId, x.BrowserId });
                    table.ForeignKey(
                        name: "FK_AccountsInBrowser_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsInBrowser_Browser_BrowserId",
                        column: x => x.BrowserId,
                        principalTable: "Browser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInBrowser_BrowserId",
                table: "AccountsInBrowser",
                column: "BrowserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsInBrowser");

            migrationBuilder.DropTable(
                name: "Browser");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cae94160-fab7-4de9-bb8f-08307fb15cfe"));

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
    }
}

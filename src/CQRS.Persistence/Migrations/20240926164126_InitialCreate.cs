using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Browser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Browser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRun = table.Column<int>(type: "int", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Script",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Script", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStatus = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proxy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserType = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_AccountType_UserType",
                        column: x => x.UserType,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Proxy_Proxy",
                        column: x => x.Proxy,
                        principalTable: "Proxy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlansInSchedule",
                columns: table => new
                {
                    ScheduleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansInSchedule", x => new { x.ScheduleId, x.DeviceId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansInSchedule_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInPlan",
                columns: table => new
                {
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptsInPlan_PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptsInPlan_ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInPlan", x => new { x.PlanId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInPlan_Plan_ScriptsInPlan_PlanId",
                        column: x => x.ScriptsInPlan_PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScriptsInPlan_Script_ScriptsInPlan_ScriptId",
                        column: x => x.ScriptsInPlan_ScriptId,
                        principalTable: "Script",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScriptsInProject",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScriptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScriptsInProject", x => new { x.ProjectId, x.ScriptId });
                    table.ForeignKey(
                        name: "FK_ScriptsInProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScriptsInProject_Script_ScriptId",
                        column: x => x.ScriptId,
                        principalTable: "Script",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "AccountsInProject",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsInProject", x => new { x.AccountId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_AccountsInProject_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountsInProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Account_User",
                        column: x => x.User,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Account_Proxy",
                table: "Account",
                column: "Proxy");

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserType",
                table: "Account",
                column: "UserType");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInBrowser_BrowserId",
                table: "AccountsInBrowser",
                column: "BrowserId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountsInProject_ProjectId",
                table: "AccountsInProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_User",
                table: "Logs",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_PlansInSchedule_DeviceId",
                table: "PlansInSchedule",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_PlansInSchedule_PlanId",
                table: "PlansInSchedule",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInPlan_ScriptsInPlan_PlanId",
                table: "ScriptsInPlan",
                column: "ScriptsInPlan_PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInPlan_ScriptsInPlan_ScriptId",
                table: "ScriptsInPlan",
                column: "ScriptsInPlan_ScriptId");

            migrationBuilder.CreateIndex(
                name: "IX_ScriptsInProject_ScriptId",
                table: "ScriptsInProject",
                column: "ScriptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsInBrowser");

            migrationBuilder.DropTable(
                name: "AccountsInProject");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "PlansInSchedule");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ScriptsInPlan");

            migrationBuilder.DropTable(
                name: "ScriptsInProject");

            migrationBuilder.DropTable(
                name: "Browser");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Script");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Proxy");
        }
    }
}

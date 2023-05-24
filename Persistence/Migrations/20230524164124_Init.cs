using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CustomerFName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerMName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerLName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerCompanyTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerCountry = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerTelNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerMailAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerPostAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeamTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ContractTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContractDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContractTotalCost = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EmployeeFName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeMName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeLName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeJobTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeTelNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeMailAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeePostAddress = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectTimeSpent = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectFinishData = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ContractId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    TeamId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TaskTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskFinishData = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TaskStatus = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaskTimeSpent = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    EmployeeId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f3bd501d-6647-4f51-95ce-412ae3552ed9", 0, "340aa380-03c4-45ab-a8e9-196e2d29f984", "admin@admin", false, "admin", null, false, null, "ADMIN@ADMIN", "ADMIN", "AQAAAAEAACcQAAAAEKEDcwyDbzgtKJayFDqQtjqdc30H1/pBn4BLjKi4P7GA7MNO0TyymjLTrruZdjEzDA==", null, false, "WCBIVXTPLTZ57TRN53RAKPY6EM6V62CL", false, "admin" },
                    { "f3bd501d-6647-4f51-95ce-412ae3552ee9", 0, "c9a74009-ca76-4231-bad5-39b8f7663830", "ravil@mail.com", false, "Ravil", null, false, null, "RAVIL@MAIL.COM", "RAVIL", "AQAAAAEAACcQAAAAEMQrxMoeM/bI2Dtkpe/zkgr2QAQwRx1HZIkpBuqXBbgtsRfvB9dSgxBnATU0gSZQeg==", null, false, "HR2DKDZZFCG555WQRJVEUZ4CMPVQPDSX", false, "Ravil" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "CustomerCompanyTitle", "CustomerCountry", "CustomerFName", "CustomerLName", "CustomerMName", "CustomerMailAddress", "CustomerPostAddress", "CustomerTelNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("7df41162-1895-48d4-90ed-321e4291789e"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6331), "Экосистемы", "Россия", "Дмитрий", "Загородский", "Витальевич", "EcoSystem@eco.ru", "г. Москва пр. Ленина 21 офис 14", "89035678945", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6334) },
                    { new Guid("7fa2a4b2-c04c-4f2e-8e32-218a60914684"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6355), "Смарт-Решения", "Россия", "Василий", "Колыванов", "Иванович", "smartD@sd.ru", "г.Калуга ул. Ковалёва 15 офис 56", "8916766891", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6356) },
                    { new Guid("a8fd7901-4a88-4199-a08c-2ba723d094ea"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6351), "Энергопроект", "Россия", "Петр", "Васнецов", "Петрович", "energoProject@ep.ru", "г. Воронеж ул. Воронина 56 офис 21", "8910567890", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(6351) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "TeamDescription", "TeamTitle", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8749), "Команда укомлектована дизайнером", "Команда по проекту Энергопроект", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8749) },
                    { new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8744), "Команда укомлектована аналитиком", "Команда по проекту Экосистем", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8745) },
                    { new Guid("f97fab25-21de-44cb-b6c2-5f1db493d614"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8751), "Команда укомлектована аналитиком", "Команда по проекту Смарт-Решения", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8751) }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractDescription", "ContractTitle", "ContractTotalCost", "CreatedBy", "CreatedOn", "CustomerId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("3e53a63a-cd4c-49fd-816d-d8d5d136dce4"), "Реинжениринг ИС. Василий Колыванов", "Реинжениринг ИС Смарт-Решения", "20 млн. руб", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7062), new Guid("7fa2a4b2-c04c-4f2e-8e32-218a60914684"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7063) },
                    { new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"), "Обновление ИС Петр Васнецов", "Обновление ИС Энергопроект", "20 млн. руб", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7058), new Guid("a8fd7901-4a88-4199-a08c-2ba723d094ea"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7059) },
                    { new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"), "Разработка ПО.Дмитрий Загородский", "Разработка ИС для Экосистем", "40 млн. руб", "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7052), new Guid("7df41162-1895-48d4-90ed-321e4291789e"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7053) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeFName", "EmployeeJobTitle", "EmployeeLName", "EmployeeMName", "EmployeeMailAddress", "EmployeePostAddress", "EmployeeTelNumber", "TeamId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("33d85a99-bda5-4aca-8904-ece3cb1084ea"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9258), "Пётр", "Дизайнер", "Гордеев", "Андреевич", "parinkov@prog.ru", "г.Мытищи ул. Вологда 33", "8970545821", new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9258) },
                    { new Guid("554644c6-be02-42b2-84c0-cb4faec335bd"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9261), "Иван", "Аналитик", "Василевский", "Васильевич", "vasilevsky@prog.ru", "г.Мытищи ул. Ленина 54", "8971567821", new Guid("f97fab25-21de-44cb-b6c2-5f1db493d614"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9261) },
                    { new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9244), "Дмитрий", "Програмист", "Коренков", "Васильевич", "korenkov@prog.ru", "г.Москва пр. Маркса 21 ", "89056673245", new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9245) },
                    { new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9251), "Виталий", "Аналитик", "Валежник", "Витальевич", "korenkov@prog.ru", "г.Уфа ул. Ленина 14 ", "89076222241", new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9251) },
                    { new Guid("d78fbbe4-7447-4d05-833c-5eeb3950e0d5"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9264), "Ольга", "Програмист", "Гордеева", "Андреевна", "o.gordeeva@prog.ru", "г.Москва пр. Мира 33 кв.234", "8956789045", new Guid("f97fab25-21de-44cb-b6c2-5f1db493d614"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9264) },
                    { new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9255), "Андрей", "Менеджер проекта", "Паринков", "Витальевич", "parinkov@prog.ru", "г.Мытищи ул. Вологда 33", "8970545821", new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(9255) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "ProjectDescription", "ProjectFinishData", "ProjectStatus", "ProjectTimeSpent", "ProjectTitle", "ProjectType", "TeamId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"), new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7597), "Разработка ИС, Разработка и развёртывание", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "InProcess", "300 ч", "Разработка ИС для Экосистем", "Разработка ИС", new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "ProjectDescription", "ProjectFinishData", "ProjectStatus", "ProjectTimeSpent", "ProjectTitle", "ProjectType", "TeamId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"), new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7654), "Обновление ИС, Обновление и тестирование", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "InProcess", "150 ч", "Обновление ИС Энергопроект", "Обновление ИС", new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ContractId", "CreatedBy", "CreatedOn", "ProjectDescription", "ProjectFinishData", "ProjectStatus", "ProjectTimeSpent", "ProjectTitle", "ProjectType", "TeamId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("97d74d89-f2db-4cf9-b4c4-1d2d52ded14e"), new Guid("3e53a63a-cd4c-49fd-816d-d8d5d136dce4"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7662), "Реинжениринг ИС, Реинжениринг и развёртывание", new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "InProcess", "400 ч", "Реинжениринг ИС Смарт-Решения", "Реинжениринг ИС", new Guid("f97fab25-21de-44cb-b6c2-5f1db493d614"), "System", new DateTime(2023, 5, 24, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "EmployeeId", "ProjectId", "TaskDescription", "TaskFinishData", "TaskStatus", "TaskTimeSpent", "TaskTitle", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("0f886c20-33e8-4fd8-a41c-3bf705d03c47"), "System", new DateTime(2023, 5, 8, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8254), new Guid("d78fbbe4-7447-4d05-833c-5eeb3950e0d5"), new Guid("97d74d89-f2db-4cf9-b4c4-1d2d52ded14e"), "Разработка ИС по проекту Смарт-Решения", new DateTime(2023, 6, 23, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8256), "InProcess", "10 ч", "Разработка ИС", "System", new DateTime(2023, 5, 22, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8255) },
                    { new Guid("12a1f7cd-db28-4fd1-a63f-8adf27084174"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8258), new Guid("d78fbbe4-7447-4d05-833c-5eeb3950e0d5"), new Guid("97d74d89-f2db-4cf9-b4c4-1d2d52ded14e"), "Редизайн ИС по проекту Смарт-Решения", new DateTime(2023, 7, 8, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8262), "Stopped", "5 ч", "Разработка ИС", "System", new DateTime(2023, 5, 22, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8259) },
                    { new Guid("278c74e0-bfc0-48c0-8090-ee23cf303dae"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8188), new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"), new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"), "Моделирование БД для разработки по проекту Экосистем", new DateTime(2023, 6, 13, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8192), "Stopped", "12 ч", "Моделирование БД", "System", new DateTime(2023, 5, 17, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8189) },
                    { new Guid("2f560daf-fd18-4320-addf-a160f65da673"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8196), new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"), new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"), "Проектирование ИС по проекту Экосистем", new DateTime(2023, 7, 3, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8198), "Stopped", "12 ч", "Проектирование ИС", "System", new DateTime(2023, 5, 23, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8197) },
                    { new Guid("38c87236-80b8-471e-bad4-24c318ba022f"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8233), new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"), new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"), "Тестирование ПО по проекту Экосистем", new DateTime(2023, 6, 7, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8236), "Stopped", "9 ч", "Тестирование ПО", "System", new DateTime(2023, 5, 20, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8234) },
                    { new Guid("9980061a-f8b1-4149-bfed-84dc8d702527"), "System", new DateTime(2023, 5, 10, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8250), new Guid("554644c6-be02-42b2-84c0-cb4faec335bd"), new Guid("97d74d89-f2db-4cf9-b4c4-1d2d52ded14e"), "Разработка ТЗ по проекту Смарт-Решения", new DateTime(2023, 6, 18, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8252), "Stopped", "6 ч", "Разработка ТЗ", "System", new DateTime(2023, 5, 22, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8250) },
                    { new Guid("d2016c56-3c07-47d6-8e63-124847836a6a"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8245), new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"), new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"), "Разработка ТЗ по проекту Энергопроект", new DateTime(2023, 5, 22, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8248), "Finished", "12 ч", "Разработка ТЗ", "System", new DateTime(2023, 5, 22, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8246) },
                    { new Guid("e3e3675a-f500-4f8b-8a44-35a07b540300"), "System", new DateTime(2023, 5, 14, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8238), new Guid("33d85a99-bda5-4aca-8904-ece3cb1084ea"), new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"), "Разработка UI по проекту Энергопроект", new DateTime(2023, 5, 22, 19, 41, 23, 972, DateTimeKind.Local).AddTicks(8241), "Finished", "3 ч", "Разработка UI", "System", new DateTime(2023, 5, 22, 16, 41, 23, 972, DateTimeKind.Utc).AddTicks(8239) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Id",
                table: "Contracts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Id",
                table: "Customers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id",
                table: "Employees",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TeamId",
                table: "Employees",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ContractId",
                table: "Projects",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Id",
                table: "Projects",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_EmployeeId",
                table: "ProjectTasks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_Id",
                table: "ProjectTasks",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectId",
                table: "ProjectTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Id",
                table: "Teams",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

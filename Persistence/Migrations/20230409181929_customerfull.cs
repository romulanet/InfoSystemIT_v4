using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class customerfull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerLName",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerFName",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "CustomerCompanyTitle", "CustomerCountry", "CustomerLName", "CustomerMName", "CustomerMailAddress", "CustomerPostAddress", "CustomerTelNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 18, 19, 29, 624, DateTimeKind.Utc).AddTicks(4249), "Энергопроект", "Россия", "Васнецов", "Петрович", "energoProject@.ru", "г. Воронеж ул. Воронина 56 офис 21", "8910567890", "System", new DateTime(2023, 4, 9, 18, 19, 29, 624, DateTimeKind.Utc).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "CustomerCompanyTitle", "CustomerCountry", "CustomerMName", "CustomerMailAddress", "CustomerPostAddress", "CustomerTelNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 18, 19, 29, 624, DateTimeKind.Utc).AddTicks(4231), "Экосистемы", "Россия", "Витальевич", "EcoSystem@eco.ru", "г. Москва пр. Ленина 21 офис 14", "89035678945", "System", new DateTime(2023, 4, 9, 18, 19, 29, 624, DateTimeKind.Utc).AddTicks(4233) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerLName",
                keyValue: null,
                column: "CustomerLName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerLName",
                table: "Customers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerFName",
                keyValue: null,
                column: "CustomerFName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerFName",
                table: "Customers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "CustomerCompanyTitle", "CustomerCountry", "CustomerLName", "CustomerMName", "CustomerMailAddress", "CustomerPostAddress", "CustomerTelNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 3, 26, 18, 32, 2, 385, DateTimeKind.Utc).AddTicks(922), null, null, "Вологодский", null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "CustomerCompanyTitle", "CustomerCountry", "CustomerMName", "CustomerMailAddress", "CustomerPostAddress", "CustomerTelNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 3, 26, 18, 32, 2, 385, DateTimeKind.Utc).AddTicks(905), null, null, null, null, null, null, null, null });
        }
    }
}

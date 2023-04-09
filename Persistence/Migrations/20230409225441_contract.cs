using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class contract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContractTotalCost",
                table: "Contracts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ContractTitle",
                table: "Contracts",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractDescription", "ContractTitle", "ContractTotalCost", "CreatedBy", "CreatedOn", "CustomerId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"), "Обновление ПО для клиента", "Обновление ПО", "20 млн. руб", "System", new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(6463), null, "System", new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(6463) },
                    { new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"), "Разработка ПО для клиента", "Разработка ПО", "40 млн. руб", "System", new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(6454), null, "System", new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(6456) }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(5294), new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(5266), new DateTime(2023, 4, 9, 22, 54, 40, 632, DateTimeKind.Utc).AddTicks(5272) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"));

            migrationBuilder.AlterColumn<int>(
                name: "ContractTotalCost",
                table: "Contracts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "ContractTitle",
                keyValue: null,
                column: "ContractTitle",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ContractTitle",
                table: "Contracts",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 19, 20, 36, 317, DateTimeKind.Utc).AddTicks(7677), new DateTime(2023, 4, 9, 19, 20, 36, 317, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 19, 20, 36, 317, DateTimeKind.Utc).AddTicks(7658), new DateTime(2023, 4, 9, 19, 20, 36, 317, DateTimeKind.Utc).AddTicks(7663) });
        }
    }
}

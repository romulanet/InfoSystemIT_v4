using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees_Teams",
                keyColumns: new[] { "EmployeeId", "TeamId" },
                keyValues: new object[] { new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"), new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe") });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7215), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8939), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8946), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.InsertData(
                table: "Employees_Teams",
                columns: new[] { "EmployeeId", "TeamId" },
                values: new object[] { new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"), new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe") });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("278c74e0-bfc0-48c0-8090-ee23cf303dae"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 5, 13, 19, 10, 2, 232, DateTimeKind.Local).AddTicks(8158), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("38c87236-80b8-471e-bad4-24c318ba022f"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8161), new DateTime(2023, 5, 7, 19, 10, 2, 232, DateTimeKind.Local).AddTicks(8163), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("e3e3675a-f500-4f8b-8a44-35a07b540300"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 13, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 4, 21, 19, 10, 2, 232, DateTimeKind.Local).AddTicks(8167), new DateTime(2023, 4, 21, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7698), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8573), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8569), new DateTime(2023, 4, 23, 16, 10, 2, 232, DateTimeKind.Utc).AddTicks(8570) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees_Teams",
                keyColumns: new[] { "EmployeeId", "TeamId" },
                keyValues: new object[] { new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"), new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe") });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(4991), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(4977), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(3230), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7858), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7864), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7867), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.InsertData(
                table: "Employees_Teams",
                columns: new[] { "EmployeeId", "TeamId" },
                values: new object[] { new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"), new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe") });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("278c74e0-bfc0-48c0-8090-ee23cf303dae"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6527), new DateTime(2023, 5, 13, 18, 14, 12, 458, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("38c87236-80b8-471e-bad4-24c318ba022f"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6539), new DateTime(2023, 5, 7, 18, 14, 12, 458, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("e3e3675a-f500-4f8b-8a44-35a07b540300"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 13, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6544), new DateTime(2023, 4, 21, 18, 14, 12, 458, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 4, 21, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(5779), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 4, 23, 15, 14, 12, 458, DateTimeKind.Utc).AddTicks(7276) });
        }
    }
}

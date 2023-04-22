using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CustomerContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"),
                columns: new[] { "CreatedOn", "CustomerId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(2760), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"),
                columns: new[] { "CreatedOn", "CustomerId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(2750), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(1499), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(1477), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6417), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("278c74e0-bfc0-48c0-8090-ee23cf303dae"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4723), new DateTime(2023, 5, 12, 22, 26, 4, 476, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("38c87236-80b8-471e-bad4-24c318ba022f"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4740), new DateTime(2023, 5, 6, 22, 26, 4, 476, DateTimeKind.Local).AddTicks(4743), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("e3e3675a-f500-4f8b-8a44-35a07b540300"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 12, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 4, 20, 22, 26, 4, 476, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 4, 20, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"),
                columns: new[] { "CreatedOn", "ProjectFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(3787), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"),
                columns: new[] { "CreatedOn", "ProjectFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(3817), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(5527), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(5521), new DateTime(2023, 4, 22, 19, 26, 4, 476, DateTimeKind.Utc).AddTicks(5522) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53b08e3d-7620-4f73-87ee-0b2d2686c179"),
                columns: new[] { "CreatedOn", "CustomerId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(1621), null, new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("6442d3ea-986d-4ed0-b249-6993fa75ed83"),
                columns: new[] { "CreatedOn", "CustomerId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(1616), null, new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(863), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(842), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("64c2f517-4c27-4e23-adbb-70077bc80834"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3993), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d3223d1e-7ccd-4384-ac2c-734634e7b7f3"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3999), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ec21ec2e-fc34-4235-9575-066f56c49f5f"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(4003), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("278c74e0-bfc0-48c0-8090-ee23cf303dae"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2841), new DateTime(2023, 5, 9, 22, 36, 17, 747, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("38c87236-80b8-471e-bad4-24c318ba022f"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 5, 3, 22, 36, 17, 747, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: new Guid("e3e3675a-f500-4f8b-8a44-35a07b540300"),
                columns: new[] { "CreatedOn", "TaskFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 9, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2855), new DateTime(2023, 4, 17, 22, 36, 17, 747, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 4, 17, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1e9c86b9-5976-4713-8c01-1601b74e9d37"),
                columns: new[] { "CreatedOn", "ProjectFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2228), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("94b1f1ac-30ee-45f8-929a-ad77ca814000"),
                columns: new[] { "CreatedOn", "ProjectFinishData", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2255), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("1c29869d-49e6-4a8e-a1eb-8773497e80fe"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("9e1257c8-00d1-4ba9-80af-f84b8e29431a"),
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3496), new DateTime(2023, 4, 19, 19, 36, 17, 747, DateTimeKind.Utc).AddTicks(3497) });
        }
    }
}

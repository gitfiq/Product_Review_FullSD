using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class formvalidation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af36d876-688b-4d88-ae83-afe53c802bec", "AQAAAAIAAYagAAAAEAJgwz7KTbZl6uMiTmRpmGm8LuChYBWKwqH9f62L1wxWJbKVsk+DczeX1V3Nh1afuQ==", "b6ad4dcb-4a79-49cc-a926-78e028a90634" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9159), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9165), new DateTime(2024, 1, 31, 21, 1, 59, 201, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "BookAuthorDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(2304), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Recommendations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1899), new DateTime(2024, 1, 31, 21, 1, 59, 202, DateTimeKind.Local).AddTicks(1902) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec972728-7f38-4b09-8a9c-ef0e54a8af8c", "AQAAAAIAAYagAAAAEBWM8vTbeyx6aalWN8l6/Gi22Xi2jF8yBkEa/ZwAFUzSUGfFu1GVQKBhrpk0aMR3QQ==", "ff9a1afd-a8b1-4e36-bd81-3ddbc5a5367c" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1234), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1238), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1241), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "BookAuthorDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2004), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Recommendations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 1, 31, 21, 0, 24, 300, DateTimeKind.Local).AddTicks(2423) });
        }
    }
}

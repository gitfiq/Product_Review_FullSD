using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class formvalidation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5060), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbeaab7-1c82-4acf-94ed-82ba72e45008", "AQAAAAIAAYagAAAAEDw1TXeAZfTn7sPtKi8jdlxcVIF3XGeuSxjmeG/HohhjQRjkaxMYNQ1tsGQMNd/kbg==", "40697f30-bab7-4e73-8b1a-7626b27974a0" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5495), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5504), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "BookAuthorDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Recommendations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 1, 31, 20, 43, 41, 519, DateTimeKind.Local).AddTicks(6641) });
        }
    }
}

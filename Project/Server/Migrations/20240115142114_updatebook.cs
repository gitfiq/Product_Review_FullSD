using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatebook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PublishYear",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "387244e6-3a63-48b0-81ec-c873c55a81ac", "AQAAAAIAAYagAAAAEJqkBwdW8VzHhjr+JxD0HfxXZ9Y/Eu8yAEX85FQxJP/w3noE2GyXVHTOEA+SNtpNcw==", "c8b05919-e9d6-4108-8ef4-6b58a0ca67c3" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 21, 13, 750, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 1, 15, 22, 21, 13, 750, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 21, 13, 750, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 1, 15, 22, 21, 13, 750, DateTimeKind.Local).AddTicks(6762) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublishYear",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6baaae-f23f-4502-95e3-ba8d716f54ee", "AQAAAAIAAYagAAAAEAy1vnD/7QRfvPUzfr3Rqb+PGZW/nprjVNkd7ZQo9zenmhJl9RNz/C1jVwLVv1Rlfw==", "c74015b0-755e-499c-b7c4-0c072b59bc12" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 12, 44, 54, 996, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 1, 15, 12, 44, 54, 996, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 12, 44, 54, 996, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 1, 15, 12, 44, 54, 996, DateTimeKind.Local).AddTicks(238) });
        }
    }
}

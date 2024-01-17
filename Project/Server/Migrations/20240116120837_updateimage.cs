using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookImage",
                table: "Books");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1651e082-1c2d-405b-b9b4-d6b7b223323a", "AQAAAAIAAYagAAAAEIeO/7cluNaG24dONpsT02Tt7oMNUjuZCi32OaJ7Pc/O1cntwXOT0qsWGk4L5WvgDQ==", "2df41802-4f3a-4378-ad02-280021f46374" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 8, 36, 825, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 1, 16, 20, 8, 36, 825, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 16, 20, 8, 36, 825, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 1, 16, 20, 8, 36, 825, DateTimeKind.Local).AddTicks(9041) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "BookImage",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}

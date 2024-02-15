using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpApiCourse.Migrations
{
    /// <inheritdoc />
    public partial class AddHotelNumberToDbRemoveColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 38, 38, 462, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 38, 38, 462, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 38, 38, 462, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 38, 38, 462, DateTimeKind.Local).AddTicks(9683));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 35, 41, 415, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 35, 41, 415, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 35, 41, 415, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 35, 41, 415, DateTimeKind.Local).AddTicks(6849));
        }
    }
}

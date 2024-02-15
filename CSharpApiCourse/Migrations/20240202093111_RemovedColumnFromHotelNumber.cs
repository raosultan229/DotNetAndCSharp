using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpApiCourse.Migrations
{
    /// <inheritdoc />
    public partial class RemovedColumnFromHotelNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 31, 10, 376, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 31, 10, 376, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 31, 10, 376, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 2, 14, 31, 10, 376, DateTimeKind.Local).AddTicks(7850));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 18, 3, 43, 938, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 18, 3, 43, 938, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 18, 3, 43, 938, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 1, 18, 3, 43, 938, DateTimeKind.Local).AddTicks(3045));
        }
    }
}

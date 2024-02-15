using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpApiCourse.Migrations
{
    /// <inheritdoc />
    public partial class AddHotelNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelNumber",
                columns: table => new
                {
                    HotelNo = table.Column<int>(type: "int", nullable: false),
                    AdditionalDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelNumber", x => x.HotelNo);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelNumber");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 12, 2, 57, 39, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 12, 2, 57, 39, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 12, 2, 57, 39, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 12, 2, 57, 39, DateTimeKind.Local).AddTicks(4889));
        }
    }
}

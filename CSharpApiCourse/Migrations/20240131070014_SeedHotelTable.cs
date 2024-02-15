using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpApiCourse.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsAvailable", "Name", "Occupancy", "Rate", "Rooms", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia", "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=", true, "Serena hotel", 5, 20000.0, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PC Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia", "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=", true, "PC hotel", 5, 10000.0, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nova Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia", "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=", false, "Nova hotel", 5, 20000.0, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia", "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=", true, "Royal hotel", 5, 50000.0, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia", "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=", false, "Palace hotel", 5, 70000.0, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

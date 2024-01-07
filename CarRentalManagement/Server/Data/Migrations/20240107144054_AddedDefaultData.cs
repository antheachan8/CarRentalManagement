using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(7621), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(7642), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(7661), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(7662), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(8567), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(8571), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9245), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9247), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9249), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9251), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9252), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9254), new DateTime(2024, 1, 7, 22, 40, 54, 730, DateTimeKind.Local).AddTicks(9255), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

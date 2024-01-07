using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7b04845-31f4-4f68-acc0-f76cce7ff0e0", "AQAAAAIAAYagAAAAEAOLIQMcwumar1a6z4aaHx3saX9lD8tzrEigvk+GERmndVemq7YS6DsfYteQJIstgQ==", "efc11e22-f07c-41cf-a72d-1a36d42c765d" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 1, 7, 23, 55, 53, 929, DateTimeKind.Local).AddTicks(9426) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6679d460-35f9-42a5-94aa-97cc615d76d8", "AQAAAAIAAYagAAAAEJfRuAMs05qRTr6UKhNhn2FucfsWGsnLHXIa+gBe9zDyqO4EPDg4D2hRqWHjpec9sw==", "86c70db3-b71b-4710-a8a8-68ab5b8faef9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 1, 7, 23, 24, 17, 317, DateTimeKind.Local).AddTicks(5605) });
        }
    }
}

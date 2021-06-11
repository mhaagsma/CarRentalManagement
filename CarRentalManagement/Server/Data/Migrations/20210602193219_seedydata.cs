using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class seedydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 134, DateTimeKind.Local).AddTicks(268), new DateTime(2021, 6, 2, 13, 32, 19, 140, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 140, DateTimeKind.Local).AddTicks(2708), new DateTime(2021, 6, 2, 13, 32, 19, 140, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(4587), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(4964), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8442), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8757), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8769), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8774), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8779), new DateTime(2021, 6, 2, 13, 32, 19, 143, DateTimeKind.Local).AddTicks(8781) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 155, DateTimeKind.Local).AddTicks(2203), new DateTime(2021, 6, 2, 11, 25, 50, 158, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 158, DateTimeKind.Local).AddTicks(7394), new DateTime(2021, 6, 2, 11, 25, 50, 158, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 159, DateTimeKind.Local).AddTicks(7441), new DateTime(2021, 6, 2, 11, 25, 50, 159, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 159, DateTimeKind.Local).AddTicks(7744), new DateTime(2021, 6, 2, 11, 25, 50, 159, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(811), new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1110), new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1122), new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1126), new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1131), new DateTime(2021, 6, 2, 11, 25, 50, 160, DateTimeKind.Local).AddTicks(1132) });
        }
    }
}

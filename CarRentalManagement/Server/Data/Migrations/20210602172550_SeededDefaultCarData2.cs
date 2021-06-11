using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 978, DateTimeKind.Local).AddTicks(149), new DateTime(2021, 5, 31, 20, 21, 49, 982, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 982, DateTimeKind.Local).AddTicks(3476), new DateTime(2021, 5, 31, 20, 21, 49, 982, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(147), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(807), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7307), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7747), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7763), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7769), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7774), new DateTime(2021, 5, 31, 20, 21, 49, 984, DateTimeKind.Local).AddTicks(7776) });
        }
    }
}

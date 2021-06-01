using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 443, DateTimeKind.Local).AddTicks(5030), new DateTime(2021, 5, 31, 20, 19, 54, 447, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 447, DateTimeKind.Local).AddTicks(5797), new DateTime(2021, 5, 31, 20, 19, 54, 447, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 448, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 5, 31, 20, 19, 54, 448, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 448, DateTimeKind.Local).AddTicks(8100), new DateTime(2021, 5, 31, 20, 19, 54, 448, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(1929), new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2249), new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2260), new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2265), new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2269), new DateTime(2021, 5, 31, 20, 19, 54, 449, DateTimeKind.Local).AddTicks(2271) });
        }
    }
}

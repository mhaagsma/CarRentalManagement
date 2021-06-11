using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12", "bfacf803-f532-4f15-8c5a-34744d0c646e", "User", "USER" },
                    { "dfd84aca-2438-4447-b68d-20ec959ff92b", "548d5d64-93b7-4fba-b1ed-bf338679ff1e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 274, DateTimeKind.Local).AddTicks(5288), new DateTime(2021, 6, 7, 12, 57, 48, 279, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 279, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 6, 7, 12, 57, 48, 279, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 281, DateTimeKind.Local).AddTicks(5356), new DateTime(2021, 6, 7, 12, 57, 48, 281, DateTimeKind.Local).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 281, DateTimeKind.Local).AddTicks(5977), new DateTime(2021, 6, 7, 12, 57, 48, 281, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(928), new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1328), new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1341), new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1347), new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1353), new DateTime(2021, 6, 7, 12, 57, 48, 282, DateTimeKind.Local).AddTicks(1356) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 604, DateTimeKind.Local).AddTicks(5555), new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(4465), new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5588), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5983), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9409), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9728), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9738), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9744), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9748), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9750) });
        }
    }
}

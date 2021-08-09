using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "42170448-f0c3-4f83-a047-7058d533ef01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "d8169a13-62b6-4cc4-ac90-41e2c3531be5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f96d6c-0e9c-4236-87b1-4db1dbec05b2", "AQAAAAEAACcQAAAAELBi85VTXG7MndhmgNgAHd6wbraRQn3mDo3L3AhDWAV8UKWwAILR1JtZIc1RsflrpQ==", "c816f98a-7a33-4f7a-b1fd-19297af86c20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0332caf0-bf7a-4ef5-8fca-7ff864abe0cd", "AQAAAAEAACcQAAAAEOegUVDo8otD3wIV97AoIl2YvFgQExBpVrqliUuePwki8IdwK1/Ysw6cIbQlkqbtCg==", "36b548d2-975d-49bf-bfa1-7bbac972811b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 954, DateTimeKind.Local).AddTicks(7641), new DateTime(2021, 7, 15, 14, 51, 27, 960, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 960, DateTimeKind.Local).AddTicks(2488), new DateTime(2021, 7, 15, 14, 51, 27, 960, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 961, DateTimeKind.Local).AddTicks(9091), new DateTime(2021, 7, 15, 14, 51, 27, 961, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 961, DateTimeKind.Local).AddTicks(9580), new DateTime(2021, 7, 15, 14, 51, 27, 961, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(5882), new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6653), new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6690), new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6706), new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6724), new DateTime(2021, 7, 15, 14, 51, 27, 962, DateTimeKind.Local).AddTicks(6733) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "b0daf125-fa9e-448a-b38e-b0d3df1ae4ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "c735b01e-ce3b-4770-b453-986517645b79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708f2b60-a7fe-4025-bccd-62c9dde46d4b", "AQAAAAEAACcQAAAAEMRmnzWmBiKzNaQq7KT/Fw/hpXPoJeyBLd1/loyTZ5S+6XZcvmuDeXhJPRD7inv6nQ==", "9229be39-e390-4d00-95d2-da32da1f8232" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8171fc73-c895-4004-a042-a29600f502f8", "AQAAAAEAACcQAAAAEON+LmF7auW9pstachbbREgddYKhCB35ffZN+L1SqLN5h85mW2bTQrFX+sQ74op7Zg==", "12bea427-5825-4d56-872b-ac6ce85eb81b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 859, DateTimeKind.Local).AddTicks(3730), new DateTime(2021, 7, 8, 14, 34, 51, 864, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 864, DateTimeKind.Local).AddTicks(1704), new DateTime(2021, 7, 8, 14, 34, 51, 864, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(4303), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(4326) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(4671), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(8767), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9140), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9154), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9164), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9169), new DateTime(2021, 7, 8, 14, 34, 51, 865, DateTimeKind.Local).AddTicks(9172) });
        }
    }
}

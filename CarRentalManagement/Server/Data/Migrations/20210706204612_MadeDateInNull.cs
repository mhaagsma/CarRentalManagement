using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "contact_number",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "emailAddress",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "ef72ca1f-5e14-4d0a-bad2-7c84d8d018b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "18d0cc6c-97a1-4414-bce9-f9831cf4e65f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a992cb01-019d-44b1-b23c-e073412a2ab4", "AQAAAAEAACcQAAAAEEVaR1me/fh9h3UmvAhqpsik6nRYRqzbqBaONoWUxVX/xNFfytcI42bj/xBqkK1q3Q==", "db9216ea-41df-4af4-8896-f1a38f7064e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41735be2-f084-4d9e-9c58-17f296b41c07", "AQAAAAEAACcQAAAAEEVHd4EBtqz8Hyukpmu0WvJaVN9dp6L8Lc2D4SgtlUqHAR5poomax38gqhLD+5jA9w==", "ff6c29f1-58f9-4765-9e72-a5372181333b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 912, DateTimeKind.Local).AddTicks(2001), new DateTime(2021, 7, 6, 14, 46, 11, 919, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 919, DateTimeKind.Local).AddTicks(1942), new DateTime(2021, 7, 6, 14, 46, 11, 919, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 920, DateTimeKind.Local).AddTicks(9741), new DateTime(2021, 7, 6, 14, 46, 11, 920, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(277), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7013), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7517), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7535), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7543), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7552), new DateTime(2021, 7, 6, 14, 46, 11, 921, DateTimeKind.Local).AddTicks(7556) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "contact_number",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "emailAddress",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "f7210bec-2f7d-4fcc-828e-d415697d23ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "db4b9d68-e688-43bf-950f-99b55a8d9ea9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c95cc900-afb9-432c-b5ed-589dc1edab33", "AQAAAAEAACcQAAAAEK9wQl8RiUSGocMNREkE+NoUrC+XfVwVzQnRzXCDnGWPxPM8gFBPllKGjDtSmk9kxw==", "21b1c998-747d-4626-b087-7b0eb165be80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8934642-6f3c-4678-b165-328097072f55", "AQAAAAEAACcQAAAAEKOWxj9l7iuzl0VPY+F1TYP4WJgfRVnER3SufX+Mmvv5EBWYXwSeEgk4T7YM6V1mLg==", "e5d446b0-ac92-4207-ae38-7d179b59942a" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 284, DateTimeKind.Local).AddTicks(7926), new DateTime(2021, 6, 11, 14, 38, 21, 289, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 289, DateTimeKind.Local).AddTicks(5672), new DateTime(2021, 6, 11, 14, 38, 21, 289, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(465), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5251), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5594), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5607), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5612), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5617), new DateTime(2021, 6, 11, 14, 38, 21, 291, DateTimeKind.Local).AddTicks(5619) });
        }
    }
}

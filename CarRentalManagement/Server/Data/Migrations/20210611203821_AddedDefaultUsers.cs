using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7ea9571d-711e-4dc2-a670-b81e1a72b440", 0, "d8934642-6f3c-4678-b165-328097072f55", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKOWxj9l7iuzl0VPY+F1TYP4WJgfRVnER3SufX+Mmvv5EBWYXwSeEgk4T7YM6V1mLg==", null, false, "e5d446b0-ac92-4207-ae38-7d179b59942a", false, "admin@localhost.com" },
                    { "1728f69c-93d3-4f87-adfd-72c613c4c000", 0, "c95cc900-afb9-432c-b5ed-589dc1edab33", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEK9wQl8RiUSGocMNREkE+NoUrC+XfVwVzQnRzXCDnGWPxPM8gFBPllKGjDtSmk9kxw==", null, false, "21b1c998-747d-4626-b087-7b0eb165be80", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dfd84aca-2438-4447-b68d-20ec959ff92b", "7ea9571d-711e-4dc2-a670-b81e1a72b440" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12", "1728f69c-93d3-4f87-adfd-72c613c4c000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12", "1728f69c-93d3-4f87-adfd-72c613c4c000" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfd84aca-2438-4447-b68d-20ec959ff92b", "7ea9571d-711e-4dc2-a670-b81e1a72b440" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "bfacf803-f532-4f15-8c5a-34744d0c646e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "548d5d64-93b7-4fba-b1ed-bf338679ff1e");

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
    }
}

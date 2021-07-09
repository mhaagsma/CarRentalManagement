using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToColourMakeModeletc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "79122a2e-e0d9-425f-bd15-f724525eaf3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "e6bc4351-cdb1-455c-a721-319e2ee22434");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e0c081-e54d-41c1-b866-59c82578453b", "AQAAAAEAACcQAAAAEFgzenpqYzTQWLs8RTm0/Wqs1uv7MOtF2nVd6yzeYFGj8Q3xsxT10PYHfITmSql3+Q==", "83f6ef32-0fbc-45c6-b7af-a00ec41f6d51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d66dcbd-74ff-44fc-9e18-d3aa48165cb4", "AQAAAAEAACcQAAAAEA04chvUTcjAc0ApnZKI2/I56u9BZSanlB8eqX4f9V4ZH+Kmg7e7mSF1/8xWcn8vgw==", "4778a896-2933-413d-8738-84e78178f812" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 20, DateTimeKind.Local).AddTicks(5191), new DateTime(2021, 7, 8, 14, 4, 3, 23, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 23, DateTimeKind.Local).AddTicks(8913), new DateTime(2021, 7, 8, 14, 4, 3, 23, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 24, DateTimeKind.Local).AddTicks(9021), new DateTime(2021, 7, 8, 14, 4, 3, 24, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 24, DateTimeKind.Local).AddTicks(9341), new DateTime(2021, 7, 8, 14, 4, 3, 24, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2403), new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2717), new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2727), new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2732), new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2736), new DateTime(2021, 7, 8, 14, 4, 3, 25, DateTimeKind.Local).AddTicks(2738) });
        }
    }
}

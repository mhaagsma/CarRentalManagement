using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "c82487cd-909e-4f08-a447-4b535e1ae89b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "df1a07df-c01c-4221-869b-8c27b5c3b5e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64cc0d8a-c319-4692-b285-946b0dd57e11", "AQAAAAEAACcQAAAAEOx28aGhccvN6siASOn+P2v4fjWAJNeAVEzWvnqjHzm6/qt3fsDGdnDQpUyph396Rw==", "61f1cdad-9b77-4a82-adda-6c79799f4675" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52d948ed-31ef-4bb5-b787-52ff49070465", "AQAAAAEAACcQAAAAEAOqNmqx2DHOu0kdcWeVp7jBBiaVsUI8kZ5rnTGtoOgd4IIJoiLRGRJWcTZS7os21A==", "66cb2f37-b1b8-46f9-9c54-10ace00f68ea" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 397, DateTimeKind.Local).AddTicks(9172), new DateTime(2021, 7, 7, 12, 4, 36, 404, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 404, DateTimeKind.Local).AddTicks(1830), new DateTime(2021, 7, 7, 12, 4, 36, 404, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 405, DateTimeKind.Local).AddTicks(8131), new DateTime(2021, 7, 7, 12, 4, 36, 405, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 405, DateTimeKind.Local).AddTicks(8530), new DateTime(2021, 7, 7, 12, 4, 36, 405, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2453), new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2809), new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2822), new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2828), new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2833), new DateTime(2021, 7, 7, 12, 4, 36, 406, DateTimeKind.Local).AddTicks(2835) });
        }
    }
}

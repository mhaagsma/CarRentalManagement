using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "3a77915f-d1c3-4f70-aa60-7b8fc3205b96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "73b294a5-093d-4978-9876-9b685c2e6604");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "676481f5-aa9f-402a-ae24-184ed76e8d32", "AQAAAAEAACcQAAAAEJHER1A9ca4voUmiJX3PPes+9a6CLFTf1Cp+nCLCK36kHWA3T7Pg64ANaw7S4PMB1w==", "810a8f74-3f49-4569-8022-6a7e6d643ac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17980df8-319e-4770-bc61-8db652f64c95", "AQAAAAEAACcQAAAAEFjfNlM5HDuanl88bWnHSZHI6VldkNrlcYBMf2AEJvqw9ShqgMuMdK5YckkHCkbOcQ==", "cb42bb63-1ac7-4255-88de-cf93af34e5b4" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 234, DateTimeKind.Local).AddTicks(8746), new DateTime(2021, 7, 7, 11, 8, 20, 239, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 239, DateTimeKind.Local).AddTicks(1244), new DateTime(2021, 7, 7, 11, 8, 20, 239, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(1427), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(1727), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(4902), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5192), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5202), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5207), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5211), new DateTime(2021, 7, 7, 11, 8, 20, 240, DateTimeKind.Local).AddTicks(5213) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "9118fab5-fad0-4420-8593-b78fedb79c3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "db213df6-fd91-453c-9906-c1bd6871d49e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f9925b-8386-4d6a-92eb-ea623be0a0c6", "AQAAAAEAACcQAAAAEMe+hxAwBpou5tbvkxSYLlvT5mrUV3Prw8E7pcL3yAwlJeE8DtBqEKYV+CHOL2/GlA==", "73fe0dac-0642-4a49-86c7-85db7a8fb8e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c1e285-8e6d-4b08-a434-f0610223abbe", "AQAAAAEAACcQAAAAEE/H4X7gDkF+IWuhkh1AEzv79vnKfJbeuAdNTapptZRhkuJ8FKJqtOsB+KBBdvsLAQ==", "36e564bc-1c79-44c4-8a08-0937bfa7dc10" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 604, DateTimeKind.Local).AddTicks(6682), new DateTime(2021, 7, 7, 11, 7, 5, 609, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 609, DateTimeKind.Local).AddTicks(5035), new DateTime(2021, 7, 7, 11, 7, 5, 609, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 610, DateTimeKind.Local).AddTicks(6537), new DateTime(2021, 7, 7, 11, 7, 5, 610, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 610, DateTimeKind.Local).AddTicks(6844), new DateTime(2021, 7, 7, 11, 7, 5, 610, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1406), new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1704), new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1714), new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1719), new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1724), new DateTime(2021, 7, 7, 11, 7, 5, 611, DateTimeKind.Local).AddTicks(1726) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "14cefddd-49bd-40a3-97af-50dcdac1bf18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "dfb0fe0c-0075-4c9f-9e8e-607131025143");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1945594f-6276-4d3d-9000-8c7ea72789ee", "AQAAAAEAACcQAAAAEOREnrZjLvWAA3VohSOX1Hox7KSpspnhXVeKEDFf2bAASTtOozcuLBcr7mybYOd95g==", "30cb565f-92d7-41a9-af3a-bcf22e286751" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98b22dd5-030b-4449-968b-c7e521503732", "AQAAAAEAACcQAAAAEFsGJmGoVcv/U5F4FDbeoonq5S6Dfo5JETMi0XVT7glpLMn9jpW1VNtw+cqCBrStyw==", "b55fc01c-ee95-41d0-9230-35dca32a6528" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 472, DateTimeKind.Local).AddTicks(7193), new DateTime(2021, 7, 7, 11, 3, 33, 477, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 477, DateTimeKind.Local).AddTicks(1315), new DateTime(2021, 7, 7, 11, 3, 33, 477, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(1617), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(1915), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(4993), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5282), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5291), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5296), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5301), new DateTime(2021, 7, 7, 11, 3, 33, 478, DateTimeKind.Local).AddTicks(5302) });
        }
    }
}

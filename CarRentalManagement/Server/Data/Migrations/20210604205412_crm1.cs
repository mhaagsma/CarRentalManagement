using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class crm1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 4, 14, 54, 11, 604, DateTimeKind.Local).AddTicks(5555), new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(3569), "Black", "System" },
                    { 2, "System", new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(4465), new DateTime(2021, 6, 4, 14, 54, 11, 608, DateTimeKind.Local).AddTicks(4476), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5588), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5603), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5983), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(5991), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9409), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9423), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9728), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9736), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9738), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9741), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9744), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9746), "Y", "System" },
                    { 5, "System", new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9748), new DateTime(2021, 6, 4, 14, 54, 11, 609, DateTimeKind.Local).AddTicks(9750), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { -1, "System", new DateTime(2021, 6, 2, 13, 37, 30, 168, DateTimeKind.Local).AddTicks(3818), new DateTime(2021, 6, 2, 13, 37, 30, 172, DateTimeKind.Local).AddTicks(4245), "Black", "System" },
                    { -2, "System", new DateTime(2021, 6, 2, 13, 37, 30, 172, DateTimeKind.Local).AddTicks(5197), new DateTime(2021, 6, 2, 13, 37, 30, 172, DateTimeKind.Local).AddTicks(5208), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { -1, "System", new DateTime(2021, 6, 2, 13, 37, 30, 173, DateTimeKind.Local).AddTicks(6854), new DateTime(2021, 6, 2, 13, 37, 30, 173, DateTimeKind.Local).AddTicks(6871), "Toyota", "System" },
                    { -2, "System", new DateTime(2021, 6, 2, 13, 37, 30, 173, DateTimeKind.Local).AddTicks(7182), new DateTime(2021, 6, 2, 13, 37, 30, 173, DateTimeKind.Local).AddTicks(7191), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { -1, "System", new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(627), new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(640), "Prius", "System" },
                    { -2, "System", new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(945), new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(953), "Vitz", "System" },
                    { -3, "System", new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(956), new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(958), "3 Series", "System" },
                    { -4, "System", new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(960), new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(962), "Y", "System" },
                    { -5, "System", new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(965), new DateTime(2021, 6, 2, 13, 37, 30, 174, DateTimeKind.Local).AddTicks(967), "X5", "System" }
                });
        }
    }
}

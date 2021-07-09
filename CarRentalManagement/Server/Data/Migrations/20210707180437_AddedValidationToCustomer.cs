using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Customer",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                table: "Customer",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "emailAddress",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contact_number",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customer",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "firstname",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "emailAddress",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "contact_number",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customer",
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
    }
}

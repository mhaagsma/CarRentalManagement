using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TaxId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fefe7f5-b2ae-4b9c-acfb-525aa3960f12",
                column: "ConcurrencyStamp",
                value: "d1d2e8eb-b493-44a8-a320-0990d2f9deb0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd84aca-2438-4447-b68d-20ec959ff92b",
                column: "ConcurrencyStamp",
                value: "12afc235-3cca-44e5-90a3-26e2d089464b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1728f69c-93d3-4f87-adfd-72c613c4c000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96480351-28b5-414c-9356-ca2849292dc9", "AQAAAAEAACcQAAAAEC4FLPLR2/Umh/DNIXM3qtCecKA9hFHOzZ97BJrOKb/GwtFIy+Bsda17OhLqRzLpDQ==", "aa5c6016-f372-4e92-9bd8-65c3328e2d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea9571d-711e-4dc2-a670-b81e1a72b440",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe2ebad-d2fa-4252-b46e-da92b2138a50", "AQAAAAEAACcQAAAAELLa4SboO8XmUZs2+rq/WFYXxnKLhQ59hXmJHytXo5r8NPWotror8gNIzlcRkz+IFQ==", "9bc95567-d486-4798-8791-7e790dffaddf" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 383, DateTimeKind.Local).AddTicks(3115), new DateTime(2021, 7, 7, 10, 57, 17, 387, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 388, DateTimeKind.Local).AddTicks(966), new DateTime(2021, 7, 7, 10, 57, 17, 388, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(2146), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(2449), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(5753), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6295), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6308), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6313), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6318), new DateTime(2021, 7, 7, 10, 57, 17, 389, DateTimeKind.Local).AddTicks(6320) });
        }
    }
}

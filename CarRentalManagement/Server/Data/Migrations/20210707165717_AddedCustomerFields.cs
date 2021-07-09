using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class changefile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9e966ab1-2509-4eb6-b5d8-21a8b16be82d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "271b69ca-5c82-4f87-bceb-f624fade0aee", "AQAAAAEAACcQAAAAEG20BYjDsVHxwU6okximIV1lDiDD27dwg/Dp11BLgvEEAuCQmP/DO/C81ezY4uve1g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 31, 22, 31, 56, 123, DateTimeKind.Local).AddTicks(9339));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b6d172ea-29cd-4953-8a9b-48a8044ac35c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d5ca026-2ea1-4089-bea9-4235300cae1d", "AQAAAAEAACcQAAAAEEIfzAptWHrsenYYY+lPVZHRUStXKjKQZmTM3+xD0TYlSvxQgH+sORoiQT49OHzNDw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 12, 25, 14, 45, 18, 575, DateTimeKind.Local).AddTicks(1419));
        }
    }
}

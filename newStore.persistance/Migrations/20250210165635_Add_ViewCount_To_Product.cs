using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace newStore.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Add_ViewCount_To_Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 10, 20, 26, 33, 594, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 10, 20, 26, 33, 594, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 10, 20, 26, 33, 594, DateTimeKind.Local).AddTicks(4355));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 3, 19, 35, 37, 168, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 3, 19, 35, 37, 168, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2025, 2, 3, 19, 35, 37, 168, DateTimeKind.Local).AddTicks(874));
        }
    }
}

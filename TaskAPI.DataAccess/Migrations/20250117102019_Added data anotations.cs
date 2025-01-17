using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Addeddataanotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "45", "Colombo 1", "Street 1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "35", "Colombo 2", "Street 2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "25", "Colombo 3", "Street 3" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "15", "Colombo 4", "Street 4" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 50, 18, 563, DateTimeKind.Local).AddTicks(4397), new DateTime(2025, 1, 22, 15, 50, 18, 564, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 50, 18, 564, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 1, 22, 15, 50, 18, 564, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 50, 18, 564, DateTimeKind.Local).AddTicks(3129), new DateTime(2025, 1, 22, 15, 50, 18, 564, DateTimeKind.Local).AddTicks(3130) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(1480), new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9683), new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9689), new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9690) });
        }
    }
}

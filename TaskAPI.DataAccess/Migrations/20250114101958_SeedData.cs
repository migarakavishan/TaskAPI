using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedDate", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2025, 1, 14, 15, 49, 57, 911, DateTimeKind.Local).AddTicks(7296), "Get some text books for school", new DateTime(2025, 1, 19, 15, 49, 57, 912, DateTimeKind.Local).AddTicks(6757), 0, "Get books for school - DB" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

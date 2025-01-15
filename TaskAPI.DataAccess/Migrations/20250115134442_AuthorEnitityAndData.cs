using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEnitityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Migara Kavishan" },
                    { 2, "Sajith" },
                    { 3, "Nimal" },
                    { 4, "kamal" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "Due" },
                values: new object[] { 1, new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(1480), new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9683), "Go supermarket", new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9685), 0, "Need some  - DB" },
                    { 3, 2, new DateTime(2025, 1, 15, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9689), "Buy new camera", new DateTime(2025, 1, 20, 19, 14, 41, 736, DateTimeKind.Local).AddTicks(9690), 0, "Purchace Camera  - DB" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Due" },
                values: new object[] { new DateTime(2025, 1, 14, 15, 49, 57, 911, DateTimeKind.Local).AddTicks(7296), new DateTime(2025, 1, 19, 15, 49, 57, 912, DateTimeKind.Local).AddTicks(6757) });
        }
    }
}

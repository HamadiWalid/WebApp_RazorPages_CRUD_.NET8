using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp_RazorPages_.NetCore8.Migrations
{
    /// <inheritdoc />
    public partial class AddRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "Name", "Order", "PhoneNumber" },
                values: new object[] { 1, "Ruisseau", new DateTime(2024, 2, 28, 17, 39, 19, 741, DateTimeKind.Local).AddTicks(1798), "Client1@outlook.fr", "Client1", "S24 ultra", "0999999999" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

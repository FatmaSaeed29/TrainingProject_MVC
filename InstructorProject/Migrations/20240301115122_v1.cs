using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstructorProject.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "crs_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Degree", "crs_id" },
                values: new object[] { 57, 2 });

            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Degree", "crs_id" },
                values: new object[] { 50, 3 });

            migrationBuilder.InsertData(
                table: "CrsResult",
                columns: new[] { "Id", "Degree", "crs_id", "trainee_id" },
                values: new object[,]
                {
                    { 4, 98, 4, 4 },
                    { 5, 45, 5, 5 },
                    { 6, 66, 3, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Doaa Bassam");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 1,
                column: "crs_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Degree", "crs_id" },
                values: new object[] { 87, 3 });

            migrationBuilder.UpdateData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Degree", "crs_id" },
                values: new object[] { 87, 2 });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Fatma Koura");
        }
    }
}

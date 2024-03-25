using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstructorProject.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CrsResult",
                columns: new[] { "Id", "Degree", "crs_id", "trainee_id" },
                values: new object[] { 4, 98, 4, 4 });
        }
    }
}

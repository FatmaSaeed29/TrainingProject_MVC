using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstructorProject.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CrsResult",
                columns: new[] { "Id", "Degree", "crs_id", "trainee_id" },
                values: new object[] { 7, 66, 4, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrsResult",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}

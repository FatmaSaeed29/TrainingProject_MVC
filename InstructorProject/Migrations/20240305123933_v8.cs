using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstructorProject.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Name", "degree", "dept_id", "minDegree" },
                values: new object[,]
                {
                    { 1, "MVC", 100, 1, 60 },
                    { 2, "JavaScript", 100, 1, 60 },
                    { 3, "XML", 100, 2, 60 },
                    { 4, "Linq", 100, 2, 60 },
                    { 5, "Entity Framework", 100, 3, 60 }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "address", "crs_id", "dept_id", "imageUrl", "name", "salary" },
                values: new object[,]
                {
                    { 1, "Cairo", 1, 1, "female.png", "Rahaf Mohammed", 25000 },
                    { 2, "Alexx", 2, 2, "female.png", "Fatma Saeed", 25000 },
                    { 3, "Menofia", 3, 3, "male.png", "Mousa Ahmed", 25000 },
                    { 4, "Shebin ElKom", 1, 1, "male.png", "Belal Saeed", 25000 },
                    { 5, "Cairo", 2, 2, "female.png", "Habiba Ashraf", 25000 },
                    { 6, "Menia", 3, 2, "female.png", "Eman Fawzy", 25000 },
                    { 7, "Cairo", 1, 2, "female.png", "Asmaa Mohammed", 25000 },
                    { 8, "Cairo", 2, 1, "male.png", "Amr Ali", 25000 }
                });
        }
    }
}

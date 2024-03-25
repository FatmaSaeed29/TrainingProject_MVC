using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstructorProject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    degree = table.Column<int>(type: "int", nullable: false),
                    minDegree = table.Column<int>(type: "int", nullable: false),
                    dept_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Department_dept_id",
                        column: x => x.dept_id,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grade = table.Column<int>(type: "int", nullable: true),
                    dept_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainee_Department_dept_id",
                        column: x => x.dept_id,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<int>(type: "int", nullable: true),
                    dept_id = table.Column<int>(type: "int", nullable: true),
                    crs_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_crs_id",
                        column: x => x.crs_id,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_dept_id",
                        column: x => x.dept_id,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CrsResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(type: "int", nullable: true),
                    crs_id = table.Column<int>(type: "int", nullable: true),
                    trainee_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrsResult_Course_crs_id",
                        column: x => x.crs_id,
                        principalTable: "Course",
                        principalColumn: "Id", onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CrsResult_Trainee_trainee_id",
                        column: x => x.trainee_id,
                        principalTable: "Trainee",
                        principalColumn: "Id" , onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Manager", "Name" },
                values: new object[,]
                {
                    { 1, "Adam Mohammed", "PD" },
                    { 2, "Osama Saeed", "OS" },
                    { 3, "Tasneem Ahmed", "SD" }
                });

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
                table: "Trainee",
                columns: new[] { "Id", "Address", "Name", "dept_id", "grade", "imageUrl" },
                values: new object[,]
                {
                    { 1, "Cairo", "Fatma Koura", 1, 98, "female.ong" },
                    { 2, "Cairo", "Ali Mohammed", 2, 98, "male.ong" },
                    { 3, "Cairo", "Fatma Koura", 3, 98, "female.ong" }
                });

            migrationBuilder.InsertData(
                table: "CrsResult",
                columns: new[] { "Id", "Degree", "crs_id", "trainee_id" },
                values: new object[,]
                {
                    { 1, 87, 2, 1 },
                    { 2, 87, 3, 2 },
                    { 3, 87, 2, 3 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Course_dept_id",
                table: "Course",
                column: "dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_crs_id",
                table: "CrsResult",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_CrsResult_trainee_id",
                table: "CrsResult",
                column: "trainee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_crs_id",
                table: "Instructor",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_dept_id",
                table: "Instructor",
                column: "dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_dept_id",
                table: "Trainee",
                column: "dept_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrsResult");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}

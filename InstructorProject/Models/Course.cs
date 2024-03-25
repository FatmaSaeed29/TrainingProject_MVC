using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Name Must Be More Than 2 Letters")]
        [Unique]
        public string Name { get; set; }

        [Range(50, 100, ErrorMessage = "Degree Must Be Between 50 and 100")]
        public int degree { get; set; }

        [Display(Name = "Minimum Degree")]
        [Remote 
            (   "CheckMinDegree",
                "Course",
                ErrorMessage ="Minimum Degree Must Be Less Than Degree",
                AdditionalFields = "degree"
            )]
        public int minDegree { get; set; }

        [ForeignKey("Department")]

        [Display(Name = "Department")]
        public int dept_id { get; set; }
        public Department? Department { get; set; }
        public List<Instructor>? Instructors { get; set; }

        public List<CrsResult>? crsResults { get; set; }
    }
}

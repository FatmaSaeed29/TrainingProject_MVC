using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.Models
{
    public class Department
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("Instructor")]
        public string? Manager { get; set; }
        public List<Instructor>? Instructors { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Trainee>? Trainees { get; set; }
    }
}

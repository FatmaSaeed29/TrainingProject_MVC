using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string address { get; set; }
        public int salary { get; set; }

        [ForeignKey("Department")]
        public int? dept_id{ get; set; }

        [ForeignKey("Course")]
        public int? crs_id { get; set; }

        public Department Department { get; set; }
        public Course Course { get; set; }

    }
}

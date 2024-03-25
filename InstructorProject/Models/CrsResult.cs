using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.Models
{
    public class CrsResult
    {
        public int Id { get; set; }

        public int? Degree { get; set; }

        [ForeignKey("Course")]
        public int? crs_id { get; set; }

        [ForeignKey("Trainee")]
        public int? trainee_id { get; set; }

        public Course Course { get; set; }
        public Trainee Trainee { get; set; }

    }
}

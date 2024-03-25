using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? imageUrl { get; set; }
        public string? Address { get; set; }
        public int? grade { get; set; }

        [ForeignKey("Department")]
        public int? dept_id { get; set; }
        public Department Department { get; set; }

        public List<CrsResult>? crsResults { get; set; }

    }
}

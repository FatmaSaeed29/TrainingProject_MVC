using InstructorProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorProject.ViewModels
{
    public class InstructoraWithDepartmentAndCourseLists
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public string address { get; set; }
        public int salary { get; set; }
        public int? dept_id { get; set; }
        public int? crs_id { get; set; }

        public List<Department> departments { get; set; }
        public List<Course> courses { get; set; }
    }
}

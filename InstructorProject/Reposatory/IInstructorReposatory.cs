using InstructorProject.Models;
using Microsoft.EntityFrameworkCore;

namespace InstructorProject.Reposatory
{
    public interface IInstructorRepository
    {
        // get all instructors
        public List<Instructor> GetAll();

        // find by id
        public Instructor findById(int id);

        // add
        public void insert(Instructor obj);

        // save
        public int save();

        public List<Course> GetCoursesByDepartment(int departmentId);
    }
}
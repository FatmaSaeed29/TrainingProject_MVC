using InstructorProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace InstructorProject.Reposatory
{
    public class InstructorReposatory : IInstructorRepository
    {
        itiContext context;
        public InstructorReposatory()
        {
            context = new itiContext();
        }

        // CRUD opertaions

        // get all instructors
        public List<Instructor> GetAll()
        {
            return context.Instructor.ToList();
        }

        // find by id
        public Instructor findById(int id)
        {
            return context.Instructor
                                    .Include(i => i.Department)
                                    .Include(i => i.Course)
                                    .FirstOrDefault(x => x.Id == id);
        }

        // add
        public void insert(Instructor obj)
        {
            context.Add(obj);
        }

        // save
        public int save()
        {
            return context.SaveChanges();
        }

        // Get courses by department ID
       
        
        public List<Course> GetCoursesByDepartment(int departmentId)
        {
            return context.Course
                           .Where(c => c.dept_id == departmentId)
                           .ToList();
        }


    }
}

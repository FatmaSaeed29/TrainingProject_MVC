using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public class CourseReposatory : ICourseReposatory
    {
        itiContext context;
        public CourseReposatory(itiContext iticontext)
        {
            context = iticontext;
        }
        // CRUD operations

        // get all
        public List<Course> GetAll()
        {
            return context.Course.ToList();
        }

        // find by id
        public Course findById(int id)
        {
            return context.Course.FirstOrDefault(c => c.Id == id);
        }

        // insert
        public void insert(Course course)
        {
            context.Add(course);
        }

        // update
        public void update(Course course)
        {
            context.Update(course);
        }

        // delete
        public void Delete(int id)
        {
            Course course = findById(id);
            context.Remove(course);
        }

        // saveChanges
        public int save()
        {
            return context.SaveChanges();
        }
    }
}

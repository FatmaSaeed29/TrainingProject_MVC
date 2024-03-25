using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public class DepartmentReposatory : IDepartmentReposatory
    {

        itiContext context;
        public DepartmentReposatory(itiContext itiContext)
        {
            context = itiContext;
        }
        // CRUD operations

        // get all
        public List<Department> GetAll()
        {
            return context.Department.ToList();
        }

        // find by id
        public Department findById(int id)
        {
            return context.Department.FirstOrDefault(c => c.Id == id);
        }

        // insert
        public void insert(Department Dept)
        {
            context.Add(Dept);
        }

        // update
        public void update(Department Dept)
        {
            context.Update(Dept);
        }

        // delete
        public void Delete(int id)
        {
            Department Dept = findById(id);
            context.Remove(Dept);
        }

        // saveChanges
        public int save()
        {
            return context.SaveChanges();
        }
    }
}

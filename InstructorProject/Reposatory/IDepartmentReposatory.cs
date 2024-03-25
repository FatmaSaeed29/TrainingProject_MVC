using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public interface IDepartmentReposatory
    {
        // get all
        public List<Department> GetAll();


        // find by id
        public Department findById(int id);


        // insert
        public void insert(Department Dept);


        // update
        public void update(Department Dept);


        // delete
        public void Delete(int id);


        // saveChanges
        public int save();
        
    }
}
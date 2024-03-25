using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public interface ICourseReposatory
    {
        // get all
        public List<Course> GetAll();


        // find by id
        public Course findById(int id);


        // insert
        public void insert(Course course);
       

        // update
        public void update(Course course);


        // delete
        public void Delete(int id);


        // saveChanges
        public int save();
        
    }
}
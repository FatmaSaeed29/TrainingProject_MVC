using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public interface ITraineeReposatory
    {
        public Trainee findByID(int id);

    }
}
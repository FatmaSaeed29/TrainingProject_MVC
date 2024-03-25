using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public class TraineeReposatory : ITraineeReposatory
    {
        itiContext context;
        public TraineeReposatory(itiContext itiContext)
        {
            context = itiContext;
        }

        // findByID
        public Trainee findByID(int id)
        {
            return context.Trainee.FirstOrDefault(t => t.Id == id);
        }
    }
}

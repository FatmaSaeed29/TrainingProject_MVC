using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public interface ICrsResultRepository
    {
        public CrsResult courseOfTrainee(int id, int crsid);

    }
}
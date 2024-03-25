using InstructorProject.Models;

namespace InstructorProject.Reposatory
{
    public class CrsResultRepository : ICrsResultRepository
    {
        itiContext context;
        public CrsResultRepository(itiContext itiContext)
        {
            context = itiContext;
        }

        public CrsResult courseOfTrainee(int id, int crsid)
        {
            return context.CrsResult.FirstOrDefault(cr => cr.trainee_id==id && cr.crs_id == crsid);
        }
    }
}

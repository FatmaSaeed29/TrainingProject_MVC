using InstructorProject.Models;
using InstructorProject.Reposatory;
using InstructorProject.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace InstructorProject.Controllers
{
    public class TraineeController : Controller
    {
        //itiContext db = new itiContext();
        ITraineeReposatory traineeReposatory;
        ICrsResultRepository crsResultRepository;
        ICourseReposatory courseReposatory;

        public TraineeController(ITraineeReposatory traineeRepo , ICrsResultRepository crsRepo , ICourseReposatory courseRepo)
        {
            traineeReposatory = traineeRepo;
            crsResultRepository = crsRepo;
            courseReposatory = courseRepo;
        }

        public IActionResult ShowResult(int id , int crsid)
        {
            var Trainee = traineeReposatory.findByID(id);
            var Course = courseReposatory.findById(crsid);
            var CourseResult = crsResultRepository.courseOfTrainee(id, crsid);
       

            TraineeResultInSpeceficCourse viewModel = new TraineeResultInSpeceficCourse()
            {
                TraineeName = Trainee.Name,
                CourseName = Course.Name,
                Degree = CourseResult.Degree,
                MinDegree = Course.minDegree,
                Success ="green",
                Failed = "red"
            };

            return View("ShowResult",viewModel);
        }
    }
}

using InstructorProject.Models;
using InstructorProject.Reposatory;
using InstructorProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InstructorProject.Controllers
{
    public class InstructorController : Controller
    {
        //itiContext context = new itiContext();
        IInstructorRepository instructorRepository;
        ICourseReposatory courseReposatory;
        IDepartmentReposatory departmentReposatory;
        public InstructorController(IInstructorRepository instRepo , ICourseReposatory courseRepo , IDepartmentReposatory deptRepo)
        {
            instructorRepository = instRepo;
            courseReposatory = courseRepo;
            departmentReposatory = deptRepo;
        }
        public IActionResult All()
        {
            List<Instructor> InstructorModel = instructorRepository.GetAll();
            return View("all" , InstructorModel);
        }

        public IActionResult Details(int id)
        {
            var instructor = instructorRepository.findById(id);

            return View("Details", instructor);
        }

        public IActionResult New()
        {
                var viewModel = new InstructoraWithDepartmentAndCourseLists
                {
                    departments = departmentReposatory.GetAll(),
                    courses = courseReposatory.GetAll()
                };
                return View(viewModel);
        }

        [HttpPost]
        public IActionResult SaveNew(Instructor inst)
        {
            if(inst.name != null && inst.salary != null && inst.address != null)
            {
                instructorRepository.insert(inst);
                instructorRepository.save();
                return RedirectToAction("all");
            }
            return View("new" , inst);
        }

        public IActionResult CoursePerDepartment(int dept_id)
        {
            List<Course> courses = instructorRepository.GetCoursesByDepartment(dept_id);
            return Json(courses);
        }
    }
}

using InstructorProject.Models;
using InstructorProject.Reposatory;
using InstructorProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InstructorProject.Controllers
{
    public class CourseController : Controller
    {
        ICourseReposatory courseReposatory;
        IDepartmentReposatory departmentReposatory;
        public CourseController(ICourseReposatory courseRepo , IDepartmentReposatory deptRepo)
        {

            // injection
            courseReposatory = courseRepo;
            departmentReposatory = deptRepo;
        }

        public IActionResult All()
        {
            //var courses = context.Course.ToList();
            var courses = courseReposatory.GetAll();
            var courseViewModels = new List<CourseWithDepartmentList>();
            foreach (var course in courses)
            {
                var viewModel = new CourseWithDepartmentList
                {
                    Id = course.Id,
                    Name = course.Name,
                    degree = course.degree,
                    minDegree = course.minDegree,
                    dept_id = course.dept_id,
                    //departments = context.Department.ToList()
                    departments = departmentReposatory.GetAll()
                };
                courseViewModels.Add(viewModel);
            }
            return View("All", courseViewModels);
        }


        public IActionResult New()
        {
            var viewModel = new CourseWithDepartmentList
            {
                //departments = context.Department.ToList()
                departments = departmentReposatory.GetAll()
            };
            return View("New", viewModel);

        }

        public IActionResult saveNew(Course crs)
        {
            if (ModelState.IsValid == true)
            {
                //context.Add(crs);
                courseReposatory.insert(crs);
                //context.SaveChanges();
                courseReposatory.save();
                return RedirectToAction("All");
            }
            var viewModel = new CourseWithDepartmentList
            {
                Id = crs.Id,
                Name = crs.Name,
                degree = crs.degree,
                minDegree = crs.minDegree,
                dept_id = crs.dept_id,
                //departments = context.Department.ToList()
                departments = departmentReposatory.GetAll()

            };
            return View("New", viewModel);
        }

        public IActionResult CheckMinDegree(int minDegree , int degree)
        {
            if (minDegree<degree)
                return Json(true);
            else
                return Json(false);
        }


        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            //var course = context.Course.Find(id);
            var course = courseReposatory.findById(id);
            if (course != null)
            {
                //context.Course.Remove(course);
                courseReposatory.Delete(id);
                //context.SaveChanges();
                courseReposatory.save();
                return RedirectToAction("All");
            }
            else
            {
                return NotFound();
            }
        }
    }
}

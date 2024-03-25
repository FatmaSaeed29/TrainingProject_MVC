using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace InstructorProject.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("name", "Fatma Saeed");
            HttpContext.Session.SetInt32("age", 22);


            return Content("Data Saved");
        }

        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("name");
            int age = HttpContext.Session.GetInt32("age").Value;
            //HttpContext.Session.SetString("name", "Fatma Saeed");

            return Content($"Name: {name} , age: {age}");
        }
    }
}

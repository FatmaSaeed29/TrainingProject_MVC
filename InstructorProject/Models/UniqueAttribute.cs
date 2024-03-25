using InstructorProject.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace InstructorProject.Models
{
    public class UniqueAttribute : ValidationAttribute
    {
        itiContext db = new itiContext();
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = value.ToString();

            var crs = (Course)validationContext.ObjectInstance;

            var courseName = db.Course.FirstOrDefault(c => c.Name == name && c.dept_id == crs.dept_id);
            if (courseName == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name Already Exist!");

        }
    }
}
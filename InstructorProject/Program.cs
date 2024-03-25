using InstructorProject.Models;
using InstructorProject.Reposatory;
using Microsoft.EntityFrameworkCore;

namespace InstructorProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<itiContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Project"));
            });

            // Add services to the container.
            builder.Services.AddScoped<ICourseReposatory, CourseReposatory>();
            builder.Services.AddScoped<IDepartmentReposatory, DepartmentReposatory>();
            builder.Services.AddScoped<IInstructorRepository , InstructorReposatory>();
            builder.Services.AddScoped<ITraineeReposatory , TraineeReposatory>();   
            builder.Services.AddScoped<ICrsResultRepository  , CrsResultRepository>();

            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}


using Microsoft.EntityFrameworkCore;

namespace InstructorProject.Models
{
    public class itiContext :DbContext
    {
        public itiContext():base()
        {
            
        }

        public itiContext(DbContextOptions<itiContext> options) : base(options)
        {
            
        }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CrsResult> CrsResult { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MVC_Lab;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department() {Id=1, Name="PD", Manager="Adam Mohammed" });
            modelBuilder.Entity<Department>().HasData(new Department() { Id=2, Name="OS", Manager="Osama Saeed" });
            modelBuilder.Entity<Department>().HasData(new Department() { Id=3, Name="SD", Manager="Tasneem Ahmed" });

            //modelBuilder.Entity<Course>().HasData(new Course() { Id=1, Name="MVC", degree=100, minDegree=60,dept_id=1 });
            //modelBuilder.Entity<Course>().HasData(new Course() { Id=2, Name="JavaScript", degree=100, minDegree=60, dept_id=1 });
            //modelBuilder.Entity<Course>().HasData(new Course() { Id=3, Name="XML", degree=100, minDegree=60, dept_id=2 });
            //modelBuilder.Entity<Course>().HasData(new Course() { Id=4, Name="Linq", degree=100, minDegree=60, dept_id=2 });
            //modelBuilder.Entity<Course>().HasData(new Course() { Id=5, Name="Entity Framework", degree=100, minDegree=60, dept_id=3 });

            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=1, name="Rahaf Mohammed",imageUrl="female.png", address="Cairo", salary=25000 , dept_id=1 , crs_id=1});
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=2, name="Fatma Saeed", imageUrl="female.png", address="Alexx", salary=25000, dept_id=2, crs_id=2 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=3, name="Mousa Ahmed", imageUrl="male.png", address="Menofia", salary=25000, dept_id=3, crs_id=3 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=4, name="Belal Saeed", imageUrl="male.png", address="Shebin ElKom", salary=25000, dept_id=1, crs_id=1 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=5, name="Habiba Ashraf", imageUrl="female.png", address="Cairo", salary=25000, dept_id=2, crs_id=2 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=6, name="Eman Fawzy", imageUrl="female.png", address="Menia", salary=25000, dept_id=2, crs_id=3 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=7, name="Asmaa Mohammed", imageUrl="female.png", address="Cairo", salary=25000, dept_id=2, crs_id=1 });
            //modelBuilder.Entity<Instructor>().HasData(new Instructor() { Id=8, name="Amr Ali", imageUrl="male.png", address="Cairo", salary=25000, dept_id=1, crs_id=2 });

            modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id=1, Name="Fatma Koura", imageUrl="female.ong", Address="Cairo", dept_id=1, grade=98 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id=2, Name="Ali Mohammed", imageUrl="male.ong", Address="Cairo", dept_id=2, grade=98 });
            modelBuilder.Entity<Trainee>().HasData(new Trainee() { Id=3, Name="Doaa Bassam", imageUrl="female.ong", Address="Cairo", dept_id=3, grade=98 });
            
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=1, Degree=87, trainee_id=1 , crs_id=1 });
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=2, Degree=57, trainee_id=2, crs_id=2 });
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=3, Degree=50, trainee_id=3, crs_id=3 });
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=5, Degree=45, trainee_id=5, crs_id=5 });
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=6, Degree=66, trainee_id=2, crs_id=3 });
            modelBuilder.Entity<CrsResult>().HasData(new CrsResult() { Id=7, Degree=66, trainee_id=4, crs_id=4 });




            base.OnModelCreating(modelBuilder);
        }
    }
}

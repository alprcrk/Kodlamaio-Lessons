using KodlamaioSimulation.Business;
using KodlamaioSimulation.DataAccess.Concretes;
using KodlamaioSimulation.Entities;

namespace Kodlama_Io
{
    class Program
    {
        public static void Main(string[] args)
        {

            InstructorManager instructorManager = new InstructorManager(new InstructorDal());
            List<Instructor> instructors = instructorManager.GetAll();

            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();

            CourseManager courseManager = new CourseManager(new CourseDal());
            List<Course> courses = courseManager.GetAll();
            courseManager.Add(new Course
            {
                Id = 5,
                Name = "Fullstack Eğitim",
                Price = 0,
                Description = "Python & Django & Bootstrap",
                Instructor = instructors[2],
                Category = categories[0]
            });
            //courseManager.Delete(courses[0]);

            //Courses
            Console.WriteLine("-----Courses-----");
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
                Console.WriteLine(course.Description);
                Console.WriteLine(course.Instructor.Name);
                Console.WriteLine(course.Category.Name);
                Console.WriteLine("------------");
            }
        }
    }
}

using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Business
{
    class CourseManager
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(int courseId, string name, string description, double price)
        {
            foreach (var course in _courseDal.GetAll())
            {
                if (course.Id == courseId)
                {
                    course.Name = name;
                    course.Description = description;
                    course.Price = price;
                    break;
                }
            }
        }
    }
}

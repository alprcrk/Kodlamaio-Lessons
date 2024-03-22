using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;


        public InstructorDal()
        {
            _instructors = new List<Instructor>();
            _instructors.Add(new Instructor { Id = 1, Name = "Engin Demiroğ" });
            _instructors.Add(new Instructor { Id = 2, Name = "Halit Enes Kalaycı" });
            _instructors.Add(new Instructor { Id = 3, Name = "Alper Çırak" });
        }

        void IInstructorDal.Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        void IInstructorDal.Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        List<Instructor> IInstructorDal.GetAll()
        {
            return _instructors;
        }

        void IInstructorDal.Update(Instructor instructor, Instructor newInstructor)
        {
            instructor.Name = newInstructor.Name;
            instructor.Id = newInstructor.Id;   
            
        }
    }
}

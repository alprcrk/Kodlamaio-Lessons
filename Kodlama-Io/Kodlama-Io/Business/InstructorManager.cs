using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Business
{
    class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }
        public void Update(Instructor instructor, Instructor newInstructor)
        {
            _instructorDal.Update(instructor, newInstructor);
        }
    }
}

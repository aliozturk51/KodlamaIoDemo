using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {


        List<Instructor> _instructors;
        public InstructorDal()
        {
            
            Instructor instructor1 = new Instructor(1, "Engin DEMİROĞ");
            Instructor instructor2 = new Instructor(2, "Ali ÖZTÜRK");

            _instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            _instructors.Where(i=>i.InstructorId == instructorId);
            
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int instructorId)
        {
            var result = _instructors.FirstOrDefault(c => c.InstructorId == instructorId);
            return result;
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}

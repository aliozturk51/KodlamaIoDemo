using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);

        void Update(Instructor instructor);

        List<Instructor> GetAll();

        Instructor GetById(int instructorId);
    }
}

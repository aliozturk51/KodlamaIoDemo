using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);

        List<Course> GetAll();

        Course GetById(int id);
    }
}

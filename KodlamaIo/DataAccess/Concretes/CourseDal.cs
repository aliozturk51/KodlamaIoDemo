using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {

       List<Course> _courses;

        public CourseDal()
        {

            Course course1 = new Course(1, "C#", "Yazılım", 50, 1, 1);
            Course course2 = new Course(2, "Java", "Yazılım", 40, 2, 2);

            _courses = new List<Course> { course1, course2 };
            

        
        }
        public void Add(Course course)
        {
          _courses.Add(course);
        }

        public void Delete(int id)
        {
            _courses.RemoveAll(c => c.CategoryId == id); ;
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            var result = _courses.FirstOrDefault(c => c.CategoryId == id);
            return result;
        }

        public void Update(Course course)
        {
            
        }
    }
}

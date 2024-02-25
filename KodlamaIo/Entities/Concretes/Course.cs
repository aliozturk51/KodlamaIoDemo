using KodlamaIo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes
{
    public class Course : IEntity
    {


        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int InstructorId { get; set; }

        public double Price { get; set; }

        public Course(int courseId, string courseName, string description, int categoryId, int instructorId, double price)
        {
            CourseId = courseId;
            CourseName = courseName;
            Description = description;
            CategoryId = categoryId;
            InstructorId = instructorId;
            Price = price;
            
        }
    }
}

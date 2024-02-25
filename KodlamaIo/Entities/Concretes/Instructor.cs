using KodlamaIo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes
{
    public class Instructor:IEntity

    {

        public int InstructorId { get; set; }

        public string InstructorName { get; set; }

        public Instructor(int instructorId, string instructorName)
        {
            InstructorId = instructorId;
            InstructorName = instructorName;
        }

    }

}

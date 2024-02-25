using KodlamaIo.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities.Concretes
{

    public class Category : IEntity
    {

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;    

        }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }



}

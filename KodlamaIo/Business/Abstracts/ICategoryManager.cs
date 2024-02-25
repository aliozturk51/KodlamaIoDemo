using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Business.Abstracts
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(int CategoryId);
        void Update(Category category);

        List<Category> GetAll();

        Category GetById(int categoryId);
    }
}

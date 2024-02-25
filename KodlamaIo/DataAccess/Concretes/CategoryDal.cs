using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category(1, "C#");
            Category category2 = new Category(2, "Java");

            _categories = new List<Category> {  category1, category2 };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categories.RemoveAll(c => c.CategoryId == categoryId);

        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int categoryİd)
        {
            var result = _categories.FirstOrDefault(c => c.CategoryId == categoryİd);
            return result;
        }

        public void Update(Category category)
        {

        }
    }
}

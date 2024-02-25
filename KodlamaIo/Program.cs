// See https://aka.ms/new-console-template for more information


using KodlamaIo.Business.Concretes;
using KodlamaIo.DataAccess.Abstracts;
using KodlamaIo.DataAccess.Concretes;
using KodlamaIo.Entities.Concretes;

CategoryManager categoryManager = new(new CategoryDal());

categoryManager.Delete(1);

List<Category> categories = categoryManager.GetAll();

foreach (var category in categories) {
    Console.WriteLine(category.CategoryName);
}



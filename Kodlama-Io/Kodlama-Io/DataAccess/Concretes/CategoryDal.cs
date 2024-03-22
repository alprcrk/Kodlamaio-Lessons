using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;

    public CategoryDal() { 
       
        _categories = new List<Category>();
        _categories.Add(new Category { Id = 1 , Name = "Programlama"} ) ;
    }

    public void Add(Category category)
    {
       _categories.Add(category);
    }

    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public void Update(Category category, Category newCategory)
    {
        category.Id = newCategory.Id;
        category.Name = newCategory.Name;

    }
}

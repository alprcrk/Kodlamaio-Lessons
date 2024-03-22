using KodlamaioSimulation.DataAccess.Abstracts;
using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.Business;

class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }
    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }
    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }
    public void Update(Category category, Category newCategory) {
    
        _categoryDal.Update(category, newCategory);
    }
}

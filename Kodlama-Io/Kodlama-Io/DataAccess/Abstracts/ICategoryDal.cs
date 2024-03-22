using KodlamaioSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioSimulation.DataAccess.Abstracts;

public interface ICategoryDal
{
    void Add(Category category);
    void Update(Category category, Category newCategory);
    void Delete(Category category);
    List<Category> GetAll();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.Get(x=>x.Id == id);
        }

        public void Remove(Category category,int id)
        {
            var current = _categoryDal.Get(x => x.Id == id);
            current.Name = category.Name;
            _categoryDal.Delete(current);
        }

        public void Update(Category category,int id)
        {
            var current = _categoryDal.Get(x => x.Id == id);
            current.Name = category.Name;
            _categoryDal.Update(current);
        }
    }
}

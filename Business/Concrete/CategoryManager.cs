using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Repository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CreateCategory(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAllCategoriesNonDeleted()
        {
            return _categoryDal.GetAll(x => !x.IsDeleted);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

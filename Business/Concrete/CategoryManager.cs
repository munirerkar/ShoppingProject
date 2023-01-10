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
        public async Task CreateCategory(Category category)
        {
             await _categoryDal.Add(category);
        }

        public async Task<List<Category>> GetAllCategoriesNonDeleted()
        {
            return await _categoryDal.GetAll(x => !x.IsDeleted);
        }

        public async Task DeleteCategory(Category category)
        {
            await _categoryDal.Delete(category);
        }

        public async Task UpdateCategory(Category category)
        {
            await _categoryDal.Update(category);
        }

        public async Task<List<Category>> GetAllCategoriesDeleted()
        {
            return await _categoryDal.GetAll(x => x.IsDeleted);
        }
    }
}

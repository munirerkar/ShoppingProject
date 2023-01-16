using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult CreateCategory(Category category)
        {
             _categoryDal.Add(category);
             return new SuccessResult(Messages.CategoryAdded);
        }

        public async Task<List<Category>> GetAllCategoriesNonDeleted()
        {
            return await _categoryDal.GetAll(x => !x.IsDeleted);
        }

        public IResult DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public async Task<List<Category>> GetAllCategoriesDeleted()
        {
            return await _categoryDal.GetAll(x => x.IsDeleted);
        }
    }
}

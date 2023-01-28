using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Validation;
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
        [ValidationAspect(typeof(CategoryValidator))]
        public IResult CreateCategory(Category category)
        {
             _categoryDal.Add(category);
             return new SuccessResult(Messages.CategoryAdded);
        }

        public IDataResult<List<Category>> GetAllCategoriesNonDeleted()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(x => !x.IsDeleted));
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

        public  IDataResult<List<Category>> GetAllCategoriesDeleted()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(x => x.IsDeleted));
        }
    }
}

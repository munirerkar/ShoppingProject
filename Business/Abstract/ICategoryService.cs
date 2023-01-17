﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAllCategoriesNonDeleted();
        IDataResult<List<Category>> GetAllCategoriesDeleted();
        IResult CreateCategory(Category category);
        IResult UpdateCategory(Category category);
        IResult DeleteCategory(Category category);
    }
}

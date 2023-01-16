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
        Task<List<Category>> GetAllCategoriesNonDeleted();
        Task<List<Category>> GetAllCategoriesDeleted();
        IResult CreateCategory(Category category);
        IResult UpdateCategory(Category category);
        IResult DeleteCategory(Category category);
    }
}

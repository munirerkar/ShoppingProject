using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            return services;
        }
    }
}

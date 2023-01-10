using DataAccess.Abstract;
using DataAccess.Repository.Concrete;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ShoppingDbContext>, IBrandDal
    {
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public async Task CreateBrand(Brand brand)
        {
            await _brandDal.Add(brand);

        }

        public async Task DeleteBrand(Brand brand)
        {
            await _brandDal.Delete(brand);
        }

        public async Task<List<Brand>> GetAllBrandDeleted()
        {
            return await _brandDal.GetAll(x => x.IsDeleted);

        }

        public async Task<List<Brand>> GetAllBrandNonDeleted()
        {
            return await _brandDal.GetAll(x => !x.IsDeleted);
        }

        public async Task UpdateBrand(Brand brand)
        {
            await _brandDal.Update(brand);
        }
    }
}

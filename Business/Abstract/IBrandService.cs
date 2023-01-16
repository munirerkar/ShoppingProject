using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandNonDeleted();
        Task<List<Brand>> GetAllBrandDeleted();
        IResult CreateBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult DeleteBrand(Brand brand);
    }
}

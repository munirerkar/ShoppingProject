using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        Task<List<Brand>> GetAllBrandNonDeleted();
        Task<List<Brand>> GetAllBrandDeleted();
        Task CreateBrand(Brand brand);
        Task UpdateBrand(Brand brand);
        Task DeleteBrand(Brand brand);
    }
}

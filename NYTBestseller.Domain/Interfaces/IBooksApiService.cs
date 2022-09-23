using NYTBestseller.Domain.Models;

namespace NYTBestseller.Domain.Interfaces
{
    public interface IBooksApiService
    {
        Task<CategoriesDto<GeneralCategory>> GetBestsellerCategories();
        Task<CategoryDto<SpecificCategory>> GetBestsellerCategory(string categoryName);
    }
}

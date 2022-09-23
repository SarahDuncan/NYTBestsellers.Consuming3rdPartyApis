using NYTBestseller.Domain.Models;

namespace NYTBestseller.Domain.Interfaces
{
    public interface IBooksApiService
    {
        Task<CategoriesDto<GeneralCategory>> GetBestsellerCategories();
        Task<CategoryDto<SpecificCategory>> GetBestsellerCategory(string categoryName);
        Task<CategoriesDto<BookReview>> GetBookByAuthor(string author);
        Task<CategoriesDto<BookReview>> GetBookByTitle(string title);
        Task<CategoriesDto<BookReview>> GetBookByISBN(string isbn);


    }
}

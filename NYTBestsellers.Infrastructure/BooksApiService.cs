using Newtonsoft.Json;
using NYTBestseller.Domain.Interfaces;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Infrastructure
{
    public class BooksApiService : IBooksApiService
    {
        private readonly HttpClient _httpClient;
        const string apiKey = "";

        public BooksApiService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.nytimes.com/svc/books/v3/")
            };
        }

        public async Task<CategoriesDto<GeneralCategory>> GetBestsellerCategories()
        {
            var url = $"lists/names.json?api-key={apiKey}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<CategoriesDto<GeneralCategory>>(list);
                return categories;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        public async Task<CategoryDto<SpecificCategory>> GetBestsellerCategory(string categoryName)
        {
            var url = $"lists/{categoryName}.json?api-key={apiKey}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadAsStringAsync();
                var category = JsonConvert.DeserializeObject<CategoryDto<SpecificCategory>>(list);
                return category;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        public async Task<CategoriesDto<BookReview>> GetBookByAuthor(string author)
        {
            var url = $"reviews.json?author={author}&api-key={apiKey}";
            return GetBook(url).Result;
        }

        public async Task<CategoriesDto<BookReview>> GetBookByTitle(string title)
        {
            var url = $"reviews.json?title={title}&api-key={apiKey}";
            return GetBook(url).Result;
        }

        public async Task<CategoriesDto<BookReview>> GetBookByISBN(string isbn)
        {
            var url = $"reviews.json?isbn={isbn}&api-key={apiKey}";
            return GetBook(url).Result;
        }

        public async Task<CategoriesDto<BookReview>> GetBook(string url)
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var list = await response.Content.ReadAsStringAsync();
                var book = JsonConvert.DeserializeObject<CategoriesDto<BookReview>>(list);
                return book;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}
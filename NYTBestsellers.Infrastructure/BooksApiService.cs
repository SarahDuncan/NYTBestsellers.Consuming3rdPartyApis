using Newtonsoft.Json;
using NYTBestseller.Domain.Interfaces;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Infrastructure
{
    public class BooksApiService : IBooksApiService
    {
        private readonly HttpClient _httpClient;

        public BooksApiService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.nytimes.com/svc/books/v3/")
            };
        }

        public async Task<CategoriesDto<GeneralCategory>> GetBestsellerCategories()
        {
            var apiKey = "";
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
            var apiKey = "";
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
    }
}
using MediatR;
using NYTBestseller.Domain.Interfaces;

namespace NYTBestsellers.Application.Application.Queries.GetBestsellerCategories
{
    public class GetBestsellerCategoriesQueryHandler : IRequestHandler<GetBestsellerCategoriesQuery, GetBestsellerCategoriesQueryResult>
    {
        private readonly IBooksApiService apiService;

        public GetBestsellerCategoriesQueryHandler(IBooksApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<GetBestsellerCategoriesQueryResult> Handle(GetBestsellerCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await apiService.GetBestsellerCategories();

            return new GetBestsellerCategoriesQueryResult
            {
                Categories = categories
            };
        }
    }
}

using MediatR;
using NYTBestseller.Domain.Interfaces;

namespace NYTBestsellers.Application.Application.Queries.GetBestsellerCategory
{
    public class GetBestsellerCategoryQueryHandler : IRequestHandler<GetBestsellerCategoryQuery, GetBestsellerCategoryQueryResult>
    {
        private readonly IBooksApiService apiService;

        public GetBestsellerCategoryQueryHandler(IBooksApiService apiService) => this.apiService = apiService;

        public async Task<GetBestsellerCategoryQueryResult> Handle(GetBestsellerCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await apiService.GetBestsellerCategory(request.CategoryName);

            return new GetBestsellerCategoryQueryResult
            {
                Category = category
            };
        }
    }
}

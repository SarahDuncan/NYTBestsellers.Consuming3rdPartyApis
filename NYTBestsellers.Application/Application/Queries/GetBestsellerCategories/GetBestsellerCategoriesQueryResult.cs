using MediatR;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Application.Application.Queries.GetBestsellerCategories
{
    public class GetBestsellerCategoriesQueryResult : IRequest<GetBestsellerCategoriesQuery>
    {
        public CategoriesDto<GeneralCategory> Categories { get; set; } = null!;
    }
}

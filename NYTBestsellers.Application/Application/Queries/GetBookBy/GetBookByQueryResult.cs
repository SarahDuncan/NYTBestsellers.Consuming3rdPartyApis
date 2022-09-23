using MediatR;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Application.Application.Queries.GetBookBy
{
    public class GetBookByQueryResult : IRequest<GetBookByQuery>
    {
        public CategoriesDto<BookReview> BookReview { get; set; } = null!;
    }
}

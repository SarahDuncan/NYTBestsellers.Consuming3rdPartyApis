using MediatR;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Application.Application.Queries.GetBookByAuthor
{
    public class GetBookByAuthorQueryResult : IRequest<GetBookByAuthorQuery>
    {
        public CategoriesDto<BookReview> BookReview { get; set; }
    }
}

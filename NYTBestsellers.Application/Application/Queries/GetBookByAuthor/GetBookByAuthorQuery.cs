using MediatR;

namespace NYTBestsellers.Application.Application.Queries.GetBookByAuthor
{
    public class GetBookByAuthorQuery : IRequest<GetBookByAuthorQueryResult>
    {
        public string Author { get; set; } = null!;
    }
}

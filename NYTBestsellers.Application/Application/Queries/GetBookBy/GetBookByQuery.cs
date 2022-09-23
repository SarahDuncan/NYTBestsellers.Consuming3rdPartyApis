using MediatR;

namespace NYTBestsellers.Application.Application.Queries.GetBookBy
{
    public class GetBookByQuery : IRequest<GetBookByQueryResult>
    {
        public string? Author { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
    }
}

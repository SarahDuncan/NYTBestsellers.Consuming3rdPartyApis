using MediatR;
using NYTBestseller.Domain.Interfaces;

namespace NYTBestsellers.Application.Application.Queries.GetBookByAuthor
{
    public class GetBookByAuthorQueryHandler : IRequestHandler<GetBookByAuthorQuery, GetBookByAuthorQueryResult>
    {
        private readonly IBooksApiService apiService;

        public GetBookByAuthorQueryHandler(IBooksApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<GetBookByAuthorQueryResult> Handle(GetBookByAuthorQuery request, CancellationToken cancellationToken)
        {
            var bookReview = await apiService.GetBookByAuthor(request.Author);

            return new GetBookByAuthorQueryResult
            {
                BookReview = bookReview
            };
        }
    }
}

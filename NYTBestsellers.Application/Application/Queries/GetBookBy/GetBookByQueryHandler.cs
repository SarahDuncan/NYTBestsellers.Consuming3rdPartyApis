using MediatR;
using NYTBestseller.Domain.Interfaces;

namespace NYTBestsellers.Application.Application.Queries.GetBookBy
{
    public class GetBookByQueryHandler : IRequestHandler<GetBookByQuery, GetBookByQueryResult>
    {
        private readonly IBooksApiService apiService;

        public GetBookByQueryHandler(IBooksApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<GetBookByQueryResult> Handle(GetBookByQuery request, CancellationToken cancellationToken)
        {
            if (request.Author is not null)
            {
                var bookReview = await apiService.GetBookByAuthor(request.Author);
                return new GetBookByQueryResult
                {
                    BookReview = bookReview
                };
            }
            else if (request.Title is not null)
            {
                var bookReview = await apiService.GetBookByTitle(request.Title);
                return new GetBookByQueryResult
                {
                    BookReview = bookReview
                };
            }
            else if (request.ISBN is not null)
            {
                var bookReview = await apiService.GetBookByISBN(request.ISBN);
                return new GetBookByQueryResult
                {
                    BookReview = bookReview
                };
            }

            throw new InvalidOperationException();
        }
    }
}

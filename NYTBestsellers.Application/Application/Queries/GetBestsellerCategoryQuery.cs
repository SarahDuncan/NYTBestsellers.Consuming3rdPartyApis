using MediatR;

namespace NYTBestsellers.Application.Application.Queries
{
    public class GetBestsellerCategoryQuery : IRequest<GetBestsellerCategoryQueryResult>
    {
        public string CategoryName { get; set; } = null!;
    }
}

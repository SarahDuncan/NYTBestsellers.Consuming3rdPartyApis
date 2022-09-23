using MediatR;
using NYTBestseller.Domain.Models;

namespace NYTBestsellers.Application.Application.Queries
{
    public class GetBestsellerCategoryQueryResult : IRequest<GetBestsellerCategoryQuery>
    {
        public CategoryDto<SpecificCategory> Category { get; set; } = null!;
    }
}

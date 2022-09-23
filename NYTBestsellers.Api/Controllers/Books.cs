using MediatR;
using Microsoft.AspNetCore.Mvc;
using NYTBestsellers.Application.Application.Queries;

namespace NYTBestsellers.Api.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class Books : Controller
    {
        private readonly IMediator mediator;

        public Books(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("BestsellerCategories")]
        public async Task<IActionResult> BestsellersCategories()
        {
            var result = await mediator.Send(new GetBestsellerCategoriesQuery());

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("BestsellersCategory")]
        public async Task<IActionResult> BestsellersCategory(string categoryName)
        {
            var result = await mediator.Send(new GetBestsellerCategoryQuery() { CategoryName = categoryName });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}

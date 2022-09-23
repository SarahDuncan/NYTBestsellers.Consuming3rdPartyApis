using MediatR;
using Microsoft.AspNetCore.Mvc;
using NYTBestsellers.Application.Application.Queries.GetBestsellerCategories;
using NYTBestsellers.Application.Application.Queries.GetBestsellerCategory;
using NYTBestsellers.Application.Application.Queries.GetBookBy;

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

        [HttpGet]
        [Route("BookReviewByAuthor")]
        public async Task<IActionResult> GetBookByAuthor(string author)
        {
            var result = await mediator.Send(new GetBookByQuery() { Author = author });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("BookReviewByTitle")]
        public async Task<IActionResult> GetBookByTitle(string title)
        {
            var result = await mediator.Send(new GetBookByQuery() { Title = title });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("BookReviewByISBN")]
        public async Task<IActionResult> GetBookByISBN(string isbn)
        {
            var result = await mediator.Send(new GetBookByQuery() { ISBN = isbn });

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}

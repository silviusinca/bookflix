using Bookflix.Models.DTOs;
using Bookflix.Models;
using Bookflix.Services.ReviewService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("get-reviews")]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await _reviewService.GetAllReviews();
            return Ok(reviews);
        }

        [HttpPost("add-review")]
        public async Task<IActionResult> Create(ReviewRequestDTO review)
        {
            var reviewToCreate = new Review
            {
                BookID = review.BookID,
                UserID = review.UserID,
                Title = review.Title,
                Message = review.Message,
                Rating = review.Rating,
            };

            await _reviewService.Create(reviewToCreate);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateReview(Guid id, ReviewRequestDTO review)
        {
            var reviewToUpdate = _reviewService.GetById(id);
            if (review == null)
            {
                return BadRequest("The review ID was not found!");
            }
            
            reviewToUpdate.Title = review.Title;
            reviewToUpdate.Message = review.Message;
            reviewToUpdate.Rating = review.Rating;

            _reviewService.Save();

            return Ok();
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteApartment(Guid id)
        {
            var reviewToDelete = _reviewService.GetById(id);
            if (reviewToDelete == null)
            {
                return BadRequest("The review ID was not found!");
            }
            _reviewService.Delete(reviewToDelete);
            _reviewService.Save();
            return Ok();
        }
    }
}

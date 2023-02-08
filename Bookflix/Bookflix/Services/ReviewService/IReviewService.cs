using Bookflix.Models;

namespace Bookflix.Services.ReviewService
{
    public interface IReviewService
    {
        Review GetById(Guid id);
        Task Create(Review newReview);
        Task Update(Review updatedReview);
        Task Delete(Review reviewToDelete);
        Task<List<Review>> GetAllReviews();
        bool Save();
    }
}

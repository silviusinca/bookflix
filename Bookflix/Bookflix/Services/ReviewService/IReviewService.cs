using Bookflix.Models;

namespace Bookflix.Services.ReviewService
{
    public interface IReviewService
    {
        Review GetById(Guid id);
        Task Create(Review newReview);
        void Update(Review updatedReview);
        void Delete(Review reviewToDelete);
        Task<List<Review>> GetAllReviews();
        bool Save();
    }
}

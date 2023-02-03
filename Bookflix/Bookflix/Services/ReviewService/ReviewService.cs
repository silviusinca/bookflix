using Bookflix.Models;
using Bookflix.Repositories.ReviewRepository;

namespace Bookflix.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        public IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public async Task Create(Review newReview)
        {
            await _reviewRepository.CreateAsync(newReview);
            await _reviewRepository.SaveAsync();
        }

        public void Delete(Review reviewToDelete)
        {
            _reviewRepository.Delete(reviewToDelete);
        }

        public async Task<List<Review>> GetAllReviews()
        {
            return await _reviewRepository.GetAllAsync();
        }

        public Review GetById(Guid id)
        {
            return _reviewRepository.FindById(id);
        }

        public bool Save()
        {
            return _reviewRepository.Save();
        }

        public void Update(Review updatedReview)
        {
            _reviewRepository.Update(updatedReview);
        }
    }
}

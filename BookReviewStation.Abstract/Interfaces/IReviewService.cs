namespace BookReviewStation.Abstract.Interfaces
{
    using BookReviewStation.Models;
    using System.Collections.Generic;

    public interface IReviewService
    {
        ReviewStatistics GetCriticReviewScore(long bookId);
        ReviewStatistics GetUserReviewScore(long bookId);
        IEnumerable<Review> GetCriticsReviewsForBook(long bookId, int pageSize, int pageNumber);
        IEnumerable<Review> GetUserReviewsForBook(long bookId, int pageSize, int pageNumber);
        Review GetReview(long reviewId);
    }
}
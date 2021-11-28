namespace BookReviewStation.Models
{
    public class ReviewStatistics
    {
        public long BookId { get; set; }
        public long NumberOfReviews { get; set; }
        public double AverageRating { get; set; }
        public StatisticReviewType ReviewType { get; set; }
    }
}
namespace BookReviewStation.Service
{
    using BookReviewStation.Abstract.Interfaces;
    using BookReviewStation.Models;

    public class BookSeedService : IBookService
    {
        public BookDetails GetBookByBookId(long bookId)
        {
            return new BookDetails
            {
                AuthorName = "George Orwell",
                BookId = bookId,
                Description = "1984: A Novel, unleashes a unique plot as per which No One is Safe or Free. No place is safe to run or even hide from a dominating party leader, Big Brother, who is considered equal to God. This is a situation where everything is owned by the State. The world was seeing the ruins of World War II. Leaders such as Hitler, Stalin and Mussolini prevailed during this phase. Big Brother is always watching your actions.",
                ISBNDetails = new ISBNDetails
                {
                    ISBN10 = "9029543256",
                    ISBN13 = "978-9029543255"
                },
                Name = "1984",
                Publisher = "Amazing Reads",
                PhysicalBookDetails = new PhysicalBookDetails
                {
                    BookWeight = 330,
                    Height = 22,
                    Length = 14,
                    NumberOfPages = 310,
                    Width = 3
                },
                Language = "English",
                CountryOfOrigin = "India",
                Genre = "Thriller"
            };
        }

        public ReviewStatistics GetCriticsReviewStatistics(long bookId)
        {
            return new ReviewStatistics
            {
                ReviewType = StatisticReviewType.CriticReview,
                AverageRating = 4.7,
                NumberOfReviews = 231
            };
        }

        public ReviewStatistics GetUserReviewStatistics(long bookId)
        {
            return new ReviewStatistics
            {
                ReviewType = StatisticReviewType.UserReview,
                AverageRating = 4.9,
                NumberOfReviews = 57912
            };
        }
    }
}
namespace BookReviewStation.Service
{
    using System.Collections.Generic;
    using BookReviewStation.Abstract.Interfaces;
    using BookReviewStation.Models;

    public class ReviewSeedService : IReviewService
    {
        public ReviewStatistics GetCriticReviewScore(long bookId)
        {
            return new ReviewStatistics
            {
                AverageRating = 4.2,
                NumberOfReviews = 4221,
                ReviewType = StatisticReviewType.CriticReview
            };
        }

        public IEnumerable<Review> GetCriticsReviewsForBook(long bookId, int pageSize, int pageNumber)
        {
            return new List<Review>
            {
                new Review
                {
                    BookId = 1,
                    ReviewId = 1,
                    Rating = 4.8,
                    ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                    ReviewingOrganization = "The Atlantic",
                    Type = ReviewType.Critical,
                    ReviewerName = "John Doe",
                    ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
                },
                new Review
                {
                    BookId = 1,
                    ReviewId = 2,
                    Rating = 4.1,
                    ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                    ReviewingOrganization = "The Atlantic",
                    Type = ReviewType.Critical,
                    ReviewerName = "John Doe",
                    ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
                },
                new Review
                {
                    BookId = 1,
                    ReviewId = 3,
                    Rating = 4.0,
                    ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                    ReviewingOrganization = "The Atlantic",
                    Type = ReviewType.Critical,
                    ReviewerName = "John Doe",
                    ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
                },
                new Review
                {
                    BookId = 1,
                    ReviewId = 4,
                    Rating = 4.8,
                    ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                    ReviewingOrganization = "The Atlantic",
                    Type = ReviewType.Critical,
                    ReviewerName = "John Doe",
                    ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
                },
                new Review
                {
                    BookId = 1,
                    ReviewId = 5,
                    Rating = 4.9,
                    ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                    ReviewingOrganization = "The Atlantic",
                    Type = ReviewType.Critical,
                    ReviewerName = "John Doe",
                    ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
                }
            };
        }

        public Review GetReview(long reviewId)
        {
            return new Review
            {
                BookId = 1,
                ReviewId = 1,
                Rating = 4.8,
                ReviewDescription = "1984 will always be an essential book, regardless of changes in ideologies, for its portrayal of one person struggling to hold on to what is real and valuable. “Sanity is not statistical,” Winston thinks one night as he slips off to sleep. Truth, it turns out, is the most fragile thing in the world. The central drama of politics is the one inside your skull.",
                StatusCode = System.Net.HttpStatusCode.OK,
                ReviewTitle = "Doublethink Is Stronger Than Orwell Imagined",
                ReviewingOrganization = "The Atlantic",
                Type = ReviewType.Critical,
                ReviewerName = "John Doe",
                ReviewLink = "https://www.theatlantic.com/magazine/archive/2019/07/1984-george-orwell/590638/"
            };
        }

        public ReviewStatistics GetUserReviewScore(long bookId)
        {
            return new ReviewStatistics
            {
                AverageRating = 4.7,
                NumberOfReviews = 15723,
                ReviewType = StatisticReviewType.UserReview
            };
        }

        public IEnumerable<Review> GetUserReviewsForBook(long bookId, int pageSize, int pageNumber)
        {
            return new List<Review>
            {
                new Review
                {
                    ReviewTitle = "An amazing dyspotian based novel depicting the struggle of lives under the totalitarian rule",
                    Type = ReviewType.UserGenerated,
                    BookId = 1,
                    Rating = 4.0,
                    ReviewerName = "the_book_smugglers",
                    ReviewId = 7,
                    ReviewDescription = "What's captivating most about this book is how Orwell despite having written this in 1949, has dextrously crafted it to strike with chilling relevance to our times, when goverments around the world are pushing the envelope on authoritarianism."
                },
                new Review
                {
                    ReviewTitle = "An amazing dyspotian based novel depicting the struggle of lives under the totalitarian rule",
                    Type = ReviewType.UserGenerated,
                    BookId = 1,
                    Rating = 4.0,
                    ReviewerName = "the_book_smugglers",
                    ReviewId = 8,
                    ReviewDescription = "What's captivating most about this book is how Orwell despite having written this in 1949, has dextrously crafted it to strike with chilling relevance to our times, when goverments around the world are pushing the envelope on authoritarianism."
                },
                new Review
                {
                    ReviewTitle = "An amazing dyspotian based novel depicting the struggle of lives under the totalitarian rule",
                    Type = ReviewType.UserGenerated,
                    BookId = 1,
                    Rating = 4.0,
                    ReviewerName = "the_book_smugglers",
                    ReviewId = 9,
                    ReviewDescription = "What's captivating most about this book is how Orwell despite having written this in 1949, has dextrously crafted it to strike with chilling relevance to our times, when goverments around the world are pushing the envelope on authoritarianism."
                },
                new Review
                {
                    ReviewTitle = "An amazing dyspotian based novel depicting the struggle of lives under the totalitarian rule",
                    Type = ReviewType.UserGenerated,
                    BookId = 1,
                    Rating = 4.0,
                    ReviewerName = "the_book_smugglers",
                    ReviewId = 10,
                    ReviewDescription = "What's captivating most about this book is how Orwell despite having written this in 1949, has dextrously crafted it to strike with chilling relevance to our times, when goverments around the world are pushing the envelope on authoritarianism."
                },
                new Review
                {
                    ReviewTitle = "An amazing dyspotian based novel depicting the struggle of lives under the totalitarian rule",
                    Type = ReviewType.UserGenerated,
                    BookId = 1,
                    Rating = 4.0,
                    ReviewerName = "the_book_smugglers",
                    ReviewId = 11,
                    ReviewDescription = "What's captivating most about this book is how Orwell despite having written this in 1949, has dextrously crafted it to strike with chilling relevance to our times, when goverments around the world are pushing the envelope on authoritarianism."
                }
            };
        }
    }
}